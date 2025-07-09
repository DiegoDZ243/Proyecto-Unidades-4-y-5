using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Tsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_Proyecto
{
    /// <summary>
    /// Permite la consulta de datos en la base datos aeropuerto en MySQL
    /// </summary>
    public class clsDaoDestinos
    {
        private readonly string conexion =
            "server=localhost;database=aeropuerto;uid=root;pwd=whythough.210;";

        /// <summary>
        /// Método que consulta todos los registros de la tabla <c>destinos</c> dentro de la
        /// base de datos. 
        /// </summary>
        /// <returns>Una lista con los registros de la tabla <c>destinos</c></returns>
        /// <exception cref="ApplicationException">Ocurrió un error al obtener los registros de la tabla <c>destinos</c></exception>
        public List<Destino> ObtenerDestinos()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM destinos";

                cmd = new MySqlCommand(query, conn);

                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();

                //LISTA DE PRODUCTOS A REGRESAR
                List<Destino> destinos = new List<Destino>();

                while (reader.Read())
                {
                    Destino destino = new Destino();
                    destino.id = reader.GetInt32(0); //Columna 0 del primer renglón
                    destino.nombre = reader.GetString(1); //Columna 1
                    destino.duracion = reader.GetTimeSpan(2); //Columna 2
                    destino.direccionImagen = reader.GetString(3); 
                    destinos.Add(destino);
                }
                return destinos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al consultar los destinos" +
                    " en la base de datos", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al " +
                    "insertar el producto.", ex);
            }
            finally
            {
                cmd.Dispose(); //Libera los recursos asociados al comando
                reader.Close(); //Cierra reader
                reader.Dispose(); //Libera recursos del reader
                conn.Close(); //Se cierra la conexión 
                conn.Dispose(); //Se liberan los recursos de la conexión

            }
        }

        /// <summary>
        /// Método que retorna una lista de vuelos que salen a una fecha determinada, tiene
        /// un cupo mayor o igual número de pasajeros específicado y que van hacia el destino
        /// indicado.
        /// </summary>
        /// <param name="id_destino">Identificador del destino del vuelo</param>
        /// <param name="fecha">Fecha a la que saldrá el vuelo</param>
        /// <param name="pasajeros">Pasajeros que abordarán el vuelo</param>
        /// <returns>Una lista de los vuelos dentro de la tabla <c>vuelos</c> que cumplen con los parámetros</returns>
        /// <exception cref="ApplicationException">Ocurrió un error al obtener los registros de la tabla <c>vuelos</c></exception>
        public List<Vuelo> ConsultaVuelos(int id_destino, DateTime fecha, int pasajeros)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                
                string query = "SELECT* FROM vuelos NATURAL JOIN destinos WHERE id_destino = @id_destino AND fecha = @fecha AND cupo>= @pasajeros";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_destino", id_destino);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@pasajeros", pasajeros);


                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();


                //LISTA DE PRODUCTOS A REGRESAR
                List<Vuelo> vuelos = new List<Vuelo>();

                while (reader.Read())
                {
                    Vuelo vuelo = new Vuelo();
                    vuelo.id = reader.GetInt32(1); //Columna 0 del primer renglón
                    vuelo.fecha = reader.GetDateTime(2); //Columna 1
                    vuelo.hora_salida = reader.GetTimeSpan(3); //Columna 2
                    vuelo.embarque = reader.GetString(4); //Columna 3
                    vuelo.precio = reader.GetDecimal(5); //Columna 4
                    vuelo.cupo = reader.GetInt32(6); //Columna 0 del primer renglón
                    vuelo.destino = reader.GetString(7);
                    vuelo.duracion = reader.GetTimeSpan(8); 
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

        /// <summary>
        /// Método que consulta los vuelos que se dirigen a un destino determinado, tienen un cupo mayor o
        /// igual que número de pasajeros específicados y salen en la fecha específicada o una fecha
        /// después a la dada en el parametro.
        /// </summary>
        /// <param name="id_destino">Identificador del destino del vuelo</param>
        /// <param name="fecha">Límite inferior de la búsqueda de fechas de vuelos</param>
        /// <param name="pasajeros">Pasajeros que abordarán el vuelo</param>
        /// <returns>Una lista de los vuelos dentro de la tabla <c>vuelos</c> que cumplen con los parámetros</returns>
        /// <exception cref="ApplicationException">Ocurrió un error al obtener los registros de la tabla <c>vuelos</c></exception>
        public List<Vuelo> ConsultaVuelosPorDestino(int id_destino, DateTime fecha, int pasajeros)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT* FROM vuelos NATURAL JOIN destinos WHERE id_destino = @id_destino AND fecha >= @fecha AND cupo>= @pasajeros";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_destino", id_destino);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@pasajeros", pasajeros);


                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();


                //LISTA DE PRODUCTOS A REGRESAR
                List<Vuelo> vuelos = new List<Vuelo>();

                while (reader.Read())
                {
                    Vuelo vuelo = new Vuelo();
                    vuelo.id = reader.GetInt32(1); //Columna 0 del primer renglón
                    vuelo.fecha = reader.GetDateTime(2); //Columna 1
                    vuelo.hora_salida = reader.GetTimeSpan(3); //Columna 2
                    vuelo.embarque = reader.GetString(4); //Columna 3
                    vuelo.precio = reader.GetDecimal(5); //Columna 4
                    vuelo.cupo = reader.GetInt32(6); //Columna 0 del primer renglón
                    vuelo.destino = reader.GetString(7);
                    vuelo.duracion = reader.GetTimeSpan(8);
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

        /// <summary>
        /// Método que recupera los asientos ocupados en un vuelo específico.
        /// </summary>
        /// <param name="id_vuelo">Identificador del destino del vuelo</param>
        /// <returns>Una lista de strings que representa los asientos ocupados en el avión</returns>
        /// <exception cref="ApplicationException">Ocurrió un error al obtener los asientos del vuelo</exception>
        public List<string> ObtenerAsientos(int id_vuelo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT asiento FROM boletos WHERE id_vuelo = @id_vuelo";

                

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_vuelo", id_vuelo);

                //Objeto reader con los datos de la tabla
                reader = cmd.ExecuteReader();

                //LISTA DE PRODUCTOS A REGRESAR
                List<string> asientos = new List<string>();

                while (reader.Read())
                {
                    string asiento=reader.GetString(0);
                    asientos.Add(asiento);
                }
                return asientos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException("Error al consultar los destinos" +
                    " en la base de datos", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al " +
                    "insertar el producto.", ex);
            }
            finally
            {
                cmd.Dispose(); //Libera los recursos asociados al comando
                reader.Close(); //Cierra reader
                reader.Dispose(); //Libera recursos del reader
                conn.Close(); //Se cierra la conexión 
                conn.Dispose(); //Se liberan los recursos de la conexión

            }
        }

        /// <summary>
        /// Método que inserta una lista de boletos a la tabla <c>boletos</c> dentro
        /// de la base de datos.
        /// </summary>
        /// <param name="boletos">Arreglo de los boletos que se registrarán</param>
        /// <returns><c>True:</c> Se insertaron correctamente los boletos; <c>False:</c> No se insertaron corectamente</returns>
        /// <exception cref="ApplicationException">Ocurrió un error durante la inserción de los nuevos registros en la tabla <c>boletos</c></exception>
        public bool InsertarBoletos(Boleto[] boletos)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();
                for (int i = 0; i < boletos.Length; i++)
                {
                    Boleto boleto= boletos[i];
                    string query = "INSERT INTO boletos (id_boleto, nombre, a_paterno, a_materno, asiento, checked_in, id_vuelo) " +
                        "VALUES (@id_boleto, @nombre, @a_paterno, @a_materno, @asiento, @checked_in, @id_vuelo)";

                    cmd = new MySqlCommand(query, conn);

                    //cmd.Parameters.AddWithValue("@id", producto.id);
                    cmd.Parameters.AddWithValue("@id_boleto", boleto.id_boleto);
                    cmd.Parameters.AddWithValue("@nombre", boleto.nombre);
                    cmd.Parameters.AddWithValue("@a_paterno", boleto.a_paterno);
                    cmd.Parameters.AddWithValue("@a_materno", boleto.a_materno);
                    cmd.Parameters.AddWithValue("@asiento", boleto.asiento);
                    cmd.Parameters.AddWithValue("@checked_in", boleto.check_in);
                    cmd.Parameters.AddWithValue("@id_vuelo", boleto.id_vuelo);
                    //Línea que hace el insert
                    cmd.ExecuteNonQuery();
                }
                return true;
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
        /// Método que actualiza el cupo de un vuelo, restando la cantidad de boletos 
        /// vendidos.
        /// </summary>
        /// <param name="vuelo">Objeto de la clase Vuelo que contiene la información básica del mismo</param>
        /// <param name="vendidos">Cantidad de boletos vendidos</param>
        /// <returns><c>True: </c>Se realizó la actualización correctamente; <c>False: </c>No se realizó la actualización</returns>
        /// <exception cref="ApplicationException">Ocurrió un error durante la actualización del cupo del vuelo</exception>
        public bool ActualizarCupo(Vuelo vuelo, int vendidos)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "UPDATE vuelos SET cupo=@cupo WHERE id_vuelo=@id_vuelo;";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cupo", vuelo.cupo-vendidos);
                cmd.Parameters.AddWithValue("@id_vuelo", vuelo.id);

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
    }
}
