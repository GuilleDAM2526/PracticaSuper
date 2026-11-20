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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSeleccionado = new Label();
            txtSeleccionado = new TextBox();
            lblNuevoComponente = new Label();
            btnAnadirStock = new Button();
            txtNuevoComponente = new TextBox();
            btnDescatalogar = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            lblCesta = new Label();
            lblStock = new Label();
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
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            barraEstado.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(773, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarProgramaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            cerrarProgramaToolStripMenuItem.Size = new Size(161, 22);
            cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "&Ver";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(773, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(101, 22);
            toolStripLabel1.Text = "Personalizar estilo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(29, 22);
            toolStripLabel2.Text = "Salir";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(200, 20);
            tabControl1.Location = new Point(12, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(745, 413);
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
            tabPage1.Controls.Add(btnDescatalogar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(737, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. Stock y cesta de componentes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblStock, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCesta, 2, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(listBox2, 2, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 2);
            tableLayoutPanel1.Controls.Add(button3, 1, 3);
            tableLayoutPanel1.Controls.Add(button4, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(6, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(725, 230);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(6, 285);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(84, 15);
            lblSeleccionado.TabIndex = 13;
            lblSeleccionado.Text = "Seleccionado:";
            // 
            // txtSeleccionado
            // 
            txtSeleccionado.Location = new Point(6, 305);
            txtSeleccionado.Name = "txtSeleccionado";
            txtSeleccionado.ReadOnly = true;
            txtSeleccionado.Size = new Size(500, 23);
            txtSeleccionado.TabIndex = 12;
            // 
            // lblNuevoComponente
            // 
            lblNuevoComponente.AutoSize = true;
            lblNuevoComponente.Location = new Point(6, 265);
            lblNuevoComponente.Name = "lblNuevoComponente";
            lblNuevoComponente.Size = new Size(201, 15);
            lblNuevoComponente.TabIndex = 11;
            lblNuevoComponente.Text = "Nuevo artículo (máx. 35 caract.):";
            // 
            // btnAnadirStock
            // 
            btnAnadirStock.Location = new Point(430, 260);
            btnAnadirStock.Name = "btnAnadirStock";
            btnAnadirStock.Size = new Size(130, 29);
            btnAnadirStock.TabIndex = 10;
            btnAnadirStock.Text = "Añadir a stock";
            btnAnadirStock.UseVisualStyleBackColor = true;
            // 
            // txtNuevoComponente
            // 
            txtNuevoComponente.Location = new Point(210, 262);
            txtNuevoComponente.MaxLength = 35;
            txtNuevoComponente.Name = "txtNuevoComponente";
            txtNuevoComponente.Size = new Size(210, 23);
            txtNuevoComponente.TabIndex = 9;
            // 
            // btnDescatalogar
            // 
            btnDescatalogar.Dock = DockStyle.Fill;
            btnDescatalogar.Location = new Point(6, 350);
            btnDescatalogar.Name = "btnDescatalogar";
            btnDescatalogar.Size = new Size(725, 29);
            btnDescatalogar.TabIndex = 8;
            btnDescatalogar.Text = "Descatalogar seleccionado de Stock";
            btnDescatalogar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Name = "button4";
            button4.TabIndex = 7;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Name = "button3";
            button3.TabIndex = 6;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Name = "button2";
            button2.TabIndex = 5;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Name = "button1";
            button1.TabIndex = 4;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Name = "listBox2";
            listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Name = "listBox1";
            listBox1.TabIndex = 2;
            // 
            // lblCesta
            // 
            lblCesta.BackColor = Color.FromArgb(50, 70, 150);
            lblCesta.Dock = DockStyle.Fill;
            lblCesta.ForeColor = Color.White;
            lblCesta.Name = "lblCesta";
            lblCesta.TabIndex = 1;
            lblCesta.Text = "Cesta del Equipo (lstCesta)";
            lblCesta.TextAlign = ContentAlignment.MiddleCenter;
            lblCesta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            // 
            // lblStock
            // 
            lblStock.BackColor = Color.FromArgb(50, 70, 150);
            lblStock.Dock = DockStyle.Fill;
            lblStock.ForeColor = Color.White;
            lblStock.Name = "lblStock";
            lblStock.TabIndex = 0;
            lblStock.Text = "Componentes en Stock (lstStock)";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(737, 385);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. Facturación de Equipos";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(737, 385);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3. Banco de Pruebas (Burn-In)";
            // 
            // imgIconos
            // 
            imgIconos.ImageSize = new Size(16, 16);
            // 
            // timerReloj
            // 
            timerReloj.Interval = 1000;
            timerReloj.Tick += TimerReloj_Tick;
            // 
            // iconoNotificacion
            // 
            iconoNotificacion.Text = "TPV Tienda Informática activo";
            iconoNotificacion.Visible = true;
            iconoNotificacion.ContextMenuStrip = menuNotificacion;
            // 
            // menuNotificacion
            // 
            menuNotificacion.Name = "menuNotificacion";
            menuNotificacion.Size = new Size(181, 48);
            // 
            // barraEstado
            // 
            barraEstado.Items.AddRange(new ToolStripItem[] { lblEstadoAccion, lblEstadoConteo, lblEstadoReloj });
            barraEstado.Location = new Point(0, 487);
            barraEstado.Name = "barraEstado";
            barraEstado.Size = new Size(773, 22);
            barraEstado.TabIndex = 3;
            barraEstado.Text = "statusStrip1";
            // 
            // lblEstadoAccion
            // 
            lblEstadoAccion.Name = "lblEstadoAccion";
            lblEstadoAccion.Size = new Size(567, 17);
            lblEstadoAccion.Spring = true;
            lblEstadoAccion.Text = "Última acción: ...";
            lblEstadoAccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstadoConteo
            // 
            lblEstadoConteo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            lblEstadoConteo.Name = "lblEstadoConteo";
            lblEstadoConteo.Size = new Size(141, 17);
            lblEstadoConteo.Text = "En Stock: 0 | En Cesta: 0";
            // 
            // lblEstadoReloj
            // 
            lblEstadoReloj.Name = "lblEstadoReloj";
            lblEstadoReloj.Size = new Size(60, 17);
            lblEstadoReloj.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 509);
            Controls.Add(barraEstado);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "PC-Rioja — Configurador y TPV de tienda de informática";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            barraEstado.ResumeLayout(false);
            barraEstado.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblStock;
        private Label lblCesta;
        private Button btnDescatalogar;
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
    }
}
