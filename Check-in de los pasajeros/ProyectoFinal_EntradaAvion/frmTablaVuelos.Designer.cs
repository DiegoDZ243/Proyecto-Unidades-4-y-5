namespace ProyectoFinal_EntradaAvion
{
    partial class frmTablaVuelos
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
            this.pnlVuelos = new System.Windows.Forms.Panel();
            this.tlpVuelos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblADonde = new System.Windows.Forms.Label();
            this.pnlVuelos.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVuelos
            // 
            this.pnlVuelos.AutoScroll = true;
            this.pnlVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
            this.pnlVuelos.Controls.Add(this.tlpVuelos);
            this.pnlVuelos.Location = new System.Drawing.Point(182, 113);
            this.pnlVuelos.Name = "pnlVuelos";
            this.pnlVuelos.Size = new System.Drawing.Size(726, 639);
            this.pnlVuelos.TabIndex = 0;
            // 
            // tlpVuelos
            // 
            this.tlpVuelos.AutoScroll = true;
            this.tlpVuelos.AutoSize = true;
            this.tlpVuelos.ColumnCount = 2;
            this.tlpVuelos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVuelos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVuelos.Location = new System.Drawing.Point(25, 31);
            this.tlpVuelos.Name = "tlpVuelos";
            this.tlpVuelos.RowCount = 2;
            this.tlpVuelos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVuelos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tlpVuelos.Size = new System.Drawing.Size(663, 571);
            this.tlpVuelos.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(147)))));
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Controls.Add(this.lblADonde);
            this.pnlEncabezado.Location = new System.Drawing.Point(182, 26);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(725, 87);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_EntradaAvion.Properties.Resources.icnBoleto1;
            this.pictureBox1.Location = new System.Drawing.Point(451, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblADonde
            // 
            this.lblADonde.AutoSize = true;
            this.lblADonde.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADonde.ForeColor = System.Drawing.Color.White;
            this.lblADonde.Location = new System.Drawing.Point(280, 31);
            this.lblADonde.Name = "lblADonde";
            this.lblADonde.Size = new System.Drawing.Size(142, 40);
            this.lblADonde.TabIndex = 2;
            this.lblADonde.Text = "Vuelos";
            // 
            // frmTablaVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1134, 821);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlVuelos);
            this.Name = "frmTablaVuelos";
            this.Text = "Tabla de Vuelos Disponibles";
            this.Load += new System.EventHandler(this.frmTablaVuelos_Load);
            this.pnlVuelos.ResumeLayout(false);
            this.pnlVuelos.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVuelos;
        private System.Windows.Forms.TableLayoutPanel tlpVuelos;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblADonde;
    }
}