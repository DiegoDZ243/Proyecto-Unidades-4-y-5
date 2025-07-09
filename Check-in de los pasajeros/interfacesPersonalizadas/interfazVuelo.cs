using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacesPersonalizadas
{
    /// <summary>
    /// Control personalizado que permite mostrar los datos de los
    /// vuelos disponibles para hacer check-in.
    /// </summary>
    public partial class interfazVuelo : UserControl
    {
        /// <summary>
        /// Constructor del control personalizado "interfazVuelo". Centra los componentes
        /// dentro del control.
        /// </summary>
        public interfazVuelo()
        {
            InitializeComponent();
            btnSeleccionar.Location = new Point((this.ClientSize.Width - btnSeleccionar.Width) / 2, btnSeleccionar.Location.Y);
            btnSeleccionar.Image = Properties.Resources.icn_clic.GetThumbnailImage(20, 20, null, IntPtr.Zero);
        }

        /// <summary>
        /// Retorna el Label que contiene el número del vuelo.
        /// </summary>
        public Label NumVuelo
        {
            get
            {
                return lblNumVuelo; 
            }
        }

        /// <summary>
        /// Retorna el Label que contiene el nombre del destino del vuelo.
        /// </summary>
        public Label Destino
        {
            get
            {
                return lblDestino; 
            }
        }

        /// <summary>
        /// Retorna el Label que contine la fecha de salida del vuelo.
        /// </summary>
        public Label Fecha
        {
            get
            {
                return lblFecha; 
            }
        }

        /// <summary>
        /// Retorna el Button dentro del control personalizado.
        /// </summary>
        public Button Boton
        {
            get
            {
                return btnSeleccionar; 
            }
        }

        /// <summary>
        /// Evento que se activa al cambiar el número del vuelo.
        /// Simplemente centra los componentes dentro del control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNumVuelo_TextChanged(object sender, EventArgs e)
        {
            centrar(); 
        }

        /// <summary>
        /// Función que centra los componentes del control. 
        /// </summary>
        private void centrar()
        {
            lblDestino.Location = new Point((this.ClientSize.Width-lblDestino.Width)/2,lblDestino.Location.Y);
            lblNumVuelo.Location = new Point((this.ClientSize.Width - lblNumVuelo.Width) / 2, lblNumVuelo.Location.Y);
            lblFecha.Location = new Point((this.ClientSize.Width -lblFecha.Width) / 2,lblFecha.Location.Y);
        }
    }
}
