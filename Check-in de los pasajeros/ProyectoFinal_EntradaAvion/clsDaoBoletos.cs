using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 


namespace ProyectoFinal_EntradaAvion
{
    /// <summary>
    /// Permite la comunicación con los datos de la base de datos "aeropuerto"
    /// </summary>
    public class clsDaoBoletos
    {
        private readonly string conexion =
            "server=localhost;database=aeropuerto;uid=root;pwd=whythough.210;";

        /// <summary>
        /// Método que consulta la información de los pasajeros/clientes que registrados
        /// en un vuelo determinado.
        /// </summary>
        /// <param name="id_vuelo">ID del vuelo</param>
        /// <returns>Retorna una lista de pasajeros registrados a un vuelo.</returns>
        /// <exception cref="ApplicationException">Ocurrió un error al consultar los registros de la tabla <c>boletos</c> dentro de la base de datos.</exception>
        public List<Cliente> ObtenerClientes(int id_vuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                
                string query = "SELECT id_boleto, nombre, a_paterno, a_materno, asiento, checked_in FROM " +
                    "boletos WHERE id_vuelo=@id_vuelo";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_vuelo", id_vuelo);

                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();

                //LISTA DE PRODUCTOS A REGRESAR
                List<Cliente> clientes = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.id_boleto = reader.GetString(0); //Columna 0 del primer renglón
                    cliente.nombre=reader.GetString(1);
                    cliente.a_paterno = reader.GetString(2);
                    cliente.a_materno = reader.GetString(3);
                    cliente.asiento = reader.GetString(4); //Columna 1
                    cliente.checked_in = reader.GetBoolean(5); //Columna 2
                    
                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al insertar el producto" +
                    " en la base de datos", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al " +
                    "insertar el producto.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Método de actualiza el estado "checked_in" dentro de la base de datos. 
        /// Esto indica que el pasajero a llegado y abordado al avión.
        /// </summary>
        /// <param name="id_boleto">ID del boleto (código barras del boleto)</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException">Ocurrió un error al hacer la modificación del atributo checked_in</exception>
        public bool ActualizarCheck_In(string id_boleto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "UPDATE boletos SET checked_in=true WHERE id_boleto=@id_boleto;";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_boleto", id_boleto);

                //Línea que hace el insert
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al actualizar el producto" +
                    " en la base de datos", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al " +
                    "actualizar el producto.", ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

            }
        }

        /// <summary>
        /// Método que consulta y recupera todos los registros de la tabla de 
        /// <c>vuelos</c> en la base de datos.
        /// </summary>
        /// <returns>Retorna una lista con los registros de la tabla <c>vuelos</c></returns>
        /// <exception cref="ApplicationException">Ocurrió un error al obtener los registros de la tabla <c>vuelos</c> en la base de datos</exception>
        public List<Vuelo> ObtenerVuelos()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT id_vuelo, fecha, ciudad, embarque FROM vuelos NATURAL JOIN destinos";

                cmd = new MySqlCommand(query, conn);

      


                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();


                //LISTA DE PRODUCTOS A REGRESAR
                List<Vuelo> vuelos = new List<Vuelo>();

                while (reader.Read())
                {
                    Vuelo vuelo = new Vuelo();
                    vuelo.id = reader.GetInt32(0); //Columna 0 del primer renglón
                    vuelo.fecha = reader.GetDateTime(1); //Columna 1
                    vuelo.ciudad = reader.GetString(2); //Columna 2
                    vuelo.embarque = reader.GetString(3); //Columna 3
                    vuelos.Add(vuelo);
                }
                return vuelos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al realizar la consulta" +
                    " en la base de datos", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al " +
                    "consultar en la tabla productos.", ex);
            }
            finally
            {
                cmd.Dispose(); //Libera los recursos asociados al comando
                if (reader != null) reader.Close(); //Cierra reader
                if (reader != null) reader.Dispose(); //Libera recursos del reader
                conn.Close(); //Se cierra la conexión 
                conn.Dispose(); //Se liberan los recursos de la conexión

            }
        }
    }
}
