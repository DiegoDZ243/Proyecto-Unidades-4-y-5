using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Clase que almacena los datos de un boleto. Almacena:
    ///     1) ID del boleto
    ///     2) Nombre del pasajero
    ///     3 y 4) Apellido paterno y materno
    ///     5) Número de asiento
    ///     6) Si ha abordado o no al vuelo
    /// </summary>
   
    public class Cliente
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Cliente() { }
        
        /// <summary>
        /// ID del boleto
        /// </summary>
        public string id_boleto { get; set; }

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
        /// Atributo que guarda si el pasajero está abordo o no
        /// </summary>
        public bool checked_in { get; set; }
        
        /// <summary>
        /// Método de concatena el nombre, apellido paterno y materno de un cliente
        /// </summary>
        /// <returns>Retorna el nombre completo del cliente</returns>
        public string getNombreCompleto()
        {
            return nombre + " " + a_paterno + " " + a_materno; 
        }

    }
}
