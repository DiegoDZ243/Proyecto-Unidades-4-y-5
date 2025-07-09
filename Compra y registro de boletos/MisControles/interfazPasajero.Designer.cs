namespace MisControles
{
    partial class interfazPasajero
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.lblPasajero = new System.Windows.Forms.Label();
            this.pcbIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.lblPrecio.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(264, 17);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 28);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "------";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.lblAsiento.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(57)))), ((int)(((byte)(35)))));
            this.lblAsiento.Location = new System.Drawing.Point(146, 17);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(78, 28);
            this.lblAsiento.TabIndex = 1;
            this.lblAsiento.Text = "------";
            this.lblAsiento.TextChanged += new System.EventHandler(this.lblAsiento_TextChanged);
            // 
            // lblPasajero
            // 
            this.lblPasajero.AutoSize = true;
            this.lblPasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.lblPasajero.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(57)))), ((int)(((byte)(35)))));
            this.lblPasajero.Location = new System.Drawing.Point(18, 17);
            this.lblPasajero.Name = "lblPasajero";
            this.lblPasajero.Size = new System.Drawing.Size(93, 28);
            this.lblPasajero.TabIndex = 0;
            this.lblPasajero.Text = "adulto";
            this.lblPasajero.TextChanged += new System.EventHandler(this.lblPasajero_TextChanged);
            // 
            // pcbIcono
            // 
            this.pcbIcono.Image = global::MisControles.Properties.Resources.icn_menores;
            this.pcbIcono.Location = new System.Drawing.Point(379, 3);
            this.pcbIcono.Name = "pcbIcono";
            this.pcbIcono.Size = new System.Drawing.Size(70, 69);
            this.pcbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcono.TabIndex = 3;
            this.pcbIcono.TabStop = false;
            // 
            // interfazPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.pcbIcono);
            this.Controls.Add(this.lblPasajero);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAsiento);
            this.Name = "interfazPasajero";
            this.Size = new System.Drawing.Size(461, 72);
            this.Load += new System.EventHandler(this.interfazPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPasajero;
        private System.Windows.Forms.PictureBox pcbIcono;
    }
}
