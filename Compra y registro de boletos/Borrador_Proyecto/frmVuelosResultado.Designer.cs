namespace Borrador_Proyecto
{
    partial class frmVuelosResultado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridVuelos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pcbViaje = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbViaje)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridVuelos
            // 
            this.gridVuelos.AllowUserToAddRows = false;
            this.gridVuelos.AllowUserToDeleteRows = false;
            this.gridVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridVuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridVuelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVuelos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridVuelos.Location = new System.Drawing.Point(50, 163);
            this.gridVuelos.Name = "gridVuelos";
            this.gridVuelos.ReadOnly = true;
            this.gridVuelos.RowHeadersWidth = 51;
            this.gridVuelos.RowTemplate.Height = 24;
            this.gridVuelos.Size = new System.Drawing.Size(1054, 453);
            this.gridVuelos.TabIndex = 0;
            this.gridVuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVuelos_CellClick);
            this.gridVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVuelos_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(83)))));
            this.lblTitulo.Location = new System.Drawing.Point(329, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 36);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Viajes disponibles";
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(60, 50);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pcbViaje
            // 
            this.pcbViaje.Image = global::Borrador_Proyecto.Properties.Resources.icnVuelo;
            this.pcbViaje.Location = new System.Drawing.Point(670, 3);
            this.pcbViaje.Name = "pcbViaje";
            this.pcbViaje.Size = new System.Drawing.Size(94, 84);
            this.pcbViaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbViaje.TabIndex = 3;
            this.pcbViaje.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(183)))), ((int)(((byte)(175)))));
            this.pnlTitulo.Controls.Add(this.pcbViaje);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(50, 74);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1053, 89);
            this.pnlTitulo.TabIndex = 5;
            // 
            // frmVuelosResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1157, 641);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridVuelos);
            this.Name = "frmVuelosResultado";
            this.Text = "Resultado de los Vuelos";
            this.Load += new System.EventHandler(this.frmVuelosResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbViaje)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVuelos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbViaje;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlTitulo;
    }
}