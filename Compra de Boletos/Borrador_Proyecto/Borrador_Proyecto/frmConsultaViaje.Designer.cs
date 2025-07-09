namespace Borrador_Proyecto
{
    partial class frmConsultaViaje
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaViaje));
            this.lblADonde = new System.Windows.Forms.Label();
            this.mtcSalida = new System.Windows.Forms.MonthCalendar();
            this.nmpAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.errDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSalida = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlPasajeros = new System.Windows.Forms.Panel();
            this.pcbFlecha = new System.Windows.Forms.PictureBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.pnlDesplegable = new System.Windows.Forms.Panel();
            this.nmpBebe = new System.Windows.Forms.NumericUpDown();
            this.nmpMenores = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errPasajeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlFondoDesplegable = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSalida = new System.Windows.Forms.Panel();
            this.pnlEncabezadoTabla = new System.Windows.Forms.Panel();
            this.pcbFlechas = new System.Windows.Forms.PictureBox();
            this.tlpDestinos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTablaDestinos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmpAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalida)).BeginInit();
            this.pnlPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlecha)).BeginInit();
            this.pnlDesplegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpBebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPasajeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlFondoDesplegable.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSalida.SuspendLayout();
            this.pnlEncabezadoTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlechas)).BeginInit();
            this.pnlTablaDestinos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblADonde
            // 
            this.lblADonde.AutoSize = true;
            this.lblADonde.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADonde.ForeColor = System.Drawing.Color.White;
            this.lblADonde.Location = new System.Drawing.Point(174, 15);
            this.lblADonde.Name = "lblADonde";
            this.lblADonde.Size = new System.Drawing.Size(309, 40);
            this.lblADonde.TabIndex = 1;
            this.lblADonde.Text = "¿A dónde viaja?";
            // 
            // mtcSalida
            // 
            this.mtcSalida.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtcSalida.Location = new System.Drawing.Point(35, 9);
            this.mtcSalida.Name = "mtcSalida";
            this.mtcSalida.TabIndex = 2;
            // 
            // nmpAdultos
            // 
            this.nmpAdultos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmpAdultos.Location = new System.Drawing.Point(154, 13);
            this.nmpAdultos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmpAdultos.Name = "nmpAdultos";
            this.nmpAdultos.Size = new System.Drawing.Size(123, 30);
            this.nmpAdultos.TabIndex = 8;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblPasajeros.Location = new System.Drawing.Point(13, 6);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(98, 20);
            this.lblPasajeros.TabIndex = 9;
            this.lblPasajeros.Text = "Pasajeros:";
            // 
            // errDestino
            // 
            this.errDestino.ContainerControl = this;
            // 
            // errSalida
            // 
            this.errSalida.ContainerControl = this;
            // 
            // pnlPasajeros
            // 
            this.pnlPasajeros.BackColor = System.Drawing.Color.White;
            this.pnlPasajeros.Controls.Add(this.pcbFlecha);
            this.pnlPasajeros.Controls.Add(this.lblResumen);
            this.pnlPasajeros.Controls.Add(this.lblPasajeros);
            this.pnlPasajeros.Location = new System.Drawing.Point(3, 12);
            this.pnlPasajeros.Name = "pnlPasajeros";
            this.pnlPasajeros.Size = new System.Drawing.Size(395, 73);
            this.pnlPasajeros.TabIndex = 11;
            this.pnlPasajeros.Click += new System.EventHandler(this.pnlPasajeros_Click);
            // 
            // pcbFlecha
            // 
            this.pcbFlecha.Image = ((System.Drawing.Image)(resources.GetObject("pcbFlecha.Image")));
            this.pcbFlecha.Location = new System.Drawing.Point(348, 26);
            this.pcbFlecha.Name = "pcbFlecha";
            this.pcbFlecha.Size = new System.Drawing.Size(31, 32);
            this.pcbFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFlecha.TabIndex = 11;
            this.pcbFlecha.TabStop = false;
            this.pcbFlecha.Click += new System.EventHandler(this.pcbFlecha_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(8, 38);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(65, 20);
            this.lblResumen.TabIndex = 10;
            this.lblResumen.Text = "-------";
            // 
            // pnlDesplegable
            // 
            this.pnlDesplegable.BackColor = System.Drawing.Color.White;
            this.pnlDesplegable.Controls.Add(this.nmpBebe);
            this.pnlDesplegable.Controls.Add(this.nmpMenores);
            this.pnlDesplegable.Controls.Add(this.label7);
            this.pnlDesplegable.Controls.Add(this.label8);
            this.pnlDesplegable.Controls.Add(this.label5);
            this.pnlDesplegable.Controls.Add(this.nmpAdultos);
            this.pnlDesplegable.Controls.Add(this.label6);
            this.pnlDesplegable.Controls.Add(this.label4);
            this.pnlDesplegable.Controls.Add(this.label3);
            this.pnlDesplegable.Location = new System.Drawing.Point(2, 87);
            this.pnlDesplegable.Name = "pnlDesplegable";
            this.pnlDesplegable.Size = new System.Drawing.Size(307, 168);
            this.pnlDesplegable.TabIndex = 12;
            this.pnlDesplegable.Visible = false;
            // 
            // nmpBebe
            // 
            this.nmpBebe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmpBebe.Location = new System.Drawing.Point(154, 114);
            this.nmpBebe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmpBebe.Name = "nmpBebe";
            this.nmpBebe.Size = new System.Drawing.Size(123, 30);
            this.nmpBebe.TabIndex = 17;
            // 
            // nmpMenores
            // 
            this.nmpMenores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmpMenores.Location = new System.Drawing.Point(154, 67);
            this.nmpMenores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmpMenores.Name = "nmpMenores";
            this.nmpMenores.Size = new System.Drawing.Size(123, 30);
            this.nmpMenores.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bebé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label8.Location = new System.Drawing.Point(11, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "(0 - 23 meses)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Menor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "(2-12 años)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "(13+ años)";
            // 
            // errPasajeros
            // 
            this.errPasajeros.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(172)))), ((int)(((byte)(183)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pnlFondoDesplegable);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlSalida);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 721);
            this.panel1.TabIndex = 16;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(99)))), ((int)(((byte)(106)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(11, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 41);
            this.panel5.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(72, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "¿Cuántos viajan?";
            // 
            // pnlFondoDesplegable
            // 
            this.pnlFondoDesplegable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.pnlFondoDesplegable.Controls.Add(this.pnlDesplegable);
            this.pnlFondoDesplegable.Controls.Add(this.pnlPasajeros);
            this.pnlFondoDesplegable.Location = new System.Drawing.Point(10, 396);
            this.pnlFondoDesplegable.Name = "pnlFondoDesplegable";
            this.pnlFondoDesplegable.Size = new System.Drawing.Size(427, 265);
            this.pnlFondoDesplegable.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(99)))), ((int)(((byte)(106)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(25, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 41);
            this.panel4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "¿Cuándo viaja?";
            // 
            // pnlSalida
            // 
            this.pnlSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.pnlSalida.Controls.Add(this.mtcSalida);
            this.pnlSalida.Location = new System.Drawing.Point(25, 68);
            this.pnlSalida.Name = "pnlSalida";
            this.pnlSalida.Size = new System.Drawing.Size(367, 239);
            this.pnlSalida.TabIndex = 15;
            // 
            // pnlEncabezadoTabla
            // 
            this.pnlEncabezadoTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.pnlEncabezadoTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezadoTabla.Controls.Add(this.lblADonde);
            this.pnlEncabezadoTabla.Controls.Add(this.pcbFlechas);
            this.pnlEncabezadoTabla.Location = new System.Drawing.Point(511, 150);
            this.pnlEncabezadoTabla.Name = "pnlEncabezadoTabla";
            this.pnlEncabezadoTabla.Size = new System.Drawing.Size(675, 72);
            this.pnlEncabezadoTabla.TabIndex = 17;
            this.pnlEncabezadoTabla.Click += new System.EventHandler(this.panel2_Click);
            // 
            // pcbFlechas
            // 
            this.pcbFlechas.Image = ((System.Drawing.Image)(resources.GetObject("pcbFlechas.Image")));
            this.pcbFlechas.Location = new System.Drawing.Point(569, 5);
            this.pcbFlechas.Name = "pcbFlechas";
            this.pcbFlechas.Size = new System.Drawing.Size(68, 61);
            this.pcbFlechas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFlechas.TabIndex = 10;
            this.pcbFlechas.TabStop = false;
            // 
            // tlpDestinos
            // 
            this.tlpDestinos.AutoScroll = true;
            this.tlpDestinos.AutoSize = true;
            this.tlpDestinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.tlpDestinos.ColumnCount = 2;
            this.tlpDestinos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDestinos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDestinos.Location = new System.Drawing.Point(15, 12);
            this.tlpDestinos.Name = "tlpDestinos";
            this.tlpDestinos.RowCount = 2;
            this.tlpDestinos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDestinos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDestinos.Size = new System.Drawing.Size(646, 479);
            this.tlpDestinos.TabIndex = 20;
            // 
            // pnlTablaDestinos
            // 
            this.pnlTablaDestinos.AutoScroll = true;
            this.pnlTablaDestinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(200)))));
            this.pnlTablaDestinos.Controls.Add(this.tlpDestinos);
            this.pnlTablaDestinos.Location = new System.Drawing.Point(511, 223);
            this.pnlTablaDestinos.Name = "pnlTablaDestinos";
            this.pnlTablaDestinos.Size = new System.Drawing.Size(675, 516);
            this.pnlTablaDestinos.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.lblTitulo.Location = new System.Drawing.Point(374, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(562, 48);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Aeropuerto \"AeroPlace\"";
            // 
            // frmConsultaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(181)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1335, 1048);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlEncabezadoTabla);
            this.Controls.Add(this.pnlTablaDestinos);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaViaje";
            this.Text = "Manejador de vuelos";
            this.Load += new System.EventHandler(this.frmConsultaViaje_Load);
            this.Click += new System.EventHandler(this.frmConsultaViaje_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nmpAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalida)).EndInit();
            this.pnlPasajeros.ResumeLayout(false);
            this.pnlPasajeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlecha)).EndInit();
            this.pnlDesplegable.ResumeLayout(false);
            this.pnlDesplegable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpBebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmpMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPasajeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlFondoDesplegable.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlSalida.ResumeLayout(false);
            this.pnlEncabezadoTabla.ResumeLayout(false);
            this.pnlEncabezadoTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlechas)).EndInit();
            this.pnlTablaDestinos.ResumeLayout(false);
            this.pnlTablaDestinos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblADonde;
        private System.Windows.Forms.MonthCalendar mtcSalida;
        private System.Windows.Forms.NumericUpDown nmpAdultos;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.ErrorProvider errDestino;
        private System.Windows.Forms.ErrorProvider errSalida;
        private System.Windows.Forms.PictureBox pcbFlechas;
        private System.Windows.Forms.Panel pnlPasajeros;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Panel pnlDesplegable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmpBebe;
        private System.Windows.Forms.NumericUpDown nmpMenores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbFlecha;
        private System.Windows.Forms.ErrorProvider errPasajeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEncabezadoTabla;
        private System.Windows.Forms.TableLayoutPanel tlpDestinos;
        private System.Windows.Forms.Panel pnlTablaDestinos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlFondoDesplegable;
        private System.Windows.Forms.Label lblTitulo;
    }
}

