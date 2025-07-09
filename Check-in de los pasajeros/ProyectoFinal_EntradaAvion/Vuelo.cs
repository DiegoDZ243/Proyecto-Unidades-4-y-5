using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Clase que representa los datos de un vuelo. Almacena:
    ///     1) Su ID
    ///     2) La fecha de salida
    ///     3) La hora de salida
    ///     4) Lugar donde se deberá tomar el avión
    ///     5) Su precio
    ///     6) Cupo actual (asientos disponibles)
    ///     7) El destino del vuelo
    ///     8) La duración del vuelo
    /// </summary>
    public class Vuelo
    {
        /// <summary>
        /// ID del vuelo
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Fecha de salida del vuelo
        /// </summary>
        public DateTime fecha { get; set; }
        
        /// <summary>
        /// Destino del vuelo
        /// </summary>
        public string ciudad {  get; set; }

        /// <summary>
        /// Lugar de abordaje del vuelo
        /// </summary>
        public string embarque { get; set; }
       
    }
}
