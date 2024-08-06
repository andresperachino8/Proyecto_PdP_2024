namespace PruebaForms
{
    partial class principal
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
            tsAcciones = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            altaClienteToolStripMenuItem = new ToolStripMenuItem();
            resumenDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            tsReportes = new ToolStripMenuItem();
            tsSalir = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            lblFecha = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsAcciones, tsReportes, tsSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsAcciones
            // 
            tsAcciones.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, proveedoresToolStripMenuItem, ventasToolStripMenuItem, comprasToolStripMenuItem, stockToolStripMenuItem });
            tsAcciones.Name = "tsAcciones";
            tsAcciones.Size = new Size(67, 20);
            tsAcciones.Text = "Acciones";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaClienteToolStripMenuItem, resumenDeCuentaToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(139, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaClienteToolStripMenuItem
            // 
            altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            altaClienteToolStripMenuItem.Size = new Size(180, 22);
            altaClienteToolStripMenuItem.Text = "Datos de Clientes";
            altaClienteToolStripMenuItem.Click += altaClienteToolStripMenuItem_Click;
            // 
            // resumenDeCuentaToolStripMenuItem
            // 
            resumenDeCuentaToolStripMenuItem.Name = "resumenDeCuentaToolStripMenuItem";
            resumenDeCuentaToolStripMenuItem.Size = new Size(180, 22);
            resumenDeCuentaToolStripMenuItem.Text = "Resumen de Cuenta";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(139, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(139, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(139, 22);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(139, 22);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // tsReportes
            // 
            tsReportes.Name = "tsReportes";
            tsReportes.Size = new Size(12, 20);
            // 
            // tsSalir
            // 
            tsSalir.Name = "tsSalir";
            tsSalir.Size = new Size(41, 20);
            tsSalir.Text = "&Salir";
            tsSalir.Click += tsSalir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BorderStyle = BorderStyle.Fixed3D;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(6, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(135, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha actual: 1/1/2024";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Location = new Point(588, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 75);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 3;
            label1.Text = "Valor USD: $1200";
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "principal";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Gestión Concesionaria";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsAcciones;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem altaClienteToolStripMenuItem;
        private ToolStripMenuItem resumenDeCuentaToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label lblFecha;
        private ToolStripMenuItem tsReportes;
        private ToolStripMenuItem tsSalir;
        private GroupBox groupBox1;
        private Label label1;
    }
}
