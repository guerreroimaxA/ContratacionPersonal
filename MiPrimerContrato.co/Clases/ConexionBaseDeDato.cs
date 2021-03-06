﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Clases
{
    // Clase usada para el manejo de datos en la base de datos
    public class ConexionBaseDeDato
    {
        // Este método permite obtener la conexión hacia la base de datos
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=ALEJANDRO-VAIO;Initial Catalog=dbMiPrimerContrato;Integrated Security=True");

                // Se valida si la conexión está cerrada para proceder a abrirla
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                return conexion;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        // Método que permite cerrar la conexión hacia la base de datos
        public static void cerrarConexion(SqlConnection conexion)
        {
            try
            {
                // Se valida si la conexión se encuentra abierta para proceder a cerrarla
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Método para agregar un nuevo personal para la contración
        // Devuelve un valor booleano y un mensaje para verificar el correcto ingreso del registro
        public static Tuple<bool, string> AgregarPersonal(Persona persona)
        {
            try
            {
                // Obtener la conexión a la base de datos
                SqlConnection conexion = ObtenerConexion();

                // QUERY para verificar si existe la persona registrada
                string query = "SELECT * FROM tblPersona WHERE cedula = '" + persona.Cedula + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                // Si la persona existe, se informa al usuario
                if (reader.HasRows)
                {
                    reader.Close();
                    cerrarConexion(conexion);
                    return Tuple.Create(false, "No se pudo iniciar el proceso. La persona ya existe");
                }
                else
                {
                    // Si la persona no existe, se ingresan sus datos para el proceso de contratación
                    reader.Close();
                    query = "INSERT INTO tblPersona VALUES ('" + persona.Cedula + "', '" + persona.Nombre + "', '" + persona.Apellido + "', '" + persona.TipoPersonal + "', '" + persona.Departamento + "', '" + persona.Titulo + "', '" + persona.Estado + "')";
                    comando = new SqlCommand(query, conexion);

                    // Validación de que los datos hayan sido ingresados
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        cerrarConexion(conexion);
                        return Tuple.Create(true, "Registro ingresado con éxito.");
                    }
                    cerrarConexion(conexion);
                    return Tuple.Create(false, "Error al ingresar los datos.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Tuple.Create(false, "Error al ingresar los datos.");
            }
        }

        // Método que permite consultar si existe una persona registrada en el proceso de contratación
        public static Persona ConsultarPersona(string cedula)
        {
            Persona persona = new Persona();
            SqlConnection conexion = ObtenerConexion();

            // Realiza una consulta en la base de datos de acuerdo al número de cédula
            string query = "SELECT * FROM tblPersona WHERE cedula = '" + cedula + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                SqlDataReader reader = comando.ExecuteReader();
                
                // Si existe la persona en la base de datos, se obtienen todos los campos asociados
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        persona.Cedula = reader.GetString(0);
                        persona.Nombre = reader.GetString(1);
                        persona.Apellido = reader.GetString(2);
                        persona.TipoPersonal = reader.GetString(3);
                        persona.Departamento = reader.GetString(4);
                        persona.Titulo = reader.GetString(5);
                        persona.Estado = reader.GetString(6);
                    }
                    reader.Close();
                    cerrarConexion(conexion);
                    return persona;
                }
                // Si la persona no existe se devolvera el objeto sin valores
                else
                {
                    reader.Close();
                    cerrarConexion(conexion);
                    return persona;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cerrarConexion(conexion);
                return persona;
            }
        }

        // Método para consultar la cantidad de personas Contratadas por Tipo de Personal
        public static string ConsultarCantidadContratados(string tipoPersonal)
        {
            SqlConnection conexion = ObtenerConexion();
            string cantidad = "0";
            string query = "SELECT COUNT(tipoPersonal) FROM tblPersona WHERE tipoPersonal = '" + tipoPersonal + "' AND estado = 'CONTRATADO'";
            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cantidad = Convert.ToString(reader.GetInt32(0));
                    reader.Close();
                    cerrarConexion(conexion);
                    return cantidad;
                }
                reader.Close();
                cerrarConexion(conexion);
                return cantidad;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cerrarConexion(conexion);
                return cantidad;
            }
        }

        // Método para guardar el documento PDF en la base de datos enviado por un usuario 
        public static string GuardarPDF(Persona persona)
        {
            string query = "INSERT INTO tblDocumento (cedulaPersona, documentoPDF) VALUES (@cedula, @documento)";
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;

                        // Se añade los parámetros en la consulta para la base de datos para guardar el PDF
                        comando.Parameters.AddWithValue("@cedula", persona.Cedula);
                        comando.Parameters.AddWithValue("@documento", persona.Documento);
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            // Una vez ingresado el documento, se procede a actualizar el estado del usuario
                            query = "UPDATE tblPersona SET estado = 'ENTREGA_DOCUMENTOS' WHERE cedula = '" + persona.Cedula + "'";
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                if(cmd.ExecuteNonQuery() > 0)
                                {
                                    cerrarConexion(conexion);
                                    return "Documento ingresado con éxito";
                                }
                            }
                        }
                        cerrarConexion(conexion);
                        return "Error al guardar el documento";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error al guardar el documento";
            }
        }

        // Método para actualizar el estado de la persona cuando se le pregunta si desea ser contratado
        public static string ActualizarEstado(string estado, string cedulaPersona)
        {
            SqlConnection conexion = ObtenerConexion();
            string query = "UPDATE tblPersona SET estado = '" + estado + "' WHERE cedula = '" + cedulaPersona + "'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                if (comando.ExecuteNonQuery() > 0)
                {
                    cerrarConexion(conexion);
                    return "Proceso de contratación terminado";
                }
                cerrarConexion(conexion);
                return "Proceso de contratación terminado";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error al finalizar el proceso de contratación";
            }
        }
    }
}
