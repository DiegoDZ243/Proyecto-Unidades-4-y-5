using BarcodeLib;
using MisControles; 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Permite llenar los boletos con los datos del pasajero.
    /// </summary>
    public partial class frmBoletos : Form
    {
        //Total de pasajeros que viajarán
        private int total = 0;
        //Atributo que almacena si se ha completado la venta de boletos
        private bool finalizado = false; 
        //Variable que almacena la cantidad de boletos vendida para el vuelo hasta ahora (sin contar los actuales)
        private int numSerie; 
        //Arreglo que contiene los boletos que se venderán al usuario/s
        private interfazBoleto[] boletos;
        //Datos del vuelo actual
        private Vuelo currVuelo;
        //Lista con los códigos de barras generados para cada boleto
        private List<string> codigos = new List<string>(); 
        
        /// <summary>
        /// Constructor del formulario. Este no recibe ningún parámetro
        /// </summary>
        public frmBoletos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor del formulario. Inicializa algunas variables globales, así como 
        /// componentes gráficos del formulario (como los boletos, por ejemplo).
        /// </summary>
        /// <param name="asientos">Lista de los asientos seleccionados</param>
        /// <param name="pasajeros">Arreglo con los pasajeros que se registraran</param>
        /// <param name="vuelo">Objeto con la información del vuelo</param>
        /// <param name="numeracion">Cantidad de boletos que se han vendido para el vuelo</param>
        public frmBoletos(List<string> asientos, int[] pasajeros, Vuelo vuelo, int numeracion)
        {
            InitializeComponent();
            currVuelo = vuelo;
            total = pasajeros[0] + pasajeros[1] + pasajeros[2];
            numSerie = numeracion + 1;
            boletos = new interfazBoleto[total];
            generaBoletos(total,asientos, vuelo, pasajeros);
            btnSiguiente.Image = Properties.Resources.icn_continuar.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnAtras.Location = new Point(12, 12);
            
        }

        /// <summary>
        /// Crea dinámicamente controles "interfazBoleto" y los añade al formulario.
        /// Al terminar de insertar los controles, coloca el botón de continuar justo
        /// debajo del último control "interfazBoleto". Estos permiten llenar los datos
        /// del pasajero en el boleto.
        /// </summary>
        /// <param name="n">Número de boletos a generar</param>
        /// <param name="asientos">Lista de asientos seleccionados</param>
        /// <param name="vuelo">Información general del vuelo</param>
        /// <param name="pasajeros">Información general de los pasajeros (si son adultos, menores o bebés)</param>
        private void generaBoletos(int n, List<string> asientos, Vuelo vuelo, int[] pasajeros)
        {
            int x, y = 10, indexP = 0; 
            
            /*  Se itera "n" veces para generar "n" interfacesBoleto y
             *  asigna un encabezado para el boleto. 
             */
            for (int i = 0; i < n; i++)
            {
                while (pasajeros[indexP]==0 && indexP<3)
                {
                    indexP++;
                }
                
                interfazBoleto boleto = new interfazBoleto(i+1);
                
                x=(this.ClientSize.Width-boleto.Width)/2;
                //Se añade un encabezado según la categoría a la que pertenece el pasajero
                if (indexP == 0)
                {
                    boleto.Encabezado.Text = "Adulto";
                }
                else if(indexP == 1)
                {
                    boleto.Encabezado.Text = "Menor";
                }
                else
                {
                    boleto.Encabezado.Text = "Bebé";
                }
                
                
                //Asigna algunos datos al boleto que se genera
                boleto.Location = new Point(x, y);
                boleto.Name = "boleto" + (i + 1).ToString();
                boleto.Asiento.Text = asientos[i];
                boleto.NoVuelo.Text = vuelo.id.ToString();
                boleto.Fecha.Text = vuelo.fecha.Add(vuelo.hora_salida).ToString("dd/MM/yyyy");
                boleto.Hora.Text=DateTime.Today.Add(vuelo.hora_salida).ToString("hh:mm tt").ToUpper();
                boleto.Destino.Text=vuelo.destino.ToString();
                Barcode codigoBarras = new Barcode
                {
                    IncludeLabel = true,
                    Alignment = AlignmentPositions.CENTER
                };

               
                codigos.Add(generarCodigo(boleto));
                //Se genera el código de barra único para el boleto.
                Image img = codigoBarras.Encode(TYPE.CODE128, codigos[i], Color.Black, Color.White, 250, 80);
                boleto.CodigoBarras.Image = img;
                boletos[i]= boleto;
                //Se añade al formulario
                this.Controls.Add(boleto);
                y += boleto.Height + 50;
                pasajeros[indexP]--;
            }
            //Se modifica la localización de botón para colocarlos debajo del ultimo control
            //personalizado.
            btnSiguiente.Location = new Point((this.ClientSize.Width - btnSiguiente.Width)/2, y); 
        }

        /// <summary>
        /// Botón que permite hacer el registro de los boletos vendidos en la base de 
        /// datos. Antes de hacer el registro, se verifica que los datos cumplan con 
        /// las validaciones y que el usuario esté seguro de hacer el registro de 
        /// los datos. Finalmente, abre el formulario que permitirá imprimir los boletos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            /*  Recorre cada boleto generado y revisa que sus campos estén 
             *  bien validados. En caso contrario, se hace return y se hace
             *  focus al boleto con campos que no cumplen con la validación.
             */

            for(int i = 0; i < total; i++)
            {
                if (!boletos[i].Validado) 
                {
                    boletos[i].Focus(); 
                    return; 
                } 

            }
            /*  Una vez terminada la validación, se pregunta al usuario si está seguro de
             *  los datos que ingreso, pues no podrá modificarlos más adelante.
             */

            DialogResult confirmacion = MessageBox.Show(this,"¿Está seguro de que desea continuar?" +
                " No será posible hacer modificaciones más adelante", "Confirmación",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No) return; 

            /*  Se recuperan los datos del boleto dentro de la interfazBoleto
             *  para hacer el registro de los boletos en la base de datos.
             */
            Boleto[] boletosComprados=new Boleto[total];
            clsDaoDestinos dao=new clsDaoDestinos();
            for(int i = 0; i < total; i++)
            {
                Boleto nuevo=new Boleto();
                nuevo.id_boleto = codigos[i]; 
                nuevo.nombre=boletos[i].Nombre.Text.Trim();
                nuevo.a_paterno = boletos[i].Paterno.Text.Trim();
                nuevo.a_materno = boletos[i].Materno.Text.Trim();
                nuevo.asiento = boletos[i].Asiento.Text.Trim();
                nuevo.check_in = false;
                nuevo.id_vuelo = currVuelo.id;
                boletosComprados[i] = nuevo; 
            }
            //Si se inserta el boleto correctamente, se lactualiza el cupo.
            if (dao.InsertarBoletos(boletosComprados))
            {
                dao.ActualizarCupo(currVuelo, boletosComprados.Length);
            }

            //Abre el formulario para imprimir los boletos.
            frmImprimeBoletos formulario = new frmImprimeBoletos(this,boletos); 
            formulario.ShowDialog();
            //Si el formulario regresa true para "finalizado" se cierra el formulario
            if (formulario.getFinalizado())
            {
                formulario.Dispose();
                finalizado = true; 
                this.Close();
            }
            else
            {
                this.Show(); 
            }
        }

        /// <summary>
        /// Método que genera el ID del boleto, utilizando como números fijos
        /// "75010007", seguido del número del vuelo, el número de boletos vendidos
        /// hasta el momento y terminando con el valor númerico del asiento del 
        /// boleto. 
        /// </summary>
        /// <param name="boleto">Interfaz boleto con información complementaria</param>
        /// <returns>Código de barras para un pasajero</returns>
        private string generarCodigo(interfazBoleto boleto)
        {
            string codigoB = "750";
            codigoB += "10007";
            if (0 <= int.Parse(boleto.NoVuelo.Text) && int.Parse(boleto.NoVuelo.Text) <= 9)
            {
                codigoB += "0" + boleto.NoVuelo.Text;
            }
            else
            {
                codigoB += boleto.NoVuelo.Text;
            }
            if (0 <= numSerie && numSerie <= 9)
            {
                codigoB += "0" + numSerie.ToString();
            }
            else
            {
                codigoB += numSerie.ToString();
            }
            codigoB += ((int)(boleto.Asiento.Text[0] - 'A')).ToString() + boleto.Asiento.Text[1];
            numSerie++;
            return codigoB;
        }

        /// <summary>
        /// Getter de la variable finalizado. Esta variable permite regresar
        /// menú principal una vez se registran los boletos. 
        /// </summary>
        /// <returns>Regresa la variable <c>finalizado</c></returns>
        public bool getFinalizado()
        {
            return finalizado; 
        }

        /// <summary>
        /// Evento asociado al botón para regresar al formulario anterior, cerrando el 
        /// actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// Evento que carga el formulario y, además, carga la imagen dentro del botón "atrás".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBoletos_Load(object sender, EventArgs e)
        {
            btnAtras.Image = Properties.Resources.icn_atras.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            
        }

        /// <summary>
        /// Centra la atención hacia el primer boleto dentro del formulario, esto solo una vez
        /// que el formulario es mostrado. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBoletos_Shown(object sender, EventArgs e)
        {
            boletos[0].Focus(); 
        }
    }
}
