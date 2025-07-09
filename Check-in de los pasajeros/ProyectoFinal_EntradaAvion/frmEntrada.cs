using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Muestra los asientos de las ocupados en el avión, tanto por los 
    /// pasajeros que aún no abordan como los que sí.
    /// </summary>
    public partial class frmEntrada : Form
    {
        //Lista de pasajeros del vuelo actual
        private List<Cliente> clientes;
        //Número del vuelo actual
        private int no_vuelo;

        /// <summary>
        /// Constructor del formulario. Recibe el número de vuelo y la lista de 
        /// pasajeros del vuelo.
        /// </summary>
        /// <param name="no_vuelo">Número del vuelo actual</param>
        public frmEntrada(int no_vuelo)
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            this.no_vuelo = no_vuelo;
            this.Text = "Vuelo No. " + no_vuelo.ToString();
        }

        /// <summary>
        /// Carga los componentes gráficos del formulario, tal como el grid, labels,
        /// botones, paneles, etc. Además los centra y modifica su posición relativa
        /// a otros componentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEntrada_Load(object sender, EventArgs e)
        {
            llenaAvion();
            marcaClientesAbordados();
            txtCodigo.Location = new Point(pnlEncabezado.Width - 10-txtCodigo.Width, (pnlEncabezado.Height-txtCodigo.Height)/2);
            lblEscanea.Location = new Point(txtCodigo.Location.X - lblEscanea.Width - 10, txtCodigo.Location.Y);
            gridAvion.Enabled = false;
            btnVerPasajeros.Image = Properties.Resources.icn_pasajero.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnRegresar.Image = Properties.Resources.icn_atras.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            pnlFondo.Location = new Point((this.ClientSize.Width-pnlFondo.Width)/2, 20);
        
        }

        /// <summary>
        /// Método encargado de darle el formato de cuadricula al grid, además de
        /// asignarle su nomenclatura, color de fondo, color de letras a los asientos.
        /// Si el asiento es verde, entonces el cliente está abordo. Si el asiento es 
        /// naranja indica que el pasajero está ausente. Si el asiento es color blanco, 
        /// esto indica que ese asiento está libre.
        /// </summary>
        private void llenaAvion()
        {
            string[] etiquetasFila = { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] etiquetaColumnas = { "A", "B", "C", "", "D", "E", "F" };
            int filas = 8, columnas = 7;
            

            gridAvion.Width = 55 * (columnas - 1) + 24;
            gridAvion.Height = 55 * filas + 4;
            gridAvion.Columns.Clear();
            gridAvion.Location = new Point((pnlFondo.Width - gridAvion.Width) / 2, 20 + pnlEncabezado.Height);
            for (int i = 0; i < columnas; i++)
            {
                gridAvion.Columns.Add(etiquetaColumnas[i], etiquetaColumnas[i]);
                if (i != 3) gridAvion.Columns[i].Width = 55;
                else gridAvion.Columns[i].Width = 20;
            }
            gridAvion.Rows.Clear();
            for (int i = 0; i < filas; i++)
            {
                gridAvion.Rows.Add();
                gridAvion.Rows[i].Height = 55;
            }


            //COLOREA LAS CELDAS DEL GRID, SEGÚN SI ES UN ASIENTO O PASILLO
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    DataGridViewCell celda = gridAvion.Rows[i].Cells[j];
                    if (j != 3)
                    {
                        celda.Style.BackColor = Color.FromArgb(230, 230, 230);
                        celda.Style.SelectionBackColor = Color.FromArgb(230, 230, 230);
                        celda.Style.SelectionForeColor = Color.Black;
                        celda.Value = etiquetaColumnas[j] + etiquetasFila[i];
                    }
                    else
                    {
                        celda.Value = "";
                        celda.Style.BackColor = Color.Gray;
                        celda.Style.SelectionBackColor = Color.Gray;
                        celda.Style.SelectionForeColor = Color.Gray;
                    }
                }
            }

        }
        /// <summary>
        /// Método que marca los asientos vendidos a un cliente con naranja si aún no ha
        /// abordado el avión y color verde claro si ya lo ha hecho. 
        /// </summary>
        private void marcaClientesAbordados()
        {
            clsDaoBoletos dao = new clsDaoBoletos();
            clientes = dao.ObtenerClientes(no_vuelo);
            foreach (Cliente cliente in clientes)
            {
                int shift = 0;
                if (cliente.asiento[0] > 'C')
                {
                    shift = 1;
                }
                DataGridViewCell celda = gridAvion.Rows[cliente.asiento[1] - '0' - 1].Cells[cliente.asiento[0] - 'A' + shift];

                if (!cliente.checked_in)
                {
                    celda.Style.BackColor = Color.FromArgb(255, 204, 128);
                    celda.Style.SelectionBackColor = Color.FromArgb(255, 204, 128);
                }
                else
                {
                    celda.Style.BackColor = Color.FromArgb(144, 238, 144);
                    celda.Style.SelectionBackColor = Color.FromArgb(144, 238, 144);
                }

            }

        }
        /// <summary>
        /// Botón que permite consultar los pasajeros que aún no abordan al 
        /// avión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerPasajeros_Click(object sender, EventArgs e)
        {
            frmPasajeros formulario = new frmPasajeros(clientes);
            formulario.ShowDialog();
        }

        /// <summary>
        /// Botón que permite regresar al formulario de selección de los vuelos, al
        /// cerrar el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// Evento asociado al Text Box del código de barra. Se activa automáticamente
        /// al escanear un boleto. Si el boleto no había sido escaneado con anterioridad,
        /// dará la bienvenida al pasajero y marcará su asiento con el color correspondiente.
        /// En caso contrario, notificará que el boleto pertence a una persona que ya había
        /// abordado el avión. También avisa si el código no pertenece al vuelo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodigo_KeyUp_1(object sender, KeyEventArgs e)
        {
            clsDaoBoletos dao = new clsDaoBoletos();
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txtCodigo.Text))
            {
                //Busca el código de barras en la lista de pasajeros.
                Cliente cliente = clientes.Find(c => c.id_boleto == txtCodigo.Text);
                //Si se encontró y aún no había hecho check-in, le da la bienvenida.
                if (cliente != null && !cliente.checked_in)
                {
                    if (dao.ActualizarCheck_In(cliente.id_boleto))
                    {
                        MessageBox.Show("Bienvenido/a " + cliente.getNombreCompleto(), "Lectura exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int shift = 0;
                        if (cliente.asiento[0] > 'C')
                        {
                            shift = 1;
                        }
                        cliente.checked_in = true;
                        DataGridViewCell celda = gridAvion.Rows[cliente.asiento[1] - '0' - 1].Cells[cliente.asiento[0] - 'A' + shift];
                        celda.Style.BackColor = Color.FromArgb(144, 238, 144);
                        celda.Style.SelectionBackColor = Color.FromArgb(144, 238, 144);
                    }
                }
                //Si ya había hecho check-in, se avisa que ya está abordo.
                else if (cliente != null && cliente.checked_in)
                {
                    MessageBox.Show("El boleto pertenece a alguien que ya está abordo.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Si el código no se encuentra, entonces se avisa que no pertenece al vuelo actual.
                else
                {
                    MessageBox.Show("Este código no pertenece al vuelo actual.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCodigo.Focus();
                txtCodigo.Text = "";
            }
        }
    }
}
