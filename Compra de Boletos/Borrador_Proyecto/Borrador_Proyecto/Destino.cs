using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Clase que almacena los datos de los destinos. Almacena:
    ///     1) ID del destino
    ///     2) Nombre del destino
    ///     3) La duración del vuelo
    ///     4) La dirección donde se guarda su imagen representativa
    /// </summary>
    public class Destino
    {
        /// <summary>
        /// ID del destino
        /// </summary>
        public int id {  get; set; }

        /// <summary>
        /// Nombre del destino
        /// </summary>
        public string nombre { get; set; }


        /// <summary>
        /// Duración de cualquier vuelo dirigido al destino
        /// </summary>
        public TimeSpan duracion { get; set; }

        /// <summary>
        /// Dirección de la imagen asociada al destino
        /// </summary>
        public string direccionImagen { get; set; }

    }
}
