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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaDos
            // 
            this.dgvConsultaDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDos.Location = new System.Drawing.Point(116, 378);
            this.dgvConsultaDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultaDos.Name = "dgvConsultaDos";
            this.dgvConsultaDos.RowHeadersWidth = 51;
            this.dgvConsultaDos.Size = new System.Drawing.Size(703, 242);
            this.dgvConsultaDos.TabIndex = 0;
            // 
            // dgvConsultaUno
            // 
            this.dgvConsultaUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaUno.Location = new System.Drawing.Point(117, 69);
            this.dgvConsultaUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsultaUno.Name = "dgvConsultaUno";
            this.dgvConsultaUno.RowHeadersWidth = 51;
            this.dgvConsultaUno.Size = new System.Drawing.Size(701, 242);
            this.dgvConsultaUno.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(694, 319);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(124, 28);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(113, 37);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(106, 16);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // frmConsultaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 633);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsultaUno);
            this.Controls.Add(this.dgvConsultaDos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaBD";
            this.Text = "frmConsultaBD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUno)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaDos;
        private System.Windows.Forms.DataGridView dgvConsultaUno;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
    }
}