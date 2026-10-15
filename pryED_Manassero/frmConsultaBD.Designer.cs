namespace pryED_Manassero
{
    partial class frmConsultaBD
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
            this.dgvConsultaDos = new System.Windows.Forms.DataGridView();
            this.dgvConsultaUno = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaDos
            // 
            this.dgvConsultaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDos.Location = new System.Drawing.Point(12, 286);
            this.dgvConsultaDos.Name = "dgvConsultaDos";
            this.dgvConsultaDos.Size = new System.Drawing.Size(527, 197);
            this.dgvConsultaDos.TabIndex = 0;
            // 
            // dgvConsultaUno
            // 
            this.dgvConsultaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaUno.Location = new System.Drawing.Point(13, 35);
            this.dgvConsultaUno.Name = "dgvConsultaUno";
            this.dgvConsultaUno.Size = new System.Drawing.Size(526, 197);
            this.dgvConsultaUno.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(446, 247);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(10, 9);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(87, 13);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // frmConsultaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 509);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsultaUno);
            this.Controls.Add(this.dgvConsultaDos);
            this.Name = "frmConsultaBD";
            this.Text = "frmConsultaBD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaDos;
        private System.Windows.Forms.DataGridView dgvConsultaUno;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblConsulta;
    }
}