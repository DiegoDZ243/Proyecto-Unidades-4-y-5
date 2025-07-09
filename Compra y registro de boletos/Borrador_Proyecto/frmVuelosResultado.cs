using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Clase en la que selecciona el vuelo que quiere el cliente
    /// </summary>    
    public partial class frmVuelosResultado : Form
    {
        //Fila de la celda seleccionada y el total de pasajeros que volarán
        private int x,totalPasajeros; 

        //Arreglo con las categorías de pasajeros que abordarán
        private int[] pasajeros; 

        //Destino actual
        private Destino destino;

        //Lista de vuelos disponibles para el destino actual
        private List<Vuelo> listaVuelos; 

        /// <summary>
        /// Constructor del formulario actual que inicializa atributos que se utilizarán
        /// por los métodos del mismo. 
        /// </summary>
        /// <param name="vuelos">Lista de vuelos disponibles para el destino seleccionado</param>
        /// <param name="destino">Destino actual seleccionado</param>
        /// <param name="pasajeros">Arreglo con las categorías de los pasajeros que abordarán el vuelo</param>
        /// <param name="encontrado">Si se encontraron vuelos para la fecha seleccionada o no</param>
        public frmVuelosResultado(List<Vuelo> vuelos, Destino destino, int[] pasajeros, bool encontrado)
        {
            InitializeComponent();
            this.destino = destino;
            if (encontrado)
            {
                formatoGrid(vuelos);
            }
            else 
            {
                formatoGridExtendido(vuelos); 
            }
            listaVuelos = vuelos; 
            this.pasajeros = pasajeros;
            totalPasajeros = pasajeros[0] + pasajeros[1] + pasajeros[2]; 
        }
        
        /// <summary>
        /// Carga los componentes gráficos del formulario:
        /// DataGrid, botones, paneles, labels. También modifica su posición
        /// para centrarlos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVuelosResultado_Load(object sender, EventArgs e)
        {
            pnlTitulo.Width = gridVuelos.Width;
            lblTitulo.Location = new Point((this.ClientSize.Width - lblTitulo.Width) / 2 , lblTitulo.Location.Y);
            pcbViaje.Location = new Point(lblTitulo.Location.X + lblTitulo.Width + 10, pcbViaje.Location.Y);
            btnAtras.Image = Properties.Resources.icn_atras.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            lblTitulo.Location=new Point((pnlTitulo.Width-lblTitulo.Width)/2, (pnlTitulo.Height-lblTitulo.Height)/2);
            pcbViaje.Location = new Point(lblTitulo.Location.X+lblTitulo.Width+10, pcbViaje.Location.Y);
        }

        /// <summary>
        /// Método que carga el gridVuelos con los datos: 
        /// fecha, hora de salida, hora de llegada, embarque, precio y cupo
        /// para los vuelos que tienen un mismo destino.
        /// 
        /// Este método solo se llama cuando en el formulario frmConsultaViaje no hay vuelos para
        /// el destino seleccionado en la fecha seleccionada.
        /// </summary>
        /// <param name="vuelos">Lista de vuelos disponibles</param>
        private void formatoGridExtendido(List<Vuelo> vuelos)
        {
            this.Width += 120; 
            gridVuelos.Rows.Clear();
            gridVuelos.AutoGenerateColumns = false;
            gridVuelos.Columns.Add("fecha", "Fecha de Salida"); 
            gridVuelos.Columns.Add("hora_salida", "Hora de salida");
            gridVuelos.Columns.Add("hora_llegada", "Hora de llegada");
            gridVuelos.Columns.Add("embarque", "Embarque");
            gridVuelos.Columns.Add("precio", "Precio");
            gridVuelos.Columns.Add("cupo", "Asientos disponibles");
            gridVuelos.Columns.Add("id_vuelo", "");

            gridVuelos.Columns["id_vuelo"].Visible = false;
            //Se cargan los datos de cada vuelo al grid
            foreach (Vuelo x in vuelos)
            {
                DateTime salida = DateTime.Today.Add(x.hora_salida);
                DateTime llegada = salida.Add(destino.duracion);
                gridVuelos.Rows.Add(
                    x.fecha.ToString("dd/MM/yyyy"),
                    salida.ToString("hh:mm tt"),
                    llegada.ToString("hh:mm tt"),
                    x.embarque,
                    $"${x.precio:N2}",
                    x.cupo.ToString() + " asientos",
                    x.id.ToString()
                    ); 
            }
            gridVuelos.Width+=gridVuelos.Columns["fecha"].Width+30; 
        }

        /// <summary>
        /// Método que carga el gridVuelos con los datos: 
        /// hora de salida, hora de llegada, embarque, precio y cupo
        /// para los vuelos que van a un mismo destino y salen en una
        /// fecha determinada, elegida por el usuario.
        /// </summary>
        /// <param name="vuelos">Lista de vuelos disponibles</param>
        private void formatoGrid(List<Vuelo> vuelos)
        {
            gridVuelos.Rows.Clear(); 
            gridVuelos.AutoGenerateColumns = false;
            gridVuelos.Columns.Add("hora_salida", "Hora de salida");
            gridVuelos.Columns.Add("hora_llegada", "Hora de llegada");
            gridVuelos.Columns.Add("embarque", "Embarque");
            gridVuelos.Columns.Add("precio", "Precio");
            gridVuelos.Columns.Add("cupo", "Asientos disponibles");
            gridVuelos.Columns.Add("id_vuelo", "");

            gridVuelos.Columns["id_vuelo"].Visible = false; 
            foreach(Vuelo x in vuelos) 
            {
                DateTime salida=DateTime.Today.Add(x.hora_salida);
                DateTime llegada = salida.Add(destino.duracion);
                gridVuelos.Rows.Add(
                   salida.ToString("hh:mm tt"),
                    llegada.ToString("hh:mm tt"),
                    x.embarque,
                    $"${x.precio:N2}",
                    x.cupo.ToString() + " asientos",
                    x.id.ToString()
                    );  
            }

        }

        /// <summary>
        /// Evento que se desencadena al hacer clic en una de las celdas del grid.
        /// Permite obtener el index de la fila a la que pertenece la celda seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                x = e.RowIndex;
            }
        }

        /// <summary>
        /// Evento que se produce al dar clic al botón atrás. 
        /// Este solo cierra el formulario actual para regresar al
        /// anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// Evento que se desencadena al dar doble clic en una celda o fila del grid.
        /// Manda datos importantes sobre el vuelo al constructor de frmCupo, dónde
        /// se elegirán los asientos de los pasajeros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCupo formulario = new frmCupo(listaVuelos[x], (int[])pasajeros.Clone());
            this.Hide(); 
            formulario.ShowDialog();
            //Si se finalizó la venta de boletos, se cierra este formulario
            if (formulario.getFinalizado())
            {
                formulario.Dispose();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    
        
    }
}
