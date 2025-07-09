using BarcodeLib;
using MisControles;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Permite la impresión de los boletos generados 
    /// para cada pasajero.
    /// </summary>
    public partial class frmImprimeBoletos : Form
    {
        //Atributo que almacena si se ha completado la venta de los boletos
        private bool finalizado=false; 
        //Almacena el formulario padre de este
        private frmBoletos formPadre; 
        //Almacena los boletos generados en el formulario padre
        private interfazBoleto[] boletos;
        //Index del boleto actual a imprimir
        private int currIndex = 0;
        //Coordenadas donde se imprimirán los boletos
        private int x, y = 10;

        /// <summary>
        ///  Constructor del formulario que inicializa las variables globales que se
        ///  necesitarán para generar los boletos y hacer la impresión correcta. 
        ///  También modifica la posición relativa de los componentes del form.
        /// </summary>
        /// <param name="padre">Form padre del actual</param>
        /// <param name="boletos">Arreglo con los boletos generados</param>
        public frmImprimeBoletos(frmBoletos padre,interfazBoleto[] boletos)
        {
            InitializeComponent();
            this.formPadre = padre;
            this.boletos = boletos;
            mostrarBoletos(); 
            btnImprimir.Location = new Point((this.ClientSize.Width - btnImprimir.Width) / 3, y);
            btnFinalizar.Location = new Point(2 * (this.ClientSize.Width - btnFinalizar.Width) / 3, y);
            btnImprimir.Image = Properties.Resources.icn_impresora.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            btnFinalizar.Image = Properties.Resources.icn_finalizar.GetThumbnailImage(30, 30, null, IntPtr.Zero);
        }

        /// <summary>
        /// Este método convierte los paneles de la interfaz boleto a imágenes
        /// que pueden imprimirse en mejor calidad.
        /// </summary>
        private void mostrarBoletos()
        {
            int y = 10;
            foreach (interfazBoleto b in boletos)
            {
                Bitmap bmp = new Bitmap(b.Boleto.Width, b.Boleto.Height);
                b.Boleto.DrawToBitmap(bmp, new Rectangle(0, 0, b.Boleto.Width, b.Boleto.Height));
                //Se asigna la imagen generada a una Picture Box generada dinámicamente
                PictureBox picture = new PictureBox();
                picture.SizeMode = PictureBoxSizeMode.AutoSize;
                picture.Image = bmp;
                //Se centra en el formulario
                x = (this.ClientSize.Width - bmp.Width) / 2;
                picture.Location = new Point(x, y);
                //Se añade al formulario
                this.Controls.Add(picture);
                //Se actualiza la coordenada y
                y += picture.Height + 100;
            }
            this.y = y;
        }

        /// <summary>
        /// Permite imprimir los boletos mostrados en el formulario. Establece las
        /// dimensiones del documento y permite hacer la preview del mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Documento que se imprimirá
            PrintDocument pd = new PrintDocument();
            //SE VA A PREPARAR EL DOCUMENTO CON EL MÉTODO
            pd.PrintPage += new PrintPageEventHandler(imprimirBoleto);
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 1000,
                Height = 800
            };
            preview.ShowDialog();
        }

        /// <summary>
        /// Método que adapta las imágenes de los boletos al documento que se
        /// imprimirá. Hace un escalado del mismo para mejorar su calidad y no se
        /// perciba tan borroso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imprimirBoleto(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            //Generar código de barras con BarcodeLib

            int posY = 10;
            while(currIndex< boletos.Length)
            {
                Panel pnlBoleto = boletos[currIndex].Boleto; 
                // Captura el panel como está (sin dpiFactor extra)
                Bitmap bmp = new Bitmap(pnlBoleto.Width, pnlBoleto.Height);
                pnlBoleto.DrawToBitmap(bmp, new Rectangle(0, 0, pnlBoleto.Width, pnlBoleto.Height));

                // Calcular escala proporcional
                float scale = Math.Min(
                    (float)e.MarginBounds.Width / bmp.Width,
                    (float)e.MarginBounds.Height / bmp.Height
                );

                int newWidth = (int)(bmp.Width * scale);
                int newHeight = (int)(bmp.Height * scale);

                // Centrar en el área imprimible
                int posX = e.MarginBounds.Left + (e.MarginBounds.Width - newWidth) / 2;
                if(posY + newHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    bmp.Dispose();
                    return; 
                }

                // Escalar suavemente y dibujar
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                e.Graphics.DrawImage(bmp, posX, posY, newWidth, newHeight);
                posY += newHeight + 50; 

                bmp.Dispose();
                currIndex++; 
            }
            e.HasMorePages = false;
            currIndex = 0;
        }

        /// <summary>
        /// Evento que permite regresar al menú principal directamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            finalizado = true;
            this.Close();  
        }

        /// <summary>
        /// Avisa que cuando este formulario sea cerrado, en lugar de un cerrado
        /// normal, se regresará directamente al menú principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmImprimeBoletos_FormClosed(object sender, FormClosedEventArgs e)
        {
            finalizado = true; 
        }

        /// <summary>
        /// Evento que se activa al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmImprimeBoletos_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Getter de la propiedad finalizado.
        /// Avisa si se ha terminado el registro de los 
        /// boletos de manera exitosa.
        /// </summary>
        /// <returns></returns>
        public bool getFinalizado()
        {
            return finalizado; 
        }
    }
}
