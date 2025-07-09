using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Clase que almacena los datos de un boleto. Almacena:
    ///     1) ID del boleto
    ///     2) Nombre del pasajero
    ///     3 y 4) Apellido paterno y materno
    ///     5) Número de asiento
    ///     6) Si ha abordado o no al vuelo
    ///     7) ID del vuelo asociado
    /// </summary>
    public class Boleto
    {
        /// <summary>
        /// ID del boleto
        /// </summary>
        public string id_boleto {  get; set; }

        /// <summary>
        /// Nombre del pasajero
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Apellido paterno del pasajero
        /// </summary>
        public string a_paterno { get; set; }

        /// <summary>
        /// Apellido materno del pasajero
        /// </summary>
        public string a_materno { get; set; }

        /// <summary>
        /// Asiento asociado al pasajero
        /// </summary>
        public string asiento { get; set; }

        /// <summary>
        /// Atributo que indica si el pasajero ha abordado al vuelo o no
        /// </summary>
        public bool check_in {  get; set; }

        /// <summary>
        /// ID del vuelo asociado al boleto
        /// </summary>
        public int id_vuelo { get; set; }

    }
}
