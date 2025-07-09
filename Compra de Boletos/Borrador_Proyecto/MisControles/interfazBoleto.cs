using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisControles
{
    /// <summary>
    /// Control personalizado que permite el llenado y display de los
    /// datos de un pasajero para la generación de su pase de abordaje.
    /// </summary>
    public partial class interfazBoleto : UserControl
    {
        private int num; 
        /// <summary>
        /// Constructor del control
        /// </summary>
        /// <param name="num">Número que se mostrará en la viñeta del boleto</param>
        public interfazBoleto(int num)
        {
            InitializeComponent();
            this.num = num;
            this.Paint += new PaintEventHandler(generaVineta);
        }

        /// <summary>
        /// Pregunta si los campos del boleto están correctamente validados.
        /// </summary>
        public bool Validado
        {
            get
            {
                return (validaNombre() && validaMaterno() && validaPaterno());
            }
        }
        /// <summary>
        /// Recupera el Text Box del control que contiene el nombre del cliente. 
        /// </summary>
        public TextBox Nombre
        {
            get
            {
                return txtNombre; 
            }
        }

        /// <summary>
        /// Recupera el Text Box del control que tiene el apellido paterno del cliente.
        /// </summary>
        public TextBox Paterno
        {
            get
            {
                return txtPaterno;
            }
        }

        /// <summary>
        /// Recupera el Text Box del control que contiene el apellido materno del cliente.
        /// </summary>
        public TextBox Materno
        {
            get
            {
                return txtMaterno; 
            }
        }

        /// <summary>
        /// Recupera el Label que contiene el número de vuelo.
        /// </summary>
        public Label NoVuelo
        {
            get {
                return lblNumAsiento;
            }
        }

        /// <summary>
        /// Recupera el Label que contiene el asiento asignado al boleto.
        /// </summary>
        public Label Asiento
        {
            get
            {
                return lblAsiento;
            }
        }

        /// <summary>
        /// Recupera el Label que contiene la fecha de salida del vuelo.
        /// </summary>
        public Label Fecha
        {
            get
            {
                return lblFecha; 
            }
        }
        /// <summary>
        /// Recupera el Label que contiene la hora de salida del vuelo.
        /// </summary>
        public Label Hora
        {
            get
            {
                return lblHoraAbordaje; 
            }
        }

        /// <summary>
        /// Recupera el Label que contiene el destino del vuelo.
        /// </summary>
        public Label Destino
        {
            get
            {
                return lblDestino; 
            }
        }

        /// <summary>
        /// Recupera el Label que contiene el encabezado donde se coloca si el boleto
        /// es para un adulto, menor o bebé.
        /// </summary>
        public Label Encabezado
        {
            get
            {
                return lblTitulo;
            }
        }

        /// <summary>
        /// Recupera el Panel que contiene el diseño del boleto generado.
        /// </summary>
        public Panel Boleto
        {
            get
            {
                return pnlBoleto;
            }
        }

        /// <summary>
        /// Recupera el PictureBox que contiene el código de barras en el boleto.
        /// </summary>
        public PictureBox CodigoBarras
        {
            get
            {
                return pcbCodigo; 
            }
        }

        /// <summary>
        /// Método que dibuja la viñeta que está en la parte izquierda superior del
        /// control. El número dentro de la viñeta será el enviado en el constructor
        /// del control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generaVineta(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string numero = num.ToString();
            Font fuente = new Font("Arial", 20);
            SizeF medida = g.MeasureString(numero, fuente);
            float radio = Math.Max(medida.Width, medida.Height)+6;

            float x = 25;
            float y = lblTitulo.Location.Y;
            g.FillEllipse(Brushes.DeepSkyBlue, x, y, radio, radio);

            PointF puntoTexto= new PointF(x+(radio-medida.Width)/2,y+(radio-medida.Height)/2);
            g.DrawString(numero, fuente, Brushes.White, puntoTexto); 
                        
        }
        /// <summary>
        /// Método que valida que el nombre ingresado no esté vacio y tenga entre 2 y 30 
        /// caracteres.
        /// </summary>
        /// <returns><c>True: </c>El nombre cumple con las condiciones; <c>False: </c>El nombre no cumple con las condiciones</returns>
        private bool validaNombre()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                errNombre.SetError(txtNombre, "No puede dejar el campo de nombre vacío");
                return false;
            }
            else if (!(2 <= txtNombre.Text.Trim().Length && txtNombre.Text.Trim().Length <= 30))
            {
                errNombre.SetError(txtNombre, "El nombre debe tener entre 2 y 30 caracteres");
                return false;
            }
            errNombre.Clear();
            return true;
        }

        /// <summary>
        /// Método que valida que el apellido paterno ingresado no esté vacio y tenga entre 2 y 20 
        /// caracteres.
        /// </summary>
        /// <returns><c>True: </c>El apellido cumple con las condiciones; <c>False: </c>El apellido no cumple con las condiciones</returns>
        private bool validaPaterno()
        {
            if (String.IsNullOrEmpty(txtPaterno.Text.Trim()))
            {
                errPaterno.SetError(txtPaterno, "No puede dejar el campo del apellido paterno vacío");
                return false;
            }
            else if (!(2 <= txtPaterno.Text.Trim().Length && txtPaterno.Text.Trim().Length <= 20))
            {
                errPaterno.SetError(txtPaterno, "El apellido paterno debe tener entre 2 y 20 caracteres");
                return false;
            }
            errPaterno.Clear();
            return true;
        }

        /// <summary>
        /// Método que valida que el apellido materno ingresado no esté vacío y tenga entre 2 y 20 
        /// caracteres.
        /// </summary>
        /// <returns><c>True: </c>El apellido cumple con las condiciones; <c>False: </c>El apellido no cumple con las condiciones</returns>
        private bool validaMaterno()
        {
            if (String.IsNullOrEmpty(txtMaterno.Text.Trim()))
            {
                errMaterno.SetError(txtMaterno, "No puede dejar el campo del apellido materno vacío");
                return false;
            }
            else if (!(2 <= txtMaterno.Text.Trim().Length && txtMaterno.Text.Trim().Length <= 20))
            {
                errMaterno.SetError(txtMaterno, "El apellido materno debe tener entre 2 y 20 caracteres");
                return true;
            }
            errMaterno.Clear();
            return true;
        }

        /// <summary>
        /// Evento que muestra el texto escrito en el TextBox que contiene el nombre. Se
        /// activa cada vez que se modifica el texto dentro del mismo.
        /// 
        /// Cada vez que esto pasa, se valida el nuevo nombre ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            string temp = "";
            if (!String.IsNullOrEmpty(txtNombre.Text)) temp += txtNombre.Text.Trim();
            if (!String.IsNullOrEmpty(txtPaterno.Text)) temp += " " + txtPaterno.Text.Trim();
            if (!String.IsNullOrEmpty(txtMaterno.Text)) temp += " " + txtMaterno.Text.Trim();
            lblNombre.Text = temp;
            validaNombre();
        }

        /// <summary>
        /// Evento que muestra el texto escrito en el TextBox que contiene el apellido paterno. Se
        /// activa cada vez que se modifica el texto dentro del mismo.
        /// 
        /// Cada vez que esto pasa, se valida el nuevo apellido paterno ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPaterno_TextChanged_1(object sender, EventArgs e)
        {
            string temp = "";
            if (!String.IsNullOrEmpty(txtNombre.Text)) temp += txtNombre.Text.Trim();
            if (!String.IsNullOrEmpty(txtPaterno.Text)) temp += " " + txtPaterno.Text.Trim();
            if (!String.IsNullOrEmpty(txtMaterno.Text)) temp += " " + txtMaterno.Text.Trim();
            lblNombre.Text = temp;
            validaPaterno();
        }

        /// <summary>
        /// Evento que muestra el texto escrito en el TextBox que contiene el apellido materno. Se
        /// activa cada vez que se modifica el texto dentro del mismo.
        /// 
        /// Cada vez que esto pasa, se valida el nuevo apellido materno ingresado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMaterno_TextChanged_1(object sender, EventArgs e)
        {
            string temp = "";
            if (!String.IsNullOrEmpty(txtNombre.Text)) temp += txtNombre.Text.Trim();
            if (!String.IsNullOrEmpty(txtPaterno.Text)) temp += " " + txtPaterno.Text.Trim();
            if (!String.IsNullOrEmpty(txtMaterno.Text)) temp += " " + txtMaterno.Text.Trim();
            lblNombre.Text = temp;
            validaMaterno();
        }
    }
}
