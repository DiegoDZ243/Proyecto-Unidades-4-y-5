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
    /// Componente personalizado por usuario que permite mostrar los destinos
    /// disponibles en el aeropuerto.
    /// </summary>
    public partial class interfazDestino : UserControl
    {
        /// <summary>
        /// Constructor del control "interfazDestino". Centra los componentes gráficos
        /// y los incializa.
        /// </summary>
        public interfazDestino()
        {
            InitializeComponent();
            
            pcbDestino.Location = new Point((this.ClientSize.Width - pcbDestino.Width) / 2, pcbDestino.Location.Y);
            lblDestino.Location = new Point(pcbDestino.Location.X+(pcbDestino.Width - lblDestino.Width) / 2, pcbDestino.Location.Y-lblDestino.Height-10);
            btnViajar.Image= Properties.Resources.icnBuscar.GetThumbnailImage(30, 30, null, IntPtr.Zero);
        }

        /// <summary>
        /// Retorna el Label que contiene el nombre  del destino.
        /// </summary>
        public Label Nombre
        {
            get
            {
                return lblDestino; 
            }
        }

        /// <summary>
        /// Retorna el PictureBox que contiene la imagen asociada al destino.
        /// </summary>
        public PictureBox Imagen
        {
            get
            {
                return pcbDestino; 
            }
        }

        /// <summary>
        /// Retorna el Button del control personalizado.
        /// </summary>
        public Button Boton
        {
            get
            {
                return btnViajar; 
            }
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }
    }
}
