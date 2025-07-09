using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonalizado
{
    public partial class interfazBoleto : UserControl
    {
        private string encabezado, origen, destino, asiento;
        private DateTime fecha;
        private int id_vuelo;

        public interfazBoleto()
        {
            InitializeComponent();
        }

        public bool validado
        {
            get
            {
                return (validaNombre() && validaMaterno() && validaPaterno()); 
            }
        }

        public Panel boleto
        {
            get
            {
                return pnlBoleto; 
            }
        }

        private void interfazBoleto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = encabezado; 
            lblOrigen.Text=origen;
            lblDestino.Text=destino;
            lblNumAsiento.Text = asiento;
            lblFecha.Text = fecha.ToString("dd MM yyyy hh:mm tt");
            lblNumAsiento.Text = id_vuelo.ToString(); 
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text.Trim(); 
            validaNombre(); 
        }

        private void txtPaterno_TextChanged(object sender, EventArgs e)
        {
            validaPaterno(); 
            lblNombre.Text =" "+txtPaterno.Text.Trim();
        }

        private void txtMaterno_TextChanged(object sender, EventArgs e)
        {
            validaMaterno();
            lblNombre.Text = " " + txtMaterno.Text.Trim(); 
        }

        private bool validaNombre()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                errNombre.SetError(txtNombre, "No puede dejar el campo de nombre vacío");
                return false; 
            }else if (2 <= txtNombre.Text.Trim().Length && txtNombre.Text.Trim().Length <= 30)
            {
                errNombre.SetError(txtNombre, "El nombre debe tener entre 2 y 30 caracteres");
                return true; 
            }
            errNombre.Clear();
            return true; 
        }
        private bool validaPaterno()
        {
            if (String.IsNullOrEmpty(txtPaterno.Text.Trim()))
            {
                errPaterno.SetError(txtPaterno, "No puede dejar el campo del apellido paterno vacío");
                return false;
            }
            else if (2 <= txtPaterno.Text.Trim().Length && txtPaterno.Text.Trim().Length <= 20)
            {
                errPaterno.SetError(txtPaterno, "El apellido paterno debe tener entre 2 y 20 caracteres");
                return true;
            }
            errPaterno.Clear();
            return true;
        }

        private bool validaMaterno()
        {
            if (String.IsNullOrEmpty(txtMaterno.Text.Trim()))
            {
                errMaterno.SetError(txtMaterno, "No puede dejar el campo del apellido materno vacío");
                return false;
            }
            else if (2 <= txtMaterno.Text.Trim().Length && txtMaterno.Text.Trim().Length <= 20)
            {
                errMaterno.SetError(txtMaterno, "El apellido materno debe tener entre 2 y 20 caracteres");
                return true;
            }
            errMaterno.Clear();
            return true;
        }

    }

}

