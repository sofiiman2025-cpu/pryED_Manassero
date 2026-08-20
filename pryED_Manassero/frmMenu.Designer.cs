namespace pryED_Manassero
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarUnaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasVariasConOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreYApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añoAcadémicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema ";
            // 
            // eLinealesToolStripMenuItem
            // 
            this.eLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.lSToolStripMenuItem,
            this.lDEToolStripMenuItem});
            this.eLinealesToolStripMenuItem.Name = "eLinealesToolStripMenuItem";
            this.eLinealesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eLinealesToolStripMenuItem.Text = "Estructurales Lineales ";
            this.eLinealesToolStripMenuItem.Click += new System.EventHandler(this.eLinealesToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // lSToolStripMenuItem
            // 
            this.lSToolStripMenuItem.Name = "lSToolStripMenuItem";
            this.lSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.lSToolStripMenuItem.Text = "Lista enlazada simple";
            // 
            // lDEToolStripMenuItem
            // 
            this.lDEToolStripMenuItem.Name = "lDEToolStripMenuItem";
            this.lDEToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.lDEToolStripMenuItem.Text = "Lista doblemente enlazada";
            this.lDEToolStripMenuItem.Click += new System.EventHandler(this.lDEToolStripMenuItem_Click);
            // 
            // estNoLinealesToolStripMenuItem
            // 
            this.estNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.estNoLinealesToolStripMenuItem.Name = "estNoLinealesToolStripMenuItem";
            this.estNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.estNoLinealesToolStripMenuItem.Text = "Est. No Lineales";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // bDToolStripMenuItem
            // 
            this.bDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarUnaTablaToolStripMenuItem,
            this.consultaDeBaseDeDatosToolStripMenuItem,
            this.operacionesEnBaseDeDatosToolStripMenuItem,
            this.consultasVariasConOperacionesToolStripMenuItem});
            this.bDToolStripMenuItem.Name = "bDToolStripMenuItem";
            this.bDToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.bDToolStripMenuItem.Text = "Base de datos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.eLinealesToolStripMenuItem,
            this.estNoLinealesToolStripMenuItem,
            this.bDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarUnaTablaToolStripMenuItem
            // 
            this.mostrarUnaTablaToolStripMenuItem.Name = "mostrarUnaTablaToolStripMenuItem";
            this.mostrarUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.mostrarUnaTablaToolStripMenuItem.Text = "Mostrar una tabla";
            // 
            // consultaDeBaseDeDatosToolStripMenuItem
            // 
            this.consultaDeBaseDeDatosToolStripMenuItem.Name = "consultaDeBaseDeDatosToolStripMenuItem";
            this.consultaDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultaDeBaseDeDatosToolStripMenuItem.Text = "Consulta de base de datos";
            // 
            // operacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operacionesEnBaseDeDatosToolStripMenuItem.Name = "operacionesEnBaseDeDatosToolStripMenuItem";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.operacionesEnBaseDeDatosToolStripMenuItem.Text = "Operaciones en base de datos";
            // 
            // consultasVariasConOperacionesToolStripMenuItem
            // 
            this.consultasVariasConOperacionesToolStripMenuItem.Name = "consultasVariasConOperacionesToolStripMenuItem";
            this.consultasVariasConOperacionesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultasVariasConOperacionesToolStripMenuItem.Text = "Consultas varias con operaciones";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreYApellidoToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.comisiónToolStripMenuItem,
            this.añoAcadémicoToolStripMenuItem});
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador";
            // 
            // nombreYApellidoToolStripMenuItem
            // 
            this.nombreYApellidoToolStripMenuItem.Name = "nombreYApellidoToolStripMenuItem";
            this.nombreYApellidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreYApellidoToolStripMenuItem.Text = "Nombre y apellido";
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carreraToolStripMenuItem.Text = "Carrera";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            // 
            // comisiónToolStripMenuItem
            // 
            this.comisiónToolStripMenuItem.Name = "comisiónToolStripMenuItem";
            this.comisiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comisiónToolStripMenuItem.Text = "Comisión";
            // 
            // añoAcadémicoToolStripMenuItem
            // 
            this.añoAcadémicoToolStripMenuItem.Name = "añoAcadémicoToolStripMenuItem";
            this.añoAcadémicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añoAcadémicoToolStripMenuItem.Text = "Año académico";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 462);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreYApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añoAcadémicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarUnaTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesEnBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasVariasConOperacionesToolStripMenuItem;
    }
}

