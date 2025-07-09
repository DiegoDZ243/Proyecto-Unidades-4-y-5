using interfacesPersonalizadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Despliega una tabla que permite elegir para que vuelo se 
    /// desea hacer el check-in
    /// </summary>
    public partial class frmTablaVuelos : Form
    {
        //Lista que almacena los vuelos disponibles
        private List<Vuelo> vuelosDisponibles; 
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public frmTablaVuelos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que carga los componentes gráficos del formulario, en este caso, 
        /// carga exclusivamente el control Table Layout Panel con los vuelos disponibles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTablaVuelos_Load(object sender, EventArgs e)
        {
            mostrarTabla(); 
        }

        /// <summary>
        /// Método que le da formato al control Table Layout Panel. Fuerza a que este
        /// solo muestre 2 columnas y 2 filas con el componente personalizado "interfaz
        /// vuelo". También agrega el evento click a los botones del control personalizado.
        /// </summary>
        private void mostrarTabla()
        {
            clsDaoBoletos dao = new clsDaoBoletos();
            int tamanoFila = new interfazVuelo().Height;
            int tamanoColumna = new interfazVuelo().Width;
            pnlEncabezado.Location = new Point((this.ClientSize.Width - pnlEncabezado.Width) / 2, 40); 
            
            pnlVuelos.Width = tamanoColumna * 2 + 30;

            tlpVuelos.Controls.Clear();
            tlpVuelos.AutoScroll= true;
            tlpVuelos.Location = new Point(0, 0);

            tlpVuelos.RowCount = 0;
            tlpVuelos.ColumnCount = 0;
            pnlVuelos.Height = tamanoFila * 2 + 10;
            int columnas = 2;
            
            for (int i = 0; i < columnas; i++)
            {
                tlpVuelos.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tlpVuelos.ColumnCount++;
            }
            
            vuelosDisponibles = dao.ObtenerVuelos();
            int fila = 0;
            for (int i = 0; i < vuelosDisponibles.Count; i++)
            {
                interfazVuelo disVuelo = new interfazVuelo();
                if (i % columnas == 0)
                {
                    // Agrega nueva fila
                    tlpVuelos.RowStyles.Add(new RowStyle(SizeType.Absolute, tamanoFila));
                    tlpVuelos.RowCount++;
                    fila++;
                }

                Vuelo currVuelo= vuelosDisponibles[i];



                disVuelo.Destino.Text = "Destino: "+currVuelo.ciudad;
                disVuelo.Fecha.Text = "Fecha: "+currVuelo.fecha.ToString("dd/MM/yyyy"); 
                disVuelo.NumVuelo.Text="No. Vuelo: "+currVuelo.id.ToString();
                disVuelo.Boton.Click += (sender, e) => viajar_Click(sender, e, currVuelo);
                int currCol = i % columnas;
                int currRow = i / columnas;
                tlpVuelos.Controls.Add(disVuelo, currCol, currRow);
            }
            pnlEncabezado.Width = pnlVuelos.Width;
            pnlVuelos.Location = new Point((this.ClientSize.Width-pnlVuelos.Width)/2, pnlEncabezado.Location.Y+pnlEncabezado.Height);
            pnlEncabezado.Location =new Point(pnlVuelos.Location.X,pnlEncabezado.Location.Y); 
        }

        /// <summary>
        /// Evento clic de los controles dentro del Table Layout Panel. Al hacer clic, se
        /// abre el formulario con el arreglo de los asientos dentro del vuelo seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="vuelo"></param>
        private void viajar_Click(object sender, EventArgs e, Vuelo vuelo)
        {
            frmEntrada formulario = new frmEntrada(vuelo.id);
            formulario.ShowDialog(); 
        }
    }
}
