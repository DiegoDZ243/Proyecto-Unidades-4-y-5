namespace ProyectoFinal_EntradaAvion
{
    partial class frmEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridAvion = new System.Windows.Forms.DataGridView();
            this.btnVerPasajeros = new System.Windows.Forms.Button();
            this.lblEscanea = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAvion
            // 
            this.gridAvion.AllowUserToAddRows = false;
            this.gridAvion.AllowUserToDeleteRows = false;
            this.gridAvion.AllowUserToResizeColumns = false;
            this.gridAvion.AllowUserToResizeRows = false;
            this.gridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvion.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAvion.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridAvion.Location = new System.Drawing.Point(16, 90);
            this.gridAvion.MultiSelect = false;
            this.gridAvion.Name = "gridAvion";
            this.gridAvion.ReadOnly = true;
            this.gridAvion.RowHeadersVisible = false;
            this.gridAvion.RowHeadersWidth = 51;
            this.gridAvion.RowTemplate.Height = 24;
            this.gridAvion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridAvion.Size = new System.Drawing.Size(552, 552);
            this.gridAvion.TabIndex = 2;
            // 
            // btnVerPasajeros
            // 
            this.btnVerPasajeros.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPasajeros.Location = new System.Drawing.Point(12, 748);
            this.btnVerPasajeros.Name = "btnVerPasajeros";
            this.btnVerPasajeros.Size = new System.Drawing.Size(254, 68);
            this.btnVerPasajeros.TabIndex = 1;
            this.btnVerPasajeros.Text = "Ver pasajeros";
            this.btnVerPasajeros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerPasajeros.UseVisualStyleBackColor = true;
            this.btnVerPasajeros.Click += new System.EventHandler(this.btnVerPasajeros_Click);
            // 
            // lblEscanea
            // 
            this.lblEscanea.AutoSize = true;
            this.lblEscanea.BackColor = System.Drawing.Color.Transparent;
            this.lblEscanea.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscanea.ForeColor = System.Drawing.Color.Black;
            this.lblEscanea.Location = new System.Drawing.Point(26, 26);
            this.lblEscanea.Name = "lblEscanea";
            this.lblEscanea.Size = new System.Drawing.Size(199, 27);
            this.lblEscanea.TabIndex = 3;
            this.lblEscanea.Text = "Escanea Boleto: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(237, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(469, 34);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(9, 7);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 50);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.pnlEncabezado.Controls.Add(this.lblEscanea);
            this.pnlEncabezado.Controls.Add(this.txtCodigo);
            this.pnlEncabezado.Location = new System.Drawing.Point(16, 11);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(753, 79);
            this.pnlEncabezado.TabIndex = 10;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pnlFondo.Controls.Add(this.pnlEncabezado);
            this.pnlFondo.Controls.Add(this.gridAvion);
            this.pnlFondo.Location = new System.Drawing.Point(160, 33);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(786, 655);
            this.pnlFondo.TabIndex = 11;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1182, 828);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVerPasajeros);
            this.Name = "frmEntrada";
            this.Text = "frmEntradacs";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAvion;
        private System.Windows.Forms.Button btnVerPasajeros;
        private System.Windows.Forms.Label lblEscanea;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlFondo;
    }
}