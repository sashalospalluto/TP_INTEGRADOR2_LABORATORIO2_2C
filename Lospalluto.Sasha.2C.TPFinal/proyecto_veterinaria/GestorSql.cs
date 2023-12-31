﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Excepciones;

namespace proyecto_veterinaria
{
    public static class GestorSql
    {
        private static string stringConnection;

        /// <summary>
        /// Constructor que realiza la conexion a la base de datos
        /// </summary>
        static GestorSql()
        {
            // 16 - Conexion a bases de datos
            GestorSql.stringConnection = "Server=.; Database = tp_final; Trusted_Connection = True";
        }

        /// <summary>
        /// Obtiene todas las mascotas que se encuentran en la BD
        /// </summary>
        /// <returns>Lista con las mascotas encontradas en la BD</returns>
        public static List<Mascota> GetMascotas()
        {
            List<Mascota> mascota= new List<Mascota>();

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            // 15 - Introduccion a SQL
            string sentencia = $"SELECT * FROM mascotas";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Mascota.ETipoMascota tipo = (Mascota.ETipoMascota)Enum.Parse(typeof(Mascota.ETipoMascota), reader["tipo"].ToString());
                    Mascota m = Mascota.NuevaMascota(reader["nombre_mascota"].ToString(), reader["nombre_tutor"].ToString(),int.Parse(reader["edad"].ToString()),tipo, int.Parse(reader["dni_tutor"].ToString()), reader["peso"].ToString());
                    mascota.Add(m);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectarse a la BD, vetifique el stringConnection", ex);
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return mascota;
        }

        /// <summary>
        /// Obtiene todas los medicos que se encuentran en la BD
        /// </summary>
        /// <returns>Lista con los medicos encontrados en la BD</returns>
        public static List<Medico> GetMedicos()
        {
            List<Medico> medicos = new List<Medico>();

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = $"SELECT * FROM doctores";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Medico m = new Medico(reader["nombre"].ToString(), reader["apellido"].ToString(), int.Parse(reader["dni"].ToString()));
                    medicos.Add(m);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return medicos;
        }

        /// <summary>
        /// Guarda una mascota en la BD
        /// </summary>
        /// <param name="mascota">un paciente de tipo Mascota</param>
        /// <returns>true si pudo guardarlo, caso contrario devuelve false</returns>
        public static bool GuardarMascota(Mascota mascota)
        {
            bool guardado=false;

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            //float IMC = 0;
            //string sentencia = $"INSERT INTO mascotas (nombre_mascota, edad, tipo, peso,nombre_tutor,dni_tutor, IMC) VALUES {mascota.Nombre},{mascota.Edad},{mascota.Tipo},{mascota.Peso},{mascota.Nombre_tutor},{mascota.Dni_tutor},{IMC} ";
            string sentencia = $"INSERT INTO mascotas (nombre_mascota, edad, tipo, peso,nombre_tutor,dni_tutor) VALUES (@nombre_mascota,@edad,@tipo,@peso,@nombre_tutor,@dni_tutor)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@nombre_mascota", mascota.Nombre);
                command.Parameters.AddWithValue("@edad", mascota.Edad);
                command.Parameters.AddWithValue("@tipo", mascota.Tipo.ToString());
                command.Parameters.AddWithValue("@peso", mascota.Peso);
                command.Parameters.AddWithValue("@nombre_tutor", mascota.Nombre_tutor);
                command.Parameters.AddWithValue("@dni_tutor", mascota.Dni_tutor);
                //command.Parameters.AddWithValue("@imc", IMC);

                command.ExecuteNonQuery();
                guardado = true;
                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return guardado;
        }

        /// <summary>
        /// Guarda un medico en la BD
        /// </summary>
        /// <param name="medico">un medico de tipo Medico</param>
        /// <returns>true si pudo guardarlo, caso contrario devuelve false</returns>
        public static bool GuardarMedico(Medico medico)
        {
            bool guardado = false;

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            //float IMC = 0;
            //string sentencia = $"INSERT INTO mascotas (nombre_mascota, edad, tipo, peso,nombre_tutor,dni_tutor, IMC) VALUES {mascota.Nombre},{mascota.Edad},{mascota.Tipo},{mascota.Peso},{mascota.Nombre_tutor},{mascota.Dni_tutor},{IMC} ";
            string sentencia = $"INSERT INTO doctores (nombre, apellido, dni) VALUES (@nombre,@apellido,@dni)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@nombre", medico.Nombre);
                command.Parameters.AddWithValue("@apellido", medico.Apellido);
                command.Parameters.AddWithValue("@dni", medico.Dni);

                command.ExecuteNonQuery();
                guardado = true;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return guardado;
        }

        /// <summary>
        /// Modifica el IMC de una mascota en la BD
        /// </summary>
        /// <param name="mascota">mascota a modificar la BD</param>
        /// <returns>true si pudo modificarlo, caso contrario devuelve false</returns>
        public static bool ModificarIMC (Mascota mascota)
        {
            bool modificado = false;

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
          
            string sentencia = $"UPDATE mascotas SET IMC = @imc WHERE dni_tutor = @dni_tutor";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@imc", mascota.CalcularIMC());
                command.Parameters.AddWithValue("@dni_tutor", mascota.Dni_tutor);
                command.ExecuteNonQuery();
                modificado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return modificado;
        }

        /// <summary>
        /// Agrego los datos del medico y el paciente que atendio a la BD
        /// </summary>
        /// <param name="mascota">mascota atendida</param>
        /// <param name="medico">medico que atendio a la mascota</param>
        /// <returns>true si pudo guardarlo, caso contrario devuelve false</returns>
        public static bool IngresarPacienteAtendido (Mascota mascota, Medico medico)
        {
            bool guardado = false;

            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            //float IMC = 0;
            //string sentencia = $"INSERT INTO mascotas (nombre_mascota, edad, tipo, peso,nombre_tutor,dni_tutor, IMC) VALUES {mascota.Nombre},{mascota.Edad},{mascota.Tipo},{mascota.Peso},{mascota.Nombre_tutor},{mascota.Dni_tutor},{IMC} ";
            string sentencia = $"INSERT INTO veterinaria (id_doctor, id_mascota, hora_consulta) VALUES (@id_doctor, @id_mascota, @hora_consulta)";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@id_doctor", GestorSql.GetIdMedico(medico));
                command.Parameters.AddWithValue("@id_mascota", GestorSql.GetIdMascota(mascota));
                command.Parameters.AddWithValue("@hora_consulta", DateTime.Now.ToString());

                command.ExecuteNonQuery();
                guardado = true;

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return guardado;
        }

        /// <summary>
        /// Obtiene el id de la mascota de la BD a partir de una mascota pasada por parametro
        /// </summary>
        /// <param name="mascota">mascota para buscar su id</param>
        /// <returns>devuelve el ID de la mascota encontrada, caso contrario devuelve -1</returns>
        public static int GetIdMascota(Mascota mascota)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "SELECT * FROM mascotas where dni_tutor = @dni";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@dni", mascota.Dni_tutor);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return id;
        }

        /// <summary>
        /// Obtiene el id del medico de la BD a partir de un medico pasado por parametro
        /// </summary>
        /// <param name="medico">medico para buscar su id</param>
        /// <returns>devuelve el ID del medico encontrada, caso contrario devuelve -1</returns>
        public static int GetIdMedico(Medico medico)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);
            string sentencia = "SELECT * FROM doctores where dni = @dni";

            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@dni", medico.Dni);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return id;
        }
    }
}
