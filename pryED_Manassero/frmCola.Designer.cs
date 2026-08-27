namespace pryED_Manassero
{
    partial class frmCola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.txtTramite2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvGrilla2 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAgrupacion = new System.Windows.Forms.GroupBox();
            this.grpElemento.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAgrupacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpElemento
            // 
            this.grpElemento.Controls.Add(this.btnAgregar);
            this.grpElemento.Controls.Add(this.txtTramite);
            this.grpElemento.Controls.Add(this.txtCodigo);
            this.grpElemento.Controls.Add(this.txtNombre);
            this.grpElemento.Controls.Add(this.lblTramite);
            this.grpElemento.Controls.Add(this.lblNombre);
            this.grpElemento.Controls.Add(this.lblCodigo);
            this.grpElemento.Location = new System.Drawing.Point(14, 14);
            this.grpElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpElemento.Name = "grpElemento";
            this.grpElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpElemento.Size = new System.Drawing.Size(298, 342);
            this.grpElemento.TabIndex = 0;
            this.grpElemento.TabStop = false;
            this.grpElemento.Text = "Nuevo elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(176, 265);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(110, 175);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(148, 26);
            this.txtTramite.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 51);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 178);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(62, 20);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 115);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 51);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.txtTramite2);
            this.grpEliminar.Controls.Add(this.txtNombre2);
            this.grpEliminar.Controls.Add(this.txtCodigo2);
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.lblTramiteE);
            this.grpEliminar.Controls.Add(this.lblNombreE);
            this.grpEliminar.Controls.Add(this.lblCodigoE);
            this.grpEliminar.Location = new System.Drawing.Point(345, 14);
            this.grpEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminar.Size = new System.Drawing.Size(328, 342);
            this.grpEliminar.TabIndex = 1;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Elemento a eliminar";
            // 
            // txtTramite2
            // 
            this.txtTramite2.Location = new System.Drawing.Point(146, 178);
            this.txtTramite2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramite2.Name = "txtTramite2";
            this.txtTramite2.Size = new System.Drawing.Size(148, 26);
            this.txtTramite2.TabIndex = 6;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(146, 112);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(148, 26);
            this.txtNombre2.TabIndex = 5;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(146, 51);
            this.txtCodigo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(148, 26);
            this.txtCodigo2.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(183, 265);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.AutoSize = true;
            this.lblTramiteE.Location = new System.Drawing.Point(30, 182);
            this.lblTramiteE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(62, 20);
            this.lblTramiteE.TabIndex = 2;
            this.lblTramiteE.Text = "Trámite";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(27, 117);
            this.lblNombreE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(65, 20);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(27, 51);
            this.lblCodigoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoE.TabIndex = 0;
            this.lblCodigoE.Text = "Código";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(118, 27);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(296, 344);
            this.lstLista.TabIndex = 2;
            // 
            // dgvGrilla2
            // 
            this.dgvGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvGrilla2.Location = new System.Drawing.Point(488, 26);
            this.dgvGrilla2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla2.Name = "dgvGrilla2";
            this.dgvGrilla2.RowHeadersWidth = 62;
            this.dgvGrilla2.Size = new System.Drawing.Size(521, 355);
            this.dgvGrilla2.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Tramite";
            this.Trámite.MinimumWidth = 8;
            this.Trámite.Name = "Trámite";
            this.Trámite.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryED_Manassero.Properties.Resources.WhatsApp_Image_2026_08_20_at_11_44_21;
            this.pictureBox1.Location = new System.Drawing.Point(737, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // grpAgrupacion
            // 
            this.grpAgrupacion.Controls.Add(this.dgvGrilla2);
            this.grpAgrupacion.Controls.Add(this.lstLista);
            this.grpAgrupacion.Location = new System.Drawing.Point(40, 376);
            this.grpAgrupacion.Name = "grpAgrupacion";
            this.grpAgrupacion.Size = new System.Drawing.Size(1027, 389);
            this.grpAgrupacion.TabIndex = 5;
            this.grpAgrupacion.TabStop = false;
            this.grpAgrupacion.Text = "Listado en una Lista y en una Grilla";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1122, 777);
            this.Controls.Add(this.grpAgrupacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.grpElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.grpElemento.ResumeLayout(false);
            this.grpElemento.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAgrupacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.TextBox txtTramite2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvGrilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpAgrupacion;
    }
}