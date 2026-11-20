using System.Drawing;

namespace PracticaSuper
{
    public partial class Form1 : Form
    {
        private readonly string[] componentesStock =
        {
            "Procesador AMD Ryzen 7 9800X3D",
            "Placa Base ASUS TUF B650-PLUS",
            "Memoria RAM Corsair 32GB DDR5",
            "Fuente Alimentación 850W Gold"
        };

        public Form1()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        private void ConfigurarVentana()
        {
            Text = "PC-Rioja — Configurador y TPV de tienda de informática";
            StartPosition = FormStartPosition.CenterScreen;

            ConfigurarMenus();
            ConfigurarBarraHerramientas();
            ConfigurarStockYCesta();
            ConfigurarBandejaSistema();
            ConfigurarBarraEstado();

            timerReloj.Start();
            TimerReloj_Tick(this, EventArgs.Empty);
        }

        private void ConfigurarMenus()
        {
            archivoToolStripMenuItem.Text = "&Archivo";
            verToolStripMenuItem.Text = "&Ver";

            archivoToolStripMenuItem.DropDownItems.Clear();
            var guardar = new ToolStripMenuItem("Guardar albarán de montaje...", null, Guardar_Click)
            {
                ShortcutKeys = Keys.Control | Keys.G
            };
            var salir = new ToolStripMenuItem("&Salir", null, Salir_Click)
            {
                ShortcutKeys = Keys.Control | Keys.S
            };
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                guardar,
                new ToolStripSeparator(),
                salir
            });

            verToolStripMenuItem.DropDownItems.Clear();
            verToolStripMenuItem.DropDownItems.Add("1. Stock y cesta de componentes", null, (_, _) => tabControl1.SelectedIndex = 0);
            verToolStripMenuItem.DropDownItems.Add("2. Facturación de equipos", null, (_, _) => tabControl1.SelectedIndex = 1);
            verToolStripMenuItem.DropDownItems.Add("3. Banco de pruebas (Burn-In)", null, (_, _) => tabControl1.SelectedIndex = 2);
            verToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            verToolStripMenuItem.DropDownItems.Add("Personalizar estilo de ticket...", null, PersonalizarEstilo_Click);
        }

        private void ConfigurarBarraHerramientas()
        {
            toolStripLabel1.IsLink = true;
            toolStripLabel2.IsLink = true;
            toolStripLabel1.Click += PersonalizarEstilo_Click;
            toolStripLabel2.Click += Salir_Click;
        }

        private void ConfigurarStockYCesta()
        {
            listBox1.Name = "lstStock";
            listBox2.Name = "lstCesta";

            button1.Click += (_, _) => MoverSeleccionado(listBox1, listBox2);
            button2.Click += (_, _) => MoverTodos(listBox1, listBox2);
            button3.Click += (_, _) => MoverSeleccionado(listBox2, listBox1);
            button4.Click += (_, _) => MoverTodos(listBox2, listBox1);

            btnAnadirStock.Click += AnadirStock_Click;
            btnDescatalogar.Click += Descatalogar_Click;

            listBox1.SelectedIndexChanged += ListaStock_SelectedIndexChanged;
        }

        private void ConfigurarBandejaSistema()
        {
            iconoNotificacion.Icon = SystemIcons.Application;
            iconoNotificacion.Text = "TPV Tienda Informática activo";
            iconoNotificacion.Visible = true;
            iconoNotificacion.ContextMenuStrip = menuNotificacion;

            menuNotificacion.Items.Add("1. Stock y cesta", null, (_, _) => { tabControl1.SelectedIndex = 0; Show(); WindowState = FormWindowState.Normal; });
            menuNotificacion.Items.Add("2. Facturación de equipos", null, (_, _) => { tabControl1.SelectedIndex = 1; Show(); WindowState = FormWindowState.Normal; });
            menuNotificacion.Items.Add("3. Banco de pruebas", null, (_, _) => { tabControl1.SelectedIndex = 2; Show(); WindowState = FormWindowState.Normal; });
            menuNotificacion.Items.Add(new ToolStripSeparator());
            menuNotificacion.Items.Add("Cerrar programa", null, Salir_Click);

            iconoNotificacion.DoubleClick += (_, _) =>
            {
                Show();
                WindowState = FormWindowState.Normal;
                Activate();
            };
        }

        private void ConfigurarBarraEstado()
        {
            lblEstadoAccion.Spring = true;
            lblEstadoAccion.TextAlign = ContentAlignment.MiddleLeft;
            ActualizarContadores();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var componente in componentesStock)
            {
                listBox1.Items.Add(componente);
            }
            if (listBox1.Items.Count > 1)
                listBox1.SelectedIndex = 1;
            ActualizarContadores();
        }

        private void ListaStock_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtSeleccionado.Text = listBox1.SelectedItem?.ToString() ?? string.Empty;
        }

        private void AnadirStock_Click(object? sender, EventArgs e)
        {
            string nombre = txtNuevoComponente.Text.Trim();

            if (nombre.Length == 0)
            {
                MessageBox.Show("El componente no puede estar vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoComponente.Focus();
                return;
            }

            if (nombre.Length > 35)
            {
                MessageBox.Show("El componente supera los 35 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoComponente.Focus();
                return;
            }

            if (ExisteEnAlgunaLista(nombre))
            {
                MessageBox.Show("El componente ya existe en stock o en la cesta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevoComponente.Focus();
                return;
            }

            listBox1.Items.Add(nombre);
            txtNuevoComponente.Clear();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            RegistrarAccion("Componente añadido al stock");
        }

        private bool ExisteEnAlgunaLista(string nombre) =>
            listBox1.Items.Cast<object>().Any(x => string.Equals(x.ToString(), nombre, StringComparison.OrdinalIgnoreCase)) ||
            listBox2.Items.Cast<object>().Any(x => string.Equals(x.ToString(), nombre, StringComparison.OrdinalIgnoreCase));

        private void MoverSeleccionado(ListBox origen, ListBox destino)
        {
            if (origen.SelectedItem is not object elemento)
                return;

            int indice = origen.SelectedIndex;
            destino.Items.Add(elemento);
            origen.Items.Remove(elemento);

            if (origen.Items.Count > 0)
                origen.SelectedIndex = Math.Min(indice, origen.Items.Count - 1);

            RegistrarAccion("Componente movido");
        }

        private void MoverTodos(ListBox origen, ListBox destino)
        {
            if (origen.Items.Count == 0)
                return;

            var items = origen.Items.Cast<object>().ToArray();
            destino.Items.AddRange(items);
            origen.Items.Clear();
            RegistrarAccion("Todos los componentes movidos");
        }

        private void Descatalogar_Click(object? sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            int indice = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(indice);

            if (listBox1.Items.Count > 0)
            {
                if (indice > 0)
                    listBox1.SelectedIndex = indice - 1;
                else
                    listBox1.SelectedIndex = 0;
            }

            RegistrarAccion("Componente descatalogado de stock");
        }

        private void ActualizarContadores()
        {
            lblEstadoConteo.Text = $"En Stock: {listBox1.Items.Count} | En Cesta: {listBox2.Items.Count}";
        }

        private void RegistrarAccion(string accion)
        {
            lblEstadoAccion.Text = $"Última acción: {accion}";
            ActualizarContadores();
        }

        private void TimerReloj_Tick(object? sender, EventArgs e)
        {
            lblEstadoReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Guardar_Click(object? sender, EventArgs e)
        {
            RegistrarAccion("Albarán de montaje guardado");
        }

        private void PersonalizarEstilo_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("El formulario de personalización se añadirá en el Ejercicio 2.", "Personalizar estilo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Salir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer cerrar el TPV de la tienda?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
            else
                iconoNotificacion.Visible = false;
        }

        private void btnDescatalogar_Click(object sender, EventArgs e)
        {

        }
    }
}
