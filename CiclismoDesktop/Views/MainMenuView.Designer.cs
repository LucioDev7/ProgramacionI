namespace CiclismoDesktop
{
    partial class MainMenuView
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
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProductosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeTipoDeProductoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesStoredProceduresToolStripMenuItem = new ToolStripMenuItem();
            gestionClientesORMToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProductosStoredProceduresToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            pruebasLinqToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeClientesToolStripMenuItem, gestionDeEmpleadosToolStripMenuItem, gestionDeProductosToolStripMenuItem, gestionDeTipoDeProductoToolStripMenuItem, gestionDeClientesStoredProceduresToolStripMenuItem, gestionClientesORMToolStripMenuItem, gestionDeProductosStoredProceduresToolStripMenuItem, pruebasLinqToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(80, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(358, 26);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            gestionDeClientesToolStripMenuItem.Click += gestionDeClientesToolStripMenuItem_Click;
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(358, 26);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            gestionDeEmpleadosToolStripMenuItem.Click += gestionDeEmpleadosToolStripMenuItem_Click;
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            gestionDeProductosToolStripMenuItem.Size = new Size(358, 26);
            gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            gestionDeProductosToolStripMenuItem.Click += gestionDeProductosToolStripMenuItem_Click;
            // 
            // gestionDeTipoDeProductoToolStripMenuItem
            // 
            gestionDeTipoDeProductoToolStripMenuItem.Name = "gestionDeTipoDeProductoToolStripMenuItem";
            gestionDeTipoDeProductoToolStripMenuItem.Size = new Size(358, 26);
            gestionDeTipoDeProductoToolStripMenuItem.Text = "Gestion de Tipo de Producto";
            gestionDeTipoDeProductoToolStripMenuItem.Click += gestionDeTipoDeProductoToolStripMenuItem_Click;
            // 
            // gestionDeClientesStoredProceduresToolStripMenuItem
            // 
            gestionDeClientesStoredProceduresToolStripMenuItem.Name = "gestionDeClientesStoredProceduresToolStripMenuItem";
            gestionDeClientesStoredProceduresToolStripMenuItem.Size = new Size(358, 26);
            gestionDeClientesStoredProceduresToolStripMenuItem.Text = "Gestion de Clientes Stored Procedures";
            gestionDeClientesStoredProceduresToolStripMenuItem.Click += gestionDeClientesStoredProceduresToolStripMenuItem_Click;
            // 
            // gestionClientesORMToolStripMenuItem
            // 
            gestionClientesORMToolStripMenuItem.Name = "gestionClientesORMToolStripMenuItem";
            gestionClientesORMToolStripMenuItem.Size = new Size(358, 26);
            gestionClientesORMToolStripMenuItem.Text = "Gestion Clientes ORM";
            gestionClientesORMToolStripMenuItem.Click += gestionClientesORMToolStripMenuItem_Click;
            // 
            // gestionDeProductosStoredProceduresToolStripMenuItem
            // 
            gestionDeProductosStoredProceduresToolStripMenuItem.Name = "gestionDeProductosStoredProceduresToolStripMenuItem";
            gestionDeProductosStoredProceduresToolStripMenuItem.Size = new Size(358, 26);
            gestionDeProductosStoredProceduresToolStripMenuItem.Text = "Gestion de Productos Stored Procedures";
            gestionDeProductosStoredProceduresToolStripMenuItem.Click += gestionDeProductosStoredProceduresToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(202, 26);
            salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // pruebasLinqToolStripMenuItem
            // 
            pruebasLinqToolStripMenuItem.Name = "pruebasLinqToolStripMenuItem";
            pruebasLinqToolStripMenuItem.Size = new Size(358, 26);
            pruebasLinqToolStripMenuItem.Text = "Pruebas Linq";
            pruebasLinqToolStripMenuItem.Click += pruebasLinqToolStripMenuItem_Click;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclismo Desktop Por Codigo";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private ToolStripMenuItem gestionDeTipoDeProductoToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesStoredProceduresToolStripMenuItem;
        private ToolStripMenuItem gestionClientesORMToolStripMenuItem;
        private ToolStripMenuItem gestionDeProductosStoredProceduresToolStripMenuItem;
        private ToolStripMenuItem pruebasLinqToolStripMenuItem;
    }
}
