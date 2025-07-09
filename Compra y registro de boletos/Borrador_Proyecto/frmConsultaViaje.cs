using MisControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Menú principal del programa. Aquí se elige la fecha del vuelo, 
    /// número de pasajeros y el destino.
    /// </summary>
    public partial class frmConsultaViaje : Form
    {
        //Lista de los destinos disponibles en el aeropuerto
        private List<Destino> destinos;
        //Estado del control desplegado
        private bool desplegado=false;
        //Arreglo con la cantidad de pasajeros que volarán
        private int[] pasajerosActuales; 
        
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public frmConsultaViaje()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento que inicializa los componentes gráficos del form. Genera y da 
        /// formato al control Table Layout Panel para que solo muestre dos filas
        /// y dos columnas con los destinos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsultaViaje_Load(object sender, EventArgs e)
        {
            lblResumen.Text = "";
            clsDaoDestinos dao = new clsDaoDestinos();
            Image imgBuscar = Properties.Resources.icnBuscar.GetThumbnailImage(50, 50, null, IntPtr.Zero);

            destinos = dao.ObtenerDestinos();
            
            muestraDestinosEnTabla(); 

            //Centrado de los componentes de formulario
            pnlPasajeros.Location = new Point((pnlFondoDesplegable.Width - pnlPasajeros.Width) / 2-10, pnlPasajeros.Location.Y);
            pnlDesplegable.Location = new Point(pnlPasajeros.Location.X, pnlDesplegable.Location.Y); 
            mtcSalida.Location = new Point((pnlSalida.Width-mtcSalida.Width)/2,mtcSalida.Location.Y);
            lblTitulo.Location = new Point((ClientSize.Width - lblTitulo.Width) / 2, 20);
            pnlFondoDesplegable.Location = new Point((panel1.Width - pnlFondoDesplegable.Width) / 2, pnlFondoDesplegable.Location.Y);
            pnlSalida.Location = new Point((panel1.Width - pnlSalida.Width) / 2, pnlSalida.Location.Y);
            panel4.Location = new Point(pnlSalida.Location.X, panel4.Location.Y); 
            panel5.Location = new Point(pnlFondoDesplegable.Location.X,panel5.Location.Y);
            
        }

        /// <summary>
        /// Método que da formato al control Table Layout Panel, agregando dinámicamente
        /// controles definidos por el usuario ("interfazDestino"). También un asigna evento a los botones
        /// de este para que permitan mostrar el formulario donde se seleccionará el vuelo que 
        /// quiera el usuario.
        /// </summary>
        private void muestraDestinosEnTabla()
        {
            //Se modifica el ancho y largo del Table Layout Panel en función de las dimen-
            //siones del control "interfazDestino" y se da formato a los paneles asociados.
            int tamanoFila = new interfazDestino().Height;
            int tamanoColumna = new interfazDestino().Width;
            pnlEncabezadoTabla.Width = pnlTablaDestinos.Width = tamanoColumna * 2 + 25;
            lblADonde.Location = new Point((pnlEncabezadoTabla.Width - lblADonde.Width)/2, 10);

            pnlTablaDestinos.Location = new Point(this.ClientSize.Width - pnlTablaDestinos.Width - 10, 150); 
            pnlEncabezadoTabla.Location = new Point(pnlTablaDestinos.Location.X ,pnlTablaDestinos.Location.Y-pnlEncabezadoTabla.Height); 
            
            
            tlpDestinos.Controls.Clear();
            tlpDestinos.AutoScroll = true;
            tlpDestinos.Location = new Point(0, 0);
            pnlTablaDestinos.Height = tamanoFila * 2 + 10; 
            
            tlpDestinos.RowCount = 0;
            tlpDestinos.ColumnCount = 0;

            //Número de columnas que tendrá la tabla
            int columnas = 2; 
            for(int i = 0; i < columnas; i++)
            {
                tlpDestinos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute,tamanoColumna));
                tlpDestinos.ColumnCount++;
            }
            //Se añade el número de filas correspondiente
            int fila = 0;
            for (int i = 0; i < destinos.Count; i++)
            {
                interfazDestino disDestino = new interfazDestino();
                //Si se excede el número de columnas, se agrega una nueva fila.
                if (i % columnas == 0)
                {
                    // Agrega nueva fila
                    tlpDestinos.RowStyles.Add(new RowStyle(SizeType.Absolute,tamanoFila));
                    tlpDestinos.RowCount++;
                    fila++;
                }

                Destino currDestino = destinos[i];
                
                
                //Se cargan los datos del destino
                disDestino.Nombre.Text = currDestino.nombre;
                disDestino.Imagen.Image = Image.FromFile(currDestino.direccionImagen);
                disDestino.Boton.Click += (sender, e) => viajar_Click(sender, e, currDestino);
                int currCol = i % columnas;
                int currRow = i / columnas;
                //Se agrega al Table Layout Panel
                tlpDestinos.Controls.Add(disDestino, currCol, currRow);
            }

        }

        /// <summary>
        /// Evento de clic asociado a los controles definidos por el usuario
        /// "interfazDestino". Permite avanzar al formulario donde se seleccionará
        /// el vuelo al destino seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="destino">Destino actual seleccionado</param>
        private void viajar_Click(object sender, EventArgs e, Destino destino)
        {
            int totalPasajeros = 0;
            clsDaoDestinos dao = new clsDaoDestinos();

            DateTime fecha = mtcSalida.SelectionStart.Date;

            //Contabiliza cada categoría de pasajeros
            int adultos = int.Parse(nmpAdultos.Value.ToString());
            int menores = int.Parse(nmpMenores.Value.ToString());
            int bebes = int.Parse(nmpBebe.Value.ToString());
            
            //Los asigna a un arreglo
            int[] pasajeros = { adultos, menores, bebes };
            pasajerosActuales = pasajeros;
            totalPasajeros = adultos + menores + bebes;

            if (!validaBuscar(totalPasajeros)) return;

            //Crea una lista con los vuelos disponibles para el destino y fecha seleccionados
            List<Vuelo> consulta = dao.ConsultaVuelos(destino.id, fecha, totalPasajeros);

            //Si encuentra, al menos, un vuelo, lo manda al constructor del siguiente formulario
            if (consulta.Count > 0)
            {
                frmVuelosResultado form = new frmVuelosResultado(consulta, destino, pasajeros, true);
                form.ShowDialog();
            }
            //En caso contrario, se notifica que no existen vuelos
            else
            {
                consulta=dao.ConsultaVuelosPorDestino(destino.id,fecha, totalPasajeros);
                if (consulta.Count > 0)
                {
                    MessageBox.Show("No hay vuelos en la fecha indicada. Se mostrarán " +
                        "vuelos al destino seleccionado con diferentes fechas.");
                    frmVuelosResultado form = new frmVuelosResultado(consulta, destino, pasajeros, false);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Parece que no hay vuelos al destino indicado en fechas cercanas.");
                }
            }
        }

        /// <summary>
        /// Evento que despliega o retrae el control generado con ayuda de dos 
        /// paneles, el cual permite elegir el numero de pasajeros que tomarán
        /// el vuelo. Si está desplegado, se retrae; si está retraído, se despliega.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPasajeros_Click(object sender, EventArgs e)
        {
            if (!desplegado)
            {
                pcbFlecha.Image = Properties.Resources.icnFlechaDesplegableArriba;
                pnlDesplegable.Visible = true;
                desplegado = true;
            }
            else
            {
                pcbFlecha.Image = Properties.Resources.icnFlechaDesplegableAbajo;
                pnlDesplegable.Visible = false;
                desplegado = false;
                //Modifica la Label con el resumen de los pasajeros que abordará el vuelo
                string temp = "";
                if (nmpAdultos.Value == 1)
                {
                    temp += "1 adulto";
                }
                else if ((nmpAdultos.Value > 1)) 
                {
                    temp += nmpAdultos.Value + " adultos";
                }

                if (nmpMenores.Value == 1)
                {
                    if (temp.Length > 0) temp += ", ";
                    temp += "1 menor";
                }
                else if (nmpMenores.Value > 1) {
                    if (temp.Length > 0) temp += ", ";
                    temp +=  nmpMenores.Value + " menores";
                }


                if (nmpBebe.Value == 1)
                {
                    if (temp.Length > 0) temp += ", "; 
                    temp += "1 bebé";
                }
                else if (nmpBebe.Value > 1)
                {
                    if (temp.Length > 0) temp += ", ";
                    temp += nmpBebe.Value + " bebés";
                }
                //Se asigna el nuevo resumen
                lblResumen.Text = temp;
            }

        }

        /// <summary>
        /// Manda llamar el método de desplegar al hacer clic en la imagen de la flecha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pcbFlecha_Click(object sender, EventArgs e)
        {
            pnlPasajeros_Click(sender, e);
        }

        /// <summary>
        /// Manda llamar el método de desplegar al hacer clic en consultar viaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsultaViaje_Click(object sender, EventArgs e)
        {
            if (desplegado) pnlPasajeros_Click(sender, e);
        }

        #region VALIDACIONES
        /// <summary>
        /// Valida que se escoja al menos un pasajero
        /// </summary>
        /// <param name="total">Total de pasajeros elegidos</param>
        /// <returns>True: Se cumple con la validación</returns>
        private bool validaPasajeros(int total)
        {
            if (total == 0)
            {
                errPasajeros.SetError(pnlPasajeros, "Elija al menos un pasajero");
                return false; 
            }else if (pasajerosActuales[0]==0)
            {
                errPasajeros.SetError(pnlPasajeros, "Debe viajar al menos un adulto");
                return false;
            }
            errPasajeros.Clear();
            return true; 
        }

        /// <summary>
        /// Ejecuta todas las validaciones antes de seguir con el
        /// la elección del vuelo.
        /// </summary>
        /// <param name="total">Total de pasajeros elegidos</param>
        /// <returns>True: Se cumple con la validación; False: Si no las cumple</returns>
        private bool validaBuscar(int total)
        {
            return validaPasajeros(total); 
        }

        #endregion

        /// <summary>
        /// Evento que llama el método de desplegar al hacer clic en el panel principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void panel1_Click(object sender, EventArgs e)
        {
            if (desplegado) pnlPasajeros_Click(sender, e);
        }

        /// <summary>
        /// Evento que llama el método de desplegar al hacer clic en el panel que contiene
        /// tanto el calendario como el control que se despliega.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Click(object sender, EventArgs e)
        {
            if (desplegado) pnlPasajeros_Click(sender, e);
        }
    }
}
