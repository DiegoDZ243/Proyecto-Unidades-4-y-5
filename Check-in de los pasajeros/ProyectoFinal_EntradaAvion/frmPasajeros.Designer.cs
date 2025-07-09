namespace ProyectoFinal_EntradaAvion
{
    partial class frmPasajeros
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
            this.pnlPasajeros = new System.Windows.Forms.Panel();
            this.tlpPasajeros = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblADonde = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlPasajeros.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPasajeros
            // 
            this.pnlPasajeros.AutoScroll = true;
            this.pnlPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.pnlPasajeros.Controls.Add(this.tlpPasajeros);
            this.pnlPasajeros.Location = new System.Drawing.Point(271, 88);
            this.pnlPasajeros.Name = "pnlPasajeros";
            this.pnlPasajeros.Size = new System.Drawing.Size(624, 706);
            this.pnlPasajeros.TabIndex = 6;
            // 
            // tlpPasajeros
            // 
            this.tlpPasajeros.AutoScroll = true;
            this.tlpPasajeros.AutoSize = true;
            this.tlpPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.tlpPasajeros.ColumnCount = 2;
            this.tlpPasajeros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPasajeros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPasajeros.Location = new System.Drawing.Point(18, 15);
            this.tlpPasajeros.Name = "tlpPasajeros";
            this.tlpPasajeros.RowCount = 2;
            this.tlpPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPasajeros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPasajeros.Size = new System.Drawing.Size(495, 625);
            this.tlpPasajeros.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Controls.Add(this.lblADonde);
            this.pnlEncabezado.Location = new System.Drawing.Point(271, 12);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(624, 75);
            this.pnlEncabezado.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_EntradaAvion.Properties.Resources.icnEsperando;
            this.pictureBox1.Location = new System.Drawing.Point(487, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblADonde
            // 
            this.lblADonde.AutoSize = true;
            this.lblADonde.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADonde.ForeColor = System.Drawing.Color.White;
            this.lblADonde.Location = new System.Drawing.Point(70, 18);
            this.lblADonde.Name = "lblADonde";
            this.lblADonde.Size = new System.Drawing.Size(383, 40);
            this.lblADonde.TabIndex = 3;
            this.lblADonde.Text = "Pasajeros Ausentes";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 50);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1113, 873);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlPasajeros);
            this.Name = "frmPasajeros";
            this.Text = "Pasajeros Ausentes";
            this.Load += new System.EventHandler(this.frmPasajeros_Load);
            this.pnlPasajeros.ResumeLayout(false);
            this.pnlPasajeros.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPasajeros;
        private System.Windows.Forms.TableLayoutPanel tlpPasajeros;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblADonde;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}