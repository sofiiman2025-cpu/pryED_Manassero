namespace pryED_Manassero
{
    partial class frmOperaciones
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.grpWhere = new System.Windows.Forms.GroupBox();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnProyeccion = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnSelecMul = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUnión = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.grpSelect.SuspendLayout();
            this.grpWhere.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 12);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(543, 192);
            this.dgvMostrar.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(12, 207);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(101, 13);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Boton seleccionado";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnJuntar);
            this.grpSelect.Controls.Add(this.btnMulti);
            this.grpSelect.Controls.Add(this.btnProyeccion);
            this.grpSelect.Location = new System.Drawing.Point(15, 239);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(209, 130);
            this.grpSelect.TabIndex = 2;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Operaciones de Proyección - SELECT";
            // 
            // grpWhere
            // 
            this.grpWhere.Controls.Add(this.button6);
            this.grpWhere.Controls.Add(this.btnSelecMul);
            this.grpWhere.Controls.Add(this.btnSeleccion);
            this.grpWhere.Location = new System.Drawing.Point(230, 239);
            this.grpWhere.Name = "grpWhere";
            this.grpWhere.Size = new System.Drawing.Size(206, 130);
            this.grpWhere.TabIndex = 3;
            this.grpWhere.TabStop = false;
            this.grpWhere.Text = "Operaciones de Proyección - WHERE";
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.btnDiferencia);
            this.grpOperaciones.Controls.Add(this.btnInt);
            this.grpOperaciones.Controls.Add(this.btnUnión);
            this.grpOperaciones.Location = new System.Drawing.Point(442, 239);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(178, 130);
            this.grpOperaciones.TabIndex = 4;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones Algebraicas";
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Location = new System.Drawing.Point(21, 30);
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Size = new System.Drawing.Size(165, 23);
            this.btnProyeccion.TabIndex = 0;
            this.btnProyeccion.Text = "Proyección simple";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(21, 59);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(165, 23);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Proyección multiatributo";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(21, 88);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(165, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(25, 30);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(165, 23);
            this.btnSeleccion.TabIndex = 1;
            this.btnSeleccion.Text = "Selección simple";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            // 
            // btnSelecMul
            // 
            this.btnSelecMul.Location = new System.Drawing.Point(25, 59);
            this.btnSelecMul.Name = "btnSelecMul";
            this.btnSelecMul.Size = new System.Drawing.Size(165, 23);
            this.btnSelecMul.TabIndex = 2;
            this.btnSelecMul.Text = "Selección multiatributo";
            this.btnSelecMul.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Selección por convolución";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnUnión
            // 
            this.btnUnión.Location = new System.Drawing.Point(6, 30);
            this.btnUnión.Name = "btnUnión";
            this.btnUnión.Size = new System.Drawing.Size(165, 23);
            this.btnUnión.TabIndex = 1;
            this.btnUnión.Text = "Unión";
            this.btnUnión.UseVisualStyleBackColor = true;
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(6, 59);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(165, 23);
            this.btnInt.TabIndex = 2;
            this.btnInt.Text = "Intersección";
            this.btnInt.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 88);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(165, 23);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(631, 388);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpWhere);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "frmOperaciones";
            this.Text = "Base de datos - Consulta SQL";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.grpSelect.ResumeLayout(false);
            this.grpWhere.ResumeLayout(false);
            this.grpOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.GroupBox grpWhere;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnProyeccion;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSelecMul;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnUnión;
    }
}