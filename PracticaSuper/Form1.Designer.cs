namespace PracticaSuper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarProgramaToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblSeleccionado = new Label();
            txtSeleccionado = new TextBox();
            lblNuevoComponente = new Label();
            btnAnadirStock = new Button();
            txtNuevoComponente = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            imgIconos = new ImageList(components);
            timerReloj = new System.Windows.Forms.Timer(components);
            iconoNotificacion = new NotifyIcon(components);
            menuNotificacion = new ContextMenuStrip(components);
            barraEstado = new StatusStrip();
            lblEstadoAccion = new ToolStripStatusLabel();
            lblEstadoConteo = new ToolStripStatusLabel();
            lblEstadoReloj = new ToolStripStatusLabel();
            btnDescatalogar = new Button();
            listBox2 = new ListBox();
            panelTraspaso = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            lblCesta = new Label();
            lblStock = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            barraEstado.SuspendLayout();
            panelTraspaso.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(800, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarProgramaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            cerrarProgramaToolStripMenuItem.Size = new Size(244, 34);
            cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(53, 29);
            verToolStripMenuItem.Text = "&Ver";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(800, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(152, 25);
            toolStripLabel1.Text = "Personalizar estilo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(45, 25);
            toolStripLabel2.Text = "Salir";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 8.5F);
            tabControl1.ImageList = imgIconos;
            tabControl1.ItemSize = new Size(250, 32);
            tabControl1.Location = new Point(10, 87);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(780, 365);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(lblSeleccionado);
            tabPage1.Controls.Add(txtSeleccionado);
            tabPage1.Controls.Add(lblNuevoComponente);
            tabPage1.Controls.Add(btnAnadirStock);
            tabPage1.Controls.Add(txtNuevoComponente);
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(772, 325);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. Stock y cesta de componentes";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(9, 475);
            lblSeleccionado.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(114, 23);
            lblSeleccionado.TabIndex = 13;
            lblSeleccionado.Text = "Seleccionado:";
            // 
            // txtSeleccionado
            // 
            txtSeleccionado.Location = new Point(9, 508);
            txtSeleccionado.Margin = new Padding(4, 5, 4, 5);
            txtSeleccionado.Name = "txtSeleccionado";
            txtSeleccionado.ReadOnly = true;
            txtSeleccionado.Size = new Size(713, 30);
            txtSeleccionado.TabIndex = 12;
            // 
            // lblNuevoComponente
            // 
            lblNuevoComponente.AutoSize = true;
            lblNuevoComponente.Location = new Point(9, 442);
            lblNuevoComponente.Margin = new Padding(4, 0, 4, 0);
            lblNuevoComponente.Name = "lblNuevoComponente";
            lblNuevoComponente.Size = new Size(255, 23);
            lblNuevoComponente.TabIndex = 11;
            lblNuevoComponente.Text = "Nuevo artículo (máx. 35 caract.):";
            // 
            // btnAnadirStock
            // 
            btnAnadirStock.Location = new Point(614, 433);
            btnAnadirStock.Margin = new Padding(4, 5, 4, 5);
            btnAnadirStock.Name = "btnAnadirStock";
            btnAnadirStock.Size = new Size(186, 48);
            btnAnadirStock.TabIndex = 10;
            btnAnadirStock.Text = "Añadir a stock";
            btnAnadirStock.UseVisualStyleBackColor = true;
            // 
            // txtNuevoComponente
            // 
            txtNuevoComponente.Location = new Point(300, 437);
            txtNuevoComponente.Margin = new Padding(4, 5, 4, 5);
            txtNuevoComponente.MaxLength = 35;
            txtNuevoComponente.Name = "txtNuevoComponente";
            txtNuevoComponente.Size = new Size(298, 30);
            txtNuevoComponente.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(772, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. Facturación de Equipos";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Location = new Point(4, 36);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(772, 325);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3. Banco de Pruebas (Burn-In)";
            // 
            // imgIconos
            // 
            imgIconos.ColorDepth = ColorDepth.Depth32Bit;
            imgIconos.ImageSize = new Size(16, 16);
            imgIconos.TransparentColor = Color.Transparent;
            // 
            // timerReloj
            // 
            timerReloj.Enabled = true;
            timerReloj.Interval = 1000;
            timerReloj.Tick += TimerReloj_Tick;
            // 
            // iconoNotificacion
            // 
            iconoNotificacion.ContextMenuStrip = menuNotificacion;
            iconoNotificacion.Text = "TPV Tienda Informática activo";
            iconoNotificacion.Visible = true;
            // 
            // menuNotificacion
            // 
            menuNotificacion.ImageScalingSize = new Size(24, 24);
            menuNotificacion.Name = "menuNotificacion";
            menuNotificacion.Size = new Size(61, 4);
            // 
            // barraEstado
            // 
            barraEstado.ImageScalingSize = new Size(24, 24);
            barraEstado.Items.AddRange(new ToolStripItem[] { lblEstadoAccion, lblEstadoConteo, lblEstadoReloj });
            barraEstado.Location = new Point(0, 464);
            barraEstado.Name = "barraEstado";
            barraEstado.Padding = new Padding(1, 0, 20, 0);
            barraEstado.Size = new Size(800, 36);
            barraEstado.TabIndex = 3;
            barraEstado.Text = "statusStrip1";
            // 
            // lblEstadoAccion
            // 
            lblEstadoAccion.Name = "lblEstadoAccion";
            lblEstadoAccion.Size = new Size(451, 29);
            lblEstadoAccion.Spring = true;
            lblEstadoAccion.Text = "Última acción: ...";
            lblEstadoAccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstadoConteo
            // 
            lblEstadoConteo.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right;
            lblEstadoConteo.BorderStyle = Border3DStyle.Raised;
            lblEstadoConteo.Name = "lblEstadoConteo";
            lblEstadoConteo.Size = new Size(202, 29);
            lblEstadoConteo.Text = "En Stock: 0 | En Cesta: 0";
            // 
            // lblEstadoReloj
            // 
            lblEstadoReloj.Name = "lblEstadoReloj";
            lblEstadoReloj.Size = new Size(80, 29);
            lblEstadoReloj.Text = "00:00:00";
            // 
            // btnDescatalogar
            // 
            btnDescatalogar.Location = new Point(12, 201);
            btnDescatalogar.Margin = new Padding(12);
            btnDescatalogar.Name = "btnDescatalogar";
            btnDescatalogar.Size = new Size(304, 30);
            btnDescatalogar.TabIndex = 8;
            btnDescatalogar.Text = "Descatalogar seleccionado de Stock";
            btnDescatalogar.UseVisualStyleBackColor = true;
            btnDescatalogar.Click += btnDescatalogar_Click;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(438, 39);
            listBox2.Margin = new Padding(4, 5, 4, 5);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(322, 145);
            listBox2.TabIndex = 3;
            // 
            // panelTraspaso
            // 
            panelTraspaso.Anchor = AnchorStyles.None;
            panelTraspaso.Controls.Add(button1);
            panelTraspaso.Controls.Add(button2);
            panelTraspaso.Controls.Add(button3);
            panelTraspaso.Controls.Add(button4);
            panelTraspaso.FlowDirection = FlowDirection.TopDown;
            panelTraspaso.Location = new Point(328, 34);
            panelTraspaso.Margin = new Padding(0);
            panelTraspaso.Name = "panelTraspaso";
            panelTraspaso.Padding = new Padding(10, 0, 10, 0);
            panelTraspaso.Size = new Size(106, 155);
            panelTraspaso.TabIndex = 4;
            panelTraspaso.WrapContents = false;
            // 
            // button4
            // 
            button4.Location = new Point(30, 117);
            button4.Margin = new Padding(20, 3, 10, 3);
            button4.Name = "button4";
            button4.Size = new Size(52, 32);
            button4.TabIndex = 7;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(30, 79);
            button3.Margin = new Padding(20, 3, 10, 3);
            button3.Name = "button3";
            button3.Size = new Size(52, 32);
            button3.TabIndex = 6;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(30, 41);
            button2.Margin = new Padding(20, 3, 10, 3);
            button2.Name = "button2";
            button2.Size = new Size(52, 32);
            button2.TabIndex = 5;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 3);
            button1.Margin = new Padding(20, 3, 10, 3);
            button1.Name = "button1";
            button1.Size = new Size(52, 32);
            button1.TabIndex = 4;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(4, 39);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(320, 145);
            listBox1.TabIndex = 2;
            // 
            // lblCesta
            // 
            lblCesta.BackColor = Color.FromArgb(50, 70, 150);
            lblCesta.Dock = DockStyle.Fill;
            lblCesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCesta.ForeColor = Color.White;
            lblCesta.Location = new Point(438, 0);
            lblCesta.Margin = new Padding(4, 0, 4, 0);
            lblCesta.Name = "lblCesta";
            lblCesta.Size = new Size(322, 34);
            lblCesta.TabIndex = 1;
            lblCesta.Text = "Cesta del Equipo (lstCesta)";
            lblCesta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.BackColor = Color.FromArgb(50, 70, 150);
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(4, 0);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(320, 34);
            lblStock.TabIndex = 0;
            lblStock.Text = "Componentes en Stock (lstStock)";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(50, 70, 150);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(332, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 34);
            label1.TabIndex = 5;
            label1.Text = "Traspaso";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(lblStock, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCesta, 2, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(panelTraspaso, 1, 1);
            tableLayoutPanel1.Controls.Add(listBox2, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDescatalogar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(4, 5);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(764, 243);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(barraEstado);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC-Rioja — Configurador y TPV de tienda de informática";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            barraEstado.ResumeLayout(false);
            barraEstado.PerformLayout();
            panelTraspaso.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblTraspaso;
        private TextBox txtNuevoComponente;
        private Button btnAnadirStock;
        private Label lblNuevoComponente;
        private TextBox txtSeleccionado;
        private Label lblSeleccionado;
        private ImageList imgIconos;
        private System.Windows.Forms.Timer timerReloj;
        private NotifyIcon iconoNotificacion;
        private ContextMenuStrip menuNotificacion;
        private StatusStrip barraEstado;
        private ToolStripStatusLabel lblEstadoAccion;
        private ToolStripStatusLabel lblEstadoConteo;
        private ToolStripStatusLabel lblEstadoReloj;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblStock;
        private Label lblCesta;
        private ListBox listBox1;
        private FlowLayoutPanel panelTraspaso;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox2;
        private Button btnDescatalogar;
    }
}
