using MisControles;
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
    /// Clase que permite elegir los asientos dentro del avión.
    /// También muestra el total a pagar por los boletos.
    /// </summary>
    public partial class frmCupo : Form
    {
        //Almacena los asientos que han sido seleccionados hasta ahora
        private List<string> asientosSeleccionados=new List<string>();
        //Almacena los asientos que están ocupados
        private List<string> asientosOcupados;
        //Arreglo con los controles personalizados que muestran los datos del pasajero (asiento y precio del mismo)
        private interfazPasajero[] displayPasajeros;
        //Variables de control para la selección de asientos (columna y fila seleccionada, total de pasajeros y el total a pagar por los asientos)
        private int colSeleccionada, filaSeleccionada,totalPasajeros,indexActual=1,totalEnAsientos=0;
        //Arreglo con las categorías de los pasajeros que viajarán
        private int[] pasajeros; 
        //Vuelo actual
        private Vuelo vueloActual;
        //Total a pagar por solo los boletos
        private int subTotal; 
        //Atributo que almacena si se completo la venta de boletos
        private bool finalizado = false; 
        
        /// <summary>
        /// Constructor que inicializa los atributos del formulario. También calcula
        /// la cantidad de pasajeros que abordarán al vuelo y permitirá elegir asientos en 
        /// base a esto.
        /// </summary>
        /// <param name="vueloElegido">Datos del vuelo elegido por el usuario</param>
        /// <param name="pasajeros">Arreglo con las categorias de los pasajeros que abordarán al vuelo</param>
        public frmCupo(Vuelo vueloElegido, int[] pasajeros)
        {
            InitializeComponent();
            vueloActual=vueloElegido;
            this.pasajeros=pasajeros;
            totalPasajeros = pasajeros[0] + pasajeros[1] + pasajeros[2];
            displayPasajeros = new interfazPasajero[totalPasajeros]; 
        }

        /// <summary>
        /// Carga los componentes gráficos del formulario:
        /// DataGrid, botones, paneles, labels. También modifica su posición
        /// para centrarlos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCupo_Load(object sender, EventArgs e)
        {
            gridAsientos.Width = 313;
            gridAsientos.Height = 404;
            generarAsientos();
            marcarAsientosOcupados();
            generaPasajeros();
            btnContinuar.Enabled = false;
            #region CENTRADO Y CAMBIO DE TAMAÑO DE LOS CONTROLES
            pnlEncabezadoBoletos.Width=flpPasajeros.Width = displayPasajeros[0].Width + 20;
            lblBoletos.Location = new Point((pnlEncabezadoBoletos.Width - lblBoletos.Width) / 2, (pnlEncabezadoBoletos.Height - lblBoletos.Height) / 2);
            pcbBoletos.Location = new Point(lblBoletos.Location.X + lblBoletos.Width + 5, (pnlEncabezadoBoletos.Height-pcbBoletos.Height)/2); 
            btnAtras.Image = Properties.Resources.icn_atras.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            lblTotal.Location = new Point((flpPasajeros.Location.X + flpPasajeros.Width - lblTotal.Width), flpPasajeros.Location.Y + flpPasajeros.Height + 10);
            gridAsientos.Location = new Point((pnlAsientosFondo.Width - gridAsientos.Width) / 2, 10);
            pnlLibre.Location = new Point(pnlLibre.Location.X, gridAsientos.Location.Y + gridAsientos.Height +10);
            lblLibre.Location = new Point(lblLibre.Location.X, pnlLibre.Location.Y + pnlLibre.Height + 5);
            pnlOcupado.Location = new Point(pnlOcupado.Location.X, gridAsientos.Location.Y +gridAsientos.Height+ 10);
            lblOcupado.Location = new Point(lblOcupado.Location.X, pnlOcupado.Location.Y + pnlOcupado.Height + 5);
            pnlSeleccionado.Location = new Point(pnlSeleccionado.Location.X, gridAsientos.Location.Y + gridAsientos.Height + 10);
            lblSeleccionado.Location = new Point(lblSeleccionado.Location.X, pnlSeleccionado.Location.Y + pnlSeleccionado.Height + 5);
            #endregion
            lblTotalAPagar.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);

        }

        /// <summary>
        /// Utiliza el control generado por el usuario llamado
        /// "interfazPasajero" para mostrar los boletos que se comprarán.
        /// Estos controles se crean y agregan de manera dinámica al "FlowLayOut Panel".
        /// También carga las etiquetas con el precio total que pagará el usuario.
        /// </summary>
        private void generaPasajeros()
        {
            int totalAPagar = 0; 
            int total = 1; 
            for (int i = 0; i < pasajeros.Length; i++)
            {
                for (int j = 0; j < pasajeros[i]; j++)
                {
                    interfazPasajero nuevoPasajero = new interfazPasajero();
                    nuevoPasajero.Name = "pasajero" + (total);
                    if (i == 0)
                    {
                        nuevoPasajero.Pasajero.Text = "Adulto";
                    }
                    else if (i == 1)
                    {
                        nuevoPasajero.Pasajero.Text = "Menor";
                    }
                    else
                    {
                        nuevoPasajero.Pasajero.Text = "Bebé";
                    }
                    displayPasajeros[total - 1] = nuevoPasajero;
                    this.flpPasajeros.Controls.Add(nuevoPasajero);
                    total++;
                    totalAPagar += (int)vueloActual.precio; 
                }
            }
            subTotal = totalAPagar;
            lblTotalAPagar.Text = "Total: " + $"${subTotal+totalEnAsientos:N0} MXN";
            lblTotalAPagar.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);

        }

        /// <summary>
        /// Asigna el formato al grid, dándole tamaño a las filas y columnas.
        /// Colorea el pasillo entre los dos bloques de asientos y también colorea
        /// de manera predeterminada las celdas de color verde claro (asientos disponibles).
        /// </summary>
        private void generarAsientos()
        {
            int anchoCol = 50, anchoFila = 50; 
            string[] columnas = { "A", "B", "C","", "D", "E", "F" };

            gridAsientos.Columns.Clear();
            foreach (string col in columnas)
            {
                gridAsientos.Columns.Add(col, col);
                gridAsientos.Columns[col].Width = anchoCol;
                gridAsientos.Columns[col].SortMode= DataGridViewColumnSortMode.NotSortable;
            }
            gridAsientos.Columns[""].Width = 10;
            gridAsientos.Columns[""].DefaultCellStyle.BackColor = Color.Gray;
            gridAsientos.Columns[""].DefaultCellStyle.SelectionBackColor = Color.Gray;
            gridAsientos.Columns[""].ReadOnly = true;

            gridAsientos.Rows.Clear();
            for (int i = 0; i < 8; i++)
            {
                gridAsientos.Rows.Add();
                gridAsientos.Rows[i].HeaderCell.Value = (i + 1).ToString();
                gridAsientos.Rows[i].Height = anchoFila;
            }

            
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (columnas[j] == "") continue; 
                    gridAsientos.Rows[i].Cells[j].Value = columnas[j] +(i + 1).ToString();
                    gridAsientos.Rows[i].Cells[j].Style.BackColor=Color.LightGreen;
                }
            }

            gridAsientos.RowHeadersWidth = 60;

            
        }

        /// <summary>
        /// Evento que se desencadena al hacer clic en una de las celdas del grid.
        /// Permite obtener el index de la fila a la que pertenece la celda seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >=0)
            {
                colSeleccionada = e.ColumnIndex;
                filaSeleccionada = e.RowIndex; 
            }
        }

        /// <summary>
        /// Método que lleva el control de los asientos que han sido seleccionados por
        /// el usuario. Si se da doble clic sobre un asiento libre, este pasará a un
        /// estado de seleccionado. Si se hace doble clic sobre un asiento seleccionado,
        /// este pasará a ser libre. Si se da clic en un asiento ocupado, no pasará nada.
        /// 
        /// No deja seleccionar más asientos que la cantidad de boletos producida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridAsientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell asiento = gridAsientos.Rows[filaSeleccionada].Cells[colSeleccionada]; 
            //Se hace clic en una celda con un asiento disponible
            if(asiento.Style.BackColor == Color.LightGreen && asientosSeleccionados.Count<totalPasajeros)
            {
                //Asigna un estado seleccionado al mismo y se carga el precio por la selección
                asiento.Style.BackColor = Color.Goldenrod;
                asiento.Style.SelectionBackColor= Color.Goldenrod;
                asiento.Style.SelectionForeColor = Color.Black;
                displayPasajeros[indexActual-1].Asiento.Text = asiento.Value.ToString();
                displayPasajeros[indexActual - 1].Precio.Text = "$750";
                totalEnAsientos += 750;
                lblTotal.Text = "Total en asientos: "+$"${totalEnAsientos:N0} MXN";
                lblTotalAPagar.Text = "Total: " + $"${subTotal+totalEnAsientos:N0} MXN";
                lblTotal.Location = new Point((flpPasajeros.Location.X + flpPasajeros.Width - lblTotal.Width), flpPasajeros.Location.Y + flpPasajeros.Height + 10);
                lblTotalAPagar.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);

                asientosSeleccionados.Add(asiento.Value.ToString());
                indexActual++; 

            }
            //Se hace clic en una celda previamente seleccionada
            else if(asiento.Style.BackColor == Color.Goldenrod)
            {
                //Reestablece el estado libre del asiento y se descuenta el precio de la selección del mismo
                asiento.Style.BackColor = Color.LightGreen;
                asiento.Style.SelectionBackColor = SystemColors.Highlight;
                asiento.Style.SelectionForeColor = SystemColors.HighlightText;
                displayPasajeros[indexActual - 2].limpiaAsiento();
                totalEnAsientos -= 750;
                lblTotal.Text = "Total asientos: " + $"${totalEnAsientos:N0} MXN";
                lblTotalAPagar.Text = "Total: " + $"${subTotal +totalEnAsientos:N0} MXN";
                lblTotal.Location = new Point((flpPasajeros.Location.X + flpPasajeros.Width - lblTotal.Width), flpPasajeros.Location.Y +flpPasajeros.Height+ 10);
                lblTotalAPagar.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);
                asientosSeleccionados.Remove(asiento.Value.ToString());
                indexActual--;
            }
            //Se ha seleccionado la cantidad de pasajeros que viajarán
            if (asientosSeleccionados.Count == totalPasajeros)
            {
                btnContinuar.Enabled = true;
            }
            else
            {
                btnContinuar.Enabled = false;
            }
        }


        /// <summary>
        /// Botón que permite pasar al siguiente formulario, una vez todos los
        /// asientos hayan sido asignados. Una vez se finaliza una venta, permite cerrar
        /// el formulario para regresar al original.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            frmBoletos formulario = new frmBoletos(asientosSeleccionados,
            (int[])pasajeros.Clone(), vueloActual, asientosOcupados.Count);
            this.Hide();
            formulario.ShowDialog();
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
        /// Evento que se desencadena al dar clic en la CheckBox. Permite
        /// escoger los asientos de los boletos de manera aleatoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAsientos_CheckedChanged(object sender, EventArgs e)
        {
            /*  Recorre el arreglo de asientos seleccionados hasta el momento y
             *  los deselecciona para ya sea:
             *  
             *      1) Hacer la elección aleatoria de un asiento.
             *      2) Volver al modo de selección por el usuario.
             *  
             *  Las celdas se deseleccionan al reestabler su color de fondo como
             *  Color.LightGreen, su color de selección de fondo a SystemColors.Highlight
             *  y color de fuente de selección a SystemColors.HighlightText
             */
            foreach (string asiento in asientosSeleccionados)
            {
                DataGridViewCell celda;
                int fila, columna;
                if ('A' <= asiento[0] && asiento[0] <= 'C')
                {
                    fila = (int)(asiento[1] - '1');
                    columna = (int)(asiento[0] - 'A');
                    celda = gridAsientos.Rows[fila].Cells[columna];
                    celda.Style.BackColor = Color.LightGreen;
                    celda.Style.SelectionBackColor = SystemColors.Highlight;
                    celda.Style.SelectionForeColor = SystemColors.HighlightText;
                }
                else if ('D' <= asiento[0] && asiento[0] <= 'F')
                {
                    fila = (int)(asiento[1] - '1');
                    columna = (int)(asiento[0] - 'D') + 4;
                    celda = gridAsientos.Rows[fila].Cells[columna];
                    celda.Style.BackColor = Color.LightGreen;
                    celda.Style.SelectionBackColor = SystemColors.Highlight;
                    celda.Style.SelectionForeColor = SystemColors.HighlightText;
                }
            }
            asientosSeleccionados.Clear();
            indexActual = 1;
            for (int i = 0; i < displayPasajeros.Length; i++)
            {
                displayPasajeros[i].limpiaAsiento();

            }

            /*  La Check Box está seleccionada, se seleccionan los
             *  asientos de manera aleatoria, se desactiva el grid
             *  para evitar su modificación y se activa el botón para continuar.
             *  El color de fondo de los asientos verde se cambia a Color.LightGreen
             *  solo para mejorar el aspecto del grid.
             */
            if (chkAsientos.Checked)
            {
                escogerAsientos();
                modificarBackSelection(Color.LightGreen);
                gridAsientos.Enabled = false; 
                btnContinuar.Enabled = true;
            }

            /*  La Check Box no está seleccionada, por lo que se reestablecen
             *  los valores predeterminados de las celdas, se activa el grid
             *  y se desactiva el botón.
             */
            else
            {
                modificarBackSelection(SystemColors.Highlight); 
                gridAsientos.Enabled = true;
                btnContinuar.Enabled = false;
            }
            /*  Se modifica el total que debe para el usuario. Ya no debe pagar un precio
             *  extra por los asientos.
             */
            totalEnAsientos = 0;
            lblTotalAPagar.Text = "Total: " + $"${subTotal + totalEnAsientos:N0} MXN";
            lblTotalAPagar.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);
        }


        /// <summary>
        /// Permite modificar la propiedad de BackSelection de las celdas del
        /// gridAsientos. Se utiliza para cambiar el Color.LightGreen a SystemsColors.Highlight
        /// </summary>
        /// <param name="color">Color que se asignará a la propiedad de "Backselection"
        /// </param>
        private void modificarBackSelection(Color color)
        {
            //Hace un recorrido simple del grid y modifica el color por el 
            //color enviado en el argumento.
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    DataGridViewCell celda = gridAsientos.Rows[i].Cells[j];
                    if (celda.Style.BackColor == Color.LightGreen)
                    {
                        celda.Style.SelectionBackColor = color;
                        if (color == SystemColors.Highlight) celda.Style.SelectionForeColor = SystemColors.HighlightText;
                        else celda.Style.SelectionForeColor = Color.Black; 
                    }
                }
            }
        }

        /// <summary>
        /// Método que contiene dos variables que reciben un valor aleatorio para seleccionar
        /// los asientos del avión. Tanto la fila como la columna se eligen de manera aleatoria.
        /// </summary>
        private void escogerAsientos()
        {
            //Limpia la etiqueta que contiene el total a pagar por los asientos y
            //modifica su posición.
            lblTotal.Text = "------";
            lblTotal.Location = new Point(flpPasajeros.Location.X + flpPasajeros.Width - lblTotalAPagar.Width, lblTotalAPagar.Location.Y);
            asientosSeleccionados.Clear(); 

            /*  Se instancia la clase Random() y se recorre la lista de 
             *  pasajeros. Para cada elemento se asignan dos variables
             *  con valores aleatorios. Mientras los dos valores se traduzcan
             *  a un asiento ocupado o no válido para su selección, se vuelven
             *  a generar números.
             *  
             *  Los asientos no válidos para su selección son los que tienen:
             *      1) Fondo IndianRed
             *      2) Fondo Goldenrod
             *      3) O es una de las celdas del pasillo
             */
            Random rd = new Random();
            for (int i = 0; i < totalPasajeros; i++)
            {
                displayPasajeros[i].Precio.Text = "------";
                int fila = rd.Next(0, 8);
                int columna = rd.Next(0, 7);
                DataGridViewCell celda = gridAsientos.Rows[fila].Cells[columna];

                while (celda.Style.BackColor == Color.IndianRed || celda.Style.BackColor == Color.Goldenrod || columna==3)
                {
                    fila = rd.Next(0, 8);
                    columna = rd.Next(0, 7);
                    celda = gridAsientos.Rows[fila].Cells[columna];
                }

                //Una vez se encuentra un asiento libre, se selecciona y asigna
                //al pasajero.
                celda.Style.BackColor = Color.Goldenrod;
                celda.Style.SelectionBackColor = Color.Goldenrod;
                celda.Style.SelectionForeColor = Color.Black;
                char letra = (char)(columna + (int)'A');
                if (columna > 3)
                {
                    letra = (char)((int)(letra-1));
                }
                string asiento = letra.ToString() + (fila + 1).ToString();
                displayPasajeros[i].Asiento.Text = asiento;
                asientosSeleccionados.Add(asiento);
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
        /// Método que marca de color rojo los asientos que ya están ocupados en un
        /// avión. Se hace un recorrido simple de todos los asientos ocupados y se
        /// marcan en el grid con el color correspondiente.
        /// </summary>
        private void marcarAsientosOcupados()
        {
            
            clsDaoDestinos dao =new clsDaoDestinos();
            asientosOcupados = dao.ObtenerAsientos(vueloActual.id);   
            foreach(string asiento in asientosOcupados)
            {
                int shift = 0;
                if ((int)asiento[0] > (int)'C') { shift = 1; }
                DataGridViewCell celda = gridAsientos.Rows[(int)asiento[1] - '0'-1].Cells[(int)asiento[0] - 'A'+ shift];
                celda.Style.BackColor = Color.IndianRed;
                celda.Style.SelectionBackColor = Color.IndianRed;
                celda.Style.SelectionForeColor = Color.Black;
                
            }
        }

        /// <summary>
        /// Getter de la propiedad <c>finalizado</c> de este formulario.
        /// La propiedad finalizado indica si se ha terminado el 
        /// registro de los boletos o aún no se hace el registro.
        /// </summary>
        /// <returns>True: Se ha realizado la venta de los boletos; False: No se realizo</returns>
        public bool getFinalizado()
        {
            return finalizado; 
        }
    }
}
