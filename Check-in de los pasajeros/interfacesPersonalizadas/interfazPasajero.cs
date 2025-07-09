using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacesPersonalizadas
{
    /// <summary>
    /// Control personalizado que permite mostrar los datos de
    /// los pasajeros que aún no han abordado al avión.
    /// </summary>
    public partial class interfazPasajero : UserControl
    {
        /// <summary>
        /// Costructor del control personalizado "interfazPasajero".
        /// </summary>
        public interfazPasajero()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que carga los componentes del control personalizado. Centra los componentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interfazPasajero_Load(object sender, EventArgs e)
        {
            lblNombre.Location = new Point((this.ClientSize.Width - lblNombre.Width) / 2, lblNombre.Location.Y);
            lblAsiento.Location = new Point((this.ClientSize.Width - lblAsiento.Width) / 2, lblAsiento.Location.Y);
            pictureBox1.Location = new Point((this.ClientSize.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y); 
        }

        /// <summary>
        /// Retorna el Label que contiene el nombre del pasajero.
        /// </summary>
        public System.Windows.Forms.Label Nombre
        {
            get
            {
                return lblNombre; 
            }
        }

        /// <summary>
        /// Retorna el Label que contiene el asiento asigando al pasajero.
        /// </summary>
        public System.Windows.Forms.Label Asiento
        {
            get
            {
                return lblAsiento;
            }
        }

        /// <summary>
        /// Método que centra los componentes del control.
        /// </summary>
        private void centrar()
        {
            lblNombre.Location = new Point((this.ClientSize.Width - lblNombre.Width)/2, lblNombre.Location.Y);
            lblAsiento.Location = new Point((this.ClientSize.Width - lblAsiento.Width) / 2, lblAsiento.Location.Y);
        }

        /// <summary>
        /// Evento que se activa al cambiar el nombre del pasajero.
        /// Simplemente centra los componentes luego del cambio. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNombre_TextChanged(object sender, EventArgs e)
        {
            centrar();
        }
    }
}
