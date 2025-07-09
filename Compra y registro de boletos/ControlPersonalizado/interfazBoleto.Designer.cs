namespace ControlPersonalizado
{
    partial class interfazBoleto
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
            this.components = new System.ComponentModel.Container();
            this.pnlBoleto = new System.Windows.Forms.Panel();
            this.pcbCodigo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumAsiento = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBoleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaterno)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoleto
            // 
            this.pnlBoleto.BackColor = System.Drawing.Color.White;
            this.pnlBoleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoleto.Controls.Add(this.pcbCodigo);
            this.pnlBoleto.Controls.Add(this.panel4);
            this.pnlBoleto.Controls.Add(this.lblNumAsiento);
            this.pnlBoleto.Controls.Add(this.label14);
            this.pnlBoleto.Controls.Add(this.lblAsiento);
            this.pnlBoleto.Controls.Add(this.label12);
            this.pnlBoleto.Controls.Add(this.lblFecha);
            this.pnlBoleto.Controls.Add(this.label10);
            this.pnlBoleto.Controls.Add(this.lblDestino);
            this.pnlBoleto.Controls.Add(this.lblOrigen);
            this.pnlBoleto.Controls.Add(this.label7);
            this.pnlBoleto.Controls.Add(this.label6);
            this.pnlBoleto.Controls.Add(this.lblNombre);
            this.pnlBoleto.Controls.Add(this.label4);
            this.pnlBoleto.Controls.Add(this.panel3);
            this.pnlBoleto.Controls.Add(this.panel2);
            this.pnlBoleto.Location = new System.Drawing.Point(23, 245);
            this.pnlBoleto.Name = "pnlBoleto";
            this.pnlBoleto.Size = new System.Drawing.Size(867, 310);
            this.pnlBoleto.TabIndex = 13;
            // 
            // pcbCodigo
            // 
            this.pcbCodigo.Location = new System.Drawing.Point(659, 21);
            this.pcbCodigo.Name = "pcbCodigo";
            this.pcbCodigo.Size = new System.Drawing.Size(190, 83);
            this.pcbCodigo.TabIndex = 21;
            this.pcbCodigo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 280);
            this.panel4.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlPersonalizado.Properties.Resources.avion_despegando;
            this.pictureBox3.Location = new System.Drawing.Point(17, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlPersonalizado.Properties.Resources.modo_avion;
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumAsiento
            // 
            this.lblNumAsiento.AutoSize = true;
            this.lblNumAsiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAsiento.Location = new System.Drawing.Point(540, 122);
            this.lblNumAsiento.Name = "lblNumAsiento";
            this.lblNumAsiento.Size = new System.Drawing.Size(87, 23);
            this.lblNumAsiento.TabIndex = 19;
            this.lblNumAsiento.Text = "-----------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(409, 122);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(125, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "No. de vuelo:";
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(494, 233);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(87, 23);
            this.lblAsiento.TabIndex = 17;
            this.lblAsiento.Text = "-----------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(407, 233);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Asiento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(481, 178);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(87, 23);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "-----------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 177);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(190, 190);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(87, 23);
            this.lblDestino.TabIndex = 13;
            this.lblDestino.Text = "-----------";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(167, 122);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(87, 23);
            this.lblOrigen.TabIndex = 12;
            this.lblOrigen.Text = "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hacia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "De: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(348, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 23);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del pasajero: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 15);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 15);
            this.panel2.TabIndex = 0;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(410, 188);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(291, 32);
            this.txtMaterno.TabIndex = 12;
            this.txtMaterno.TextChanged += new System.EventHandler(this.txtMaterno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido materno:";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(410, 127);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(291, 32);
            this.txtPaterno.TabIndex = 10;
            this.txtPaterno.TextChanged += new System.EventHandler(this.txtPaterno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(410, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 32);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(394, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "-------------";
            // 
            // errNombre
            // 
            this.errNombre.ContainerControl = this;
            // 
            // errPaterno
            // 
            this.errPaterno.ContainerControl = this;
            // 
            // errMaterno
            // 
            this.errMaterno.ContainerControl = this;
            // 
            // interfazBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBoleto);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "interfazBoleto";
            this.Size = new System.Drawing.Size(914, 562);
            this.Load += new System.EventHandler(this.interfazBoleto_Load);
            this.pnlBoleto.ResumeLayout(false);
            this.pnlBoleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigo)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaterno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoleto;
        private System.Windows.Forms.PictureBox pcbCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumAsiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errNombre;
        private System.Windows.Forms.ErrorProvider errPaterno;
        private System.Windows.Forms.ErrorProvider errMaterno;
    }
}
