using MisControles.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisControles
{
    /// <summary>
    /// Control personalizado que muestra los datos de un pasajero
    /// durante la selección de asientos.
    /// </summary>
    public partial class interfazPasajero : UserControl
    {
        /// <summary>
        /// Constructor del control personalizado "interfazPasajero"
        /// </summary>
        public interfazPasajero()
        {
            InitializeComponent();
            centrarControles();
            pcbIcono.Location = new Point(this.ClientSize.Width - 5-pcbIcono.Width,(this.ClientSize.Height-pcbIcono.Height)/2);
        }

        /// <summary>
        /// Retorna el Label que contiene la catehoria del pasajero (adulto, menor, bebé).
        /// </summary>
        public Label Pasajero
        {
            get
            {
                return lblPasajero;
            }
        }

        /// <summary>
        /// Retorna el Label que contiene el asiento del pasajero.
        /// </summary>
        public Label Asiento
        {
            get
            {
                return lblAsiento; 
            }
        }

        /// <summary>
        /// Retorna el Label que contiene el precio del asiento seleccionado.
        /// </summary>
        public Label Precio
        {
            get
            {
                return lblPrecio;

            }
        }

        /// <summary>
        /// Limpia y centra el asiento y precio del mismo.
        /// </summary>
        public void limpiaAsiento()
        {
            lblAsiento.Text = "------"; 
            lblPrecio.Text = "------";
            centrarControles(); 
        }

        /// <summary>
        /// Evento que se activa cuando el texto dentro del Label que contiene el
        /// asiento. Simplemente centra los componentes del control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAsiento_TextChanged(object sender, EventArgs e)
        {
            centrarControles();
        }

        /// <summary>
        /// Centra el Label del asiento y del precio.
        /// </summary>
        private void centrarControles()
        {
            lblAsiento.Location = new Point(
            lblPasajero.Right + 5,
            lblPasajero.Top
            );

            lblPrecio.Location = new Point(
                lblAsiento.Right + 5,
                lblAsiento.Top
            );
        }

        /// <summary>
        /// Evento que se activa cuando la descripción del pasajero se cambia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPasajero_TextChanged(object sender, EventArgs e)
        {
            if(lblPasajero.Text == "Adulto")
            {
                pcbIcono.Image = Properties.Resources.icn_adulto; 
            }
            else if(lblPasajero.Text == "Menor")
            {
                pcbIcono.Image = Properties.Resources.icn_menores;
            }
            else
            {
                pcbIcono.Image = Properties.Resources.icn_bebe;
            }
        }

        private void interfazPasajero_Load(object sender, EventArgs e)
        {

        }
    }
}

