namespace interfacesPersonalizadas
{
    partial class interfazVuelo
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
            this.lblNumVuelo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumVuelo
            // 
            this.lblNumVuelo.AutoSize = true;
            this.lblNumVuelo.BackColor = System.Drawing.Color.White;
            this.lblNumVuelo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVuelo.ForeColor = System.Drawing.Color.Black;
            this.lblNumVuelo.Location = new System.Drawing.Point(100, 10);
            this.lblNumVuelo.Name = "lblNumVuelo";
            this.lblNumVuelo.Size = new System.Drawing.Size(120, 22);
            this.lblNumVuelo.TabIndex = 1;
            this.lblNumVuelo.Text = "No. Vuelo: ";
            this.lblNumVuelo.TextChanged += new System.EventHandler(this.lblNumVuelo_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(118, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 22);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Black;
            this.lblDestino.Location = new System.Drawing.Point(118, 231);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(94, 22);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(69, 269);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(166, 42);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Ir a vuelo";
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interfacesPersonalizadas.Properties.Resources.icn_Vuelo;
            this.pictureBox1.Location = new System.Drawing.Point(86, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // interfazVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(146)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumVuelo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "interfazVuelo";
            this.Size = new System.Drawing.Size(322, 321);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumVuelo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}
