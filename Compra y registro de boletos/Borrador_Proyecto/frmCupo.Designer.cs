namespace Borrador_Proyecto
{
    partial class frmCupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAsientos = new System.Windows.Forms.DataGridView();
            this.Fila1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fila2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fila3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasillo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasillo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pnlLibre = new System.Windows.Forms.Panel();
            this.pnlOcupado = new System.Windows.Forms.Panel();
            this.lblLibre = new System.Windows.Forms.Label();
            this.lblOcupado = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.pnlSeleccionado = new System.Windows.Forms.Panel();
            this.flpPasajeros = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkAsientos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.pnlAsientosFondo = new System.Windows.Forms.Panel();
            this.pnlEncabezadoBoletos = new System.Windows.Forms.Panel();
            this.pcbBoletos = new System.Windows.Forms.PictureBox();
            this.lblBoletos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsientos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAsientosFondo.SuspendLayout();
            this.pnlEncabezadoBoletos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAsientos
            // 
            this.gridAsientos.AllowUserToAddRows = false;
            this.gridAsientos.AllowUserToDeleteRows = false;
            this.gridAsientos.AllowUserToResizeColumns = false;
            this.gridAsientos.AllowUserToResizeRows = false;
            this.gridAsientos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsientos.ColumnHeadersVisible = false;
            this.gridAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila1,
            this.fila2,
            this.fila3,
            this.pasillo1,
            this.pasillo2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAsientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridAsientos.Location = new System.Drawing.Point(12, 7);
            this.gridAsientos.MultiSelect = false;
            this.gridAsientos.Name = "gridAsientos";
            this.gridAsientos.ReadOnly = true;
            this.gridAsientos.RowHeadersVisible = false;
            this.gridAsientos.RowHeadersWidth = 51;
            this.gridAsientos.RowTemplate.Height = 24;
            this.gridAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridAsientos.Size = new System.Drawing.Size(481, 457);
            this.gridAsientos.TabIndex = 2;
            this.gridAsientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAsientos_CellClick);
            this.gridAsientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAsientos_CellDoubleClick);
            // 
            // Fila1
            // 
            this.Fila1.HeaderText = "1";
            this.Fila1.MinimumWidth = 6;
            this.Fila1.Name = "Fila1";
            this.Fila1.ReadOnly = true;
            this.Fila1.Width = 43;
            // 
            // fila2
            // 
            this.fila2.HeaderText = "2";
            this.fila2.MinimumWidth = 6;
            this.fila2.Name = "fila2";
            this.fila2.ReadOnly = true;
            this.fila2.Width = 43;
            // 
            // fila3
            // 
            this.fila3.HeaderText = "3";
            this.fila3.MinimumWidth = 6;
            this.fila3.Name = "fila3";
            this.fila3.ReadOnly = true;
            this.fila3.Width = 43;
            // 
            // pasillo1
            // 
            this.pasillo1.HeaderText = "";
            this.pasillo1.MinimumWidth = 6;
            this.pasillo1.Name = "pasillo1";
            this.pasillo1.ReadOnly = true;
            this.pasillo1.Width = 23;
            // 
            // pasillo2
            // 
            this.pasillo2.HeaderText = "";
            this.pasillo2.MinimumWidth = 6;
            this.pasillo2.Name = "pasillo2";
            this.pasillo2.ReadOnly = true;
            this.pasillo2.Width = 23;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(118, 601);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(197, 61);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(3, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(60, 50);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlLibre
            // 
            this.pnlLibre.BackColor = System.Drawing.Color.LightGreen;
            this.pnlLibre.Location = new System.Drawing.Point(62, 481);
            this.pnlLibre.Name = "pnlLibre";
            this.pnlLibre.Size = new System.Drawing.Size(100, 39);
            this.pnlLibre.TabIndex = 5;
            // 
            // pnlOcupado
            // 
            this.pnlOcupado.BackColor = System.Drawing.Color.IndianRed;
            this.pnlOcupado.Location = new System.Drawing.Point(204, 481);
            this.pnlOcupado.Name = "pnlOcupado";
            this.pnlOcupado.Size = new System.Drawing.Size(100, 39);
            this.pnlOcupado.TabIndex = 6;
            // 
            // lblLibre
            // 
            this.lblLibre.AutoSize = true;
            this.lblLibre.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibre.Location = new System.Drawing.Point(91, 527);
            this.lblLibre.Name = "lblLibre";
            this.lblLibre.Size = new System.Drawing.Size(46, 22);
            this.lblLibre.TabIndex = 7;
            this.lblLibre.Text = "Libre";
            // 
            // lblOcupado
            // 
            this.lblOcupado.AutoSize = true;
            this.lblOcupado.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupado.Location = new System.Drawing.Point(221, 526);
            this.lblOcupado.Name = "lblOcupado";
            this.lblOcupado.Size = new System.Drawing.Size(73, 22);
            this.lblOcupado.TabIndex = 8;
            this.lblOcupado.Text = "Ocupado";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.Location = new System.Drawing.Point(343, 524);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(103, 22);
            this.lblSeleccionado.TabIndex = 10;
            this.lblSeleccionado.Text = "Seleccionado";
            // 
            // pnlSeleccionado
            // 
            this.pnlSeleccionado.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlSeleccionado.Location = new System.Drawing.Point(342, 481);
            this.pnlSeleccionado.Name = "pnlSeleccionado";
            this.pnlSeleccionado.Size = new System.Drawing.Size(100, 39);
            this.pnlSeleccionado.TabIndex = 9;
            // 
            // flpPasajeros
            // 
            this.flpPasajeros.AutoScroll = true;
            this.flpPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.flpPasajeros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPasajeros.Location = new System.Drawing.Point(17, 158);
            this.flpPasajeros.Name = "flpPasajeros";
            this.flpPasajeros.Size = new System.Drawing.Size(360, 300);
            this.flpPasajeros.TabIndex = 12;
            this.flpPasajeros.WrapContents = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(226, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 28);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // chkAsientos
            // 
            this.chkAsientos.AutoSize = true;
            this.chkAsientos.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsientos.Location = new System.Drawing.Point(72, 566);
            this.chkAsientos.Name = "chkAsientos";
            this.chkAsientos.Size = new System.Drawing.Size(299, 26);
            this.chkAsientos.TabIndex = 14;
            this.chkAsientos.Text = "Prefiero no elegir asientos";
            this.chkAsientos.UseVisualStyleBackColor = true;
            this.chkAsientos.CheckedChanged += new System.EventHandler(this.chkAsientos_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.lblTotalAPagar);
            this.panel1.Controls.Add(this.pnlAsientosFondo);
            this.panel1.Controls.Add(this.pnlEncabezadoBoletos);
            this.panel1.Controls.Add(this.chkAsientos);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.flpPasajeros);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnContinuar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 674);
            this.panel1.TabIndex = 15;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.BackColor = System.Drawing.Color.White;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(21, 504);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(86, 28);
            this.lblTotalAPagar.TabIndex = 17;
            this.lblTotalAPagar.Text = "Total:";
            // 
            // pnlAsientosFondo
            // 
            this.pnlAsientosFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.pnlAsientosFondo.Controls.Add(this.lblSeleccionado);
            this.pnlAsientosFondo.Controls.Add(this.pnlSeleccionado);
            this.pnlAsientosFondo.Controls.Add(this.lblOcupado);
            this.pnlAsientosFondo.Controls.Add(this.lblLibre);
            this.pnlAsientosFondo.Controls.Add(this.pnlOcupado);
            this.pnlAsientosFondo.Controls.Add(this.pnlLibre);
            this.pnlAsientosFondo.Controls.Add(this.gridAsientos);
            this.pnlAsientosFondo.Location = new System.Drawing.Point(641, 59);
            this.pnlAsientosFondo.Name = "pnlAsientosFondo";
            this.pnlAsientosFondo.Size = new System.Drawing.Size(506, 603);
            this.pnlAsientosFondo.TabIndex = 11;
            // 
            // pnlEncabezadoBoletos
            // 
            this.pnlEncabezadoBoletos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(147)))));
            this.pnlEncabezadoBoletos.Controls.Add(this.pcbBoletos);
            this.pnlEncabezadoBoletos.Controls.Add(this.lblBoletos);
            this.pnlEncabezadoBoletos.Location = new System.Drawing.Point(17, 93);
            this.pnlEncabezadoBoletos.Name = "pnlEncabezadoBoletos";
            this.pnlEncabezadoBoletos.Size = new System.Drawing.Size(359, 65);
            this.pnlEncabezadoBoletos.TabIndex = 16;
            // 
            // pcbBoletos
            // 
            this.pcbBoletos.Image = global::Borrador_Proyecto.Properties.Resources.icn_boleto;
            this.pcbBoletos.Location = new System.Drawing.Point(234, 3);
            this.pcbBoletos.Name = "pcbBoletos";
            this.pcbBoletos.Size = new System.Drawing.Size(61, 59);
            this.pcbBoletos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBoletos.TabIndex = 15;
            this.pcbBoletos.TabStop = false;
            // 
            // lblBoletos
            // 
            this.lblBoletos.AutoSize = true;
            this.lblBoletos.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletos.ForeColor = System.Drawing.Color.White;
            this.lblBoletos.Location = new System.Drawing.Point(95, 16);
            this.lblBoletos.Name = "lblBoletos";
            this.lblBoletos.Size = new System.Drawing.Size(133, 34);
            this.lblBoletos.TabIndex = 14;
            this.lblBoletos.Text = "Boletos";
            // 
            // frmCupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(98)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1178, 674);
            this.Controls.Add(this.panel1);
            this.Name = "frmCupo";
            this.Text = "Selección de Asientos";
            this.Load += new System.EventHandler(this.frmCupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAsientos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAsientosFondo.ResumeLayout(false);
            this.pnlAsientosFondo.PerformLayout();
            this.pnlEncabezadoBoletos.ResumeLayout(false);
            this.pnlEncabezadoBoletos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBoletos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridAsientos;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlLibre;
        private System.Windows.Forms.Panel pnlOcupado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fila2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fila3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasillo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasillo2;
        private System.Windows.Forms.Label lblLibre;
        private System.Windows.Forms.Label lblOcupado;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Panel pnlSeleccionado;
        private System.Windows.Forms.FlowLayoutPanel flpPasajeros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkAsientos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAsientosFondo;
        private System.Windows.Forms.Panel pnlEncabezadoBoletos;
        private System.Windows.Forms.Label lblBoletos;
        private System.Windows.Forms.PictureBox pcbBoletos;
        private System.Windows.Forms.Label lblTotalAPagar;
    }
}