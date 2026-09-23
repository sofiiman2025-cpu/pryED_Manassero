using System;

namespace pryED_Manassero
{
    partial class frmListaDoble
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
            this.grpAgrupacion = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.grpElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAgrupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpEliminar.SuspendLayout();
            this.grpElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgrupacion
            // 
            this.grpAgrupacion.BackColor = System.Drawing.Color.Cornsilk;
            this.grpAgrupacion.Controls.Add(this.dgvGrilla);
            this.grpAgrupacion.Controls.Add(this.lstLista);
            this.grpAgrupacion.Location = new System.Drawing.Point(16, 355);
            this.grpAgrupacion.Name = "grpAgrupacion";
            this.grpAgrupacion.Size = new System.Drawing.Size(998, 388);
            this.grpAgrupacion.TabIndex = 12;
            this.grpAgrupacion.TabStop = false;
            this.grpAgrupacion.Text = "Listado en una Lista y en una Grilla";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvGrilla.Location = new System.Drawing.Point(315, 29);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.Size = new System.Drawing.Size(670, 325);
            this.dgvGrilla.TabIndex = 5;
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
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(8, 28);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(296, 324);
            this.lstLista.TabIndex = 4;
            // 
            // grpEliminar
            // 
            this.grpEliminar.BackColor = System.Drawing.Color.Cornsilk;
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.comboBox1);
            this.grpEliminar.Controls.Add(this.lblCodigo2);
            this.grpEliminar.Location = new System.Drawing.Point(644, 18);
            this.grpEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminar.Size = new System.Drawing.Size(298, 300);
            this.grpEliminar.TabIndex = 11;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Elemento a eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(160, 231);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(24, 51);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo2.TabIndex = 1;
            this.lblCodigo2.Text = "Código";
            // 
            // grpElemento
            // 
            this.grpElemento.BackColor = System.Drawing.Color.Cornsilk;
            this.grpElemento.Controls.Add(this.btnAgregar);
            this.grpElemento.Controls.Add(this.txtTramite);
            this.grpElemento.Controls.Add(this.txtCodigo);
            this.grpElemento.Controls.Add(this.txtNombre);
            this.grpElemento.Controls.Add(this.lblTramite);
            this.grpElemento.Controls.Add(this.lblNombre);
            this.grpElemento.Controls.Add(this.lblCodigo);
            this.grpElemento.Location = new System.Drawing.Point(332, 18);
            this.grpElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpElemento.Name = "grpElemento";
            this.grpElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpElemento.Size = new System.Drawing.Size(298, 300);
            this.grpElemento.TabIndex = 10;
            this.grpElemento.TabStop = false;
            this.grpElemento.Text = "Nuevo elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(177, 231);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 300);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1036, 760);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAgrupacion);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.grpElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListaDoble";
            this.Text = "Lista Doblemente Ligada";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.grpAgrupacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.grpElemento.ResumeLayout(false);
            this.grpElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpAgrupacion;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox grpElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}