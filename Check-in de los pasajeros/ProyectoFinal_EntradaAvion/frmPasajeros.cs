using interfacesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Muestra en una tabla los pasajeros que aun no han abordado
    /// al avión.
    /// </summary>
    public partial class frmPasajeros : Form
    {
        //Lista de clientes/pasajeros que van abordo del vuelo
        private List<Cliente> clientes; 
        
        /// <summary>
        /// Constructor del formulario. Recibe una lista de objetos de tipo cliente.
        /// </summary>
        /// <param name="clientes">Lista de clientes/pasajeros de un vuelo</param>
        public frmPasajeros(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        /// <summary>
        /// Método que le da formato al control Table Layout Panel. Fuerza a que este
        /// solo muestre 2 columnas y 2 filas con el componente personalizado "interfaz
        /// Pasajero". También agrega el evento click a los botones del control personalizado.
        /// </summary>
        /// <param name="clientes"></param>
        private void mostrarTabla(List<Cliente> clientes)
        {
            clsDaoBoletos dao = new clsDaoBoletos();
            //Se da formato al Table Layout Panel, asignándole su ancho y largo.
            int tamanoFila = new interfazPasajero().Height;
            int tamanoColumna = new interfazPasajero().Width;
            pnlEncabezado.Location = new Point((this.ClientSize.Width - pnlEncabezado.Width) / 2, 40);

            pnlPasajeros.Width = tamanoColumna * 2 + 30;
            
            tlpPasajeros.Controls.Clear();
            tlpPasajeros.AutoScroll = true;
            tlpPasajeros.Location = new Point(0, 0);

            tlpPasajeros.RowCount = 0;
            tlpPasajeros.ColumnCount = 0;
            pnlPasajeros.Height = tamanoFila * 2;
            //Número de columnas que mostrará
            int columnas = 2;
            //Se añaden las columnas
            for (int i = 0; i < columnas; i++)
            {
                tlpPasajeros.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tlpPasajeros.ColumnCount++;
            }
            //Contabilización de las filas
            int fila = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                interfazPasajero disPasajero = new interfazPasajero();
                //Se alcanza el límite de columas
                if (i % columnas == 0)
                {
                    // Agrega nueva fila
                    tlpPasajeros.RowStyles.Add(new RowStyle(SizeType.Absolute, tamanoFila));
                    tlpPasajeros.RowCount++;
                    fila++;
                }

                //Paso de datos del vuelo
                Cliente currCliente = clientes[i];

                disPasajero.Nombre.Text = currCliente.getNombreCompleto();
                disPasajero.Asiento.Text = "Asiento: " + currCliente.asiento; 
                
                int currCol = i % columnas;
                int currRow = i / columnas;
                //Se agrega el control al Table Layout Panel
                tlpPasajeros.Controls.Add(disPasajero, currCol, currRow);
            }
            //Centrado de componentes
            pnlEncabezado.Width = pnlPasajeros.Width;
            pnlPasajeros.Location = new Point((this.ClientSize.Width - pnlPasajeros.Width) / 2, pnlEncabezado.Location.Y + pnlEncabezado.Height);
            pnlEncabezado.Location = new Point(pnlPasajeros.Location.X, pnlEncabezado.Location.Y);
        }

        /// <summary>
        /// Carga los elementos gráficos del formulario y separa los clientes en: 
        ///     --> Clientes que aún no han abordado el avión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPasajeros_Load(object sender, EventArgs e)
        {
            List <Cliente> abordo = new List<Cliente>();
            List<Cliente> ausentes = new List<Cliente>();
            btnRegresar.Image = Properties.Resources.icn_atras.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            foreach (Cliente pasajero in clientes)
            {
                if(!pasajero.checked_in) ausentes.Add(pasajero);
            }
            mostrarTabla(ausentes); 
        }

        /// <summary>
        /// Botón que permite regresar al formulario de display del vuelo, al
        /// cerrar el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
