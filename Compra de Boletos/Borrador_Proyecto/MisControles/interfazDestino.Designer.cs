namespace MisControles
{
    partial class interfazDestino
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
            this.pcbDestino = new System.Windows.Forms.PictureBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnViajar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDestino
            // 
            this.pcbDestino.Image = global::MisControles.Properties.Resources.icnBuscar;
            this.pcbDestino.Location = new System.Drawing.Point(35, 57);
            this.pcbDestino.Name = "pcbDestino";
            this.pcbDestino.Size = new System.Drawing.Size(302, 252);
            this.pcbDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDestino.TabIndex = 0;
            this.pcbDestino.TabStop = false;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(110, 17);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(142, 28);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "lblDestino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // btnViajar
            // 
            this.btnViajar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajar.Location = new System.Drawing.Point(75, 312);
            this.btnViajar.Name = "btnViajar";
            this.btnViajar.Size = new System.Drawing.Size(215, 54);
            this.btnViajar.TabIndex = 2;
            this.btnViajar.Text = "Buscar vuelos";
            this.btnViajar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViajar.UseVisualStyleBackColor = true;
            // 
            // interfazDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.btnViajar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.pcbDestino);
            this.Name = "interfazDestino";
            this.Size = new System.Drawing.Size(370, 370);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDestino;
        private System.Windows.Forms.Label lblDestino;
        public System.Windows.Forms.Button btnViajar;
    }
}
