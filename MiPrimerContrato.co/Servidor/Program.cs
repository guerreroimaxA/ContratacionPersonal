using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Clases;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto TCP para escuchar por peticiones
            TcpListener servidor = new TcpListener(IPAddress.Parse("0.0.0.0"), 8090);
            Console.WriteLine("Ejecutando servidor...");
            while (true)
            {
                // El servidor empieza a escuchar por solicitudes
                servidor.Start();
                Console.WriteLine("Esperando cliente...");

                // Llegada de un cliente
                ManejoCliente cliente = new ManejoCliente(servidor.AcceptTcpClient());

                // El servidor comienza a procesar la solicitud del cliente mediante hilos
                Thread hiloProcesoDatos = new Thread(cliente.ProcesarDatos);
                hiloProcesoDatos.Start();
            }
        }

        // Clase para manejar al cliente
        class ManejoCliente
        {
            // Variable que permite obtener el flujo de datos del cliente
            private Stream flujoDatos;
            private TcpClient cliente;
            StreamReader lector;
            StreamWriter escritor;
            string mensajeRetorno;

            // Constructor de la clase que instancia al cliente TCP
            public ManejoCliente(TcpClient cliente)
            {
                this.cliente = cliente;
                flujoDatos = cliente.GetStream();
                lector = new StreamReader(flujoDatos);
                escritor = new StreamWriter(flujoDatos);
            }

            // Método de la clase para procesar los datos recibidos por parte del cliente
            public void ProcesarDatos()
            {
                try
                {
                    Console.WriteLine("Se está atendiendo a un cliente...");

                    // Instanciación de un objeto BinaryFormatter para Deserializar el objeto Persona recibido del cliente
                    BinaryFormatter bf = new BinaryFormatter();

                    // Se recibe el objeto Persona Serializado por parte del usuario y se lo deserializa
                    Persona persona = (Persona)(bf.Deserialize(flujoDatos));

                    // Validación del tipo de solicitud que desea ejecutar el cliente en base al campo comando del objeto Persona
                    switch (persona.Comando)
                    {
                        // Caso 1 para iniciar un nuevo proceso de contratación
                        case "nuevo":
                            // Impresión del objeto Persona recibido por el usuario
                            Console.WriteLine(persona.ToString());

                            // Ejecución del método para ingresar los nuevos datos del usuario
                            var retorno = ConexionBaseDeDato.AgregarPersonal(persona);

                            // Se imprime los valores devueltos de la ejecución de la base de datos
                            Console.WriteLine("{0} - {1}", retorno.Item1, retorno.Item2);

                            // Envia el mensaje al cliente
                            escritor.WriteLine(retorno.Item2);
                            escritor.Flush();
                            Console.WriteLine("Respuesta enviada al cliente...");
                            break;

                        // Caso 2 para realizar el proceso de consulta de una persona en la base de datos
                        case "consulta":
                            // Ejecución de la consulta hacia la base de datos en base al número de cédula
                            persona = ConexionBaseDeDato.ConsultarPersona(persona.Cedula);

                            // Envía el objeto Persona al cliente de forma Serializada con la respuesta desde la base de datos
                            bf.Serialize(cliente.GetStream(), persona);
                            Console.WriteLine("Respuesta enviada al cliente...");
                            break;
                        
                        // Caso 3 para consultar la cantidad de personas Contratadas junto con el Tipo de Personal
                        case "cantidad":
                            // Ejecución de la consulta hacia la base de datos por el Tipo de Personal
                            string cantidad = ConexionBaseDeDato.ConsultarCantidadContratados(persona.TipoPersonal);

                            // Se envía la cantidad de personas consultadas al cliente
                            escritor.WriteLine(cantidad);
                            escritor.Flush();
                            Console.WriteLine("Respuesta enviada al cliente...");
                            break;
                        
                        // Caso 4 para guardar el documento PDF en la base de datos enviado por el cliente
                        case "guardarpdf":
                            // Ejecución del método para guardar el PDF en la base de datos
                            mensajeRetorno = ConexionBaseDeDato.GuardarPDF(persona);

                            // Se envía el mensaje devuelto del servidor hacia la base de datos
                            escritor.WriteLine(mensajeRetorno);
                            escritor.Flush();
                            Console.WriteLine("Respuesta enviada al cliente...");
                            break;
                        
                        // Caso 5 para realizar el último proceso de contratación y modificar el estado del cliente en la base de datos
                        case "contratar":
                            // Actualización del estado del cliente de acuerdo a la respuesta del mismo
                            mensajeRetorno = ConexionBaseDeDato.ActualizarEstado(persona.Estado, persona.Cedula);

                            // Se envía el mensaje devuelto del servidor hacia la base de datos
                            escritor.WriteLine(mensajeRetorno);
                            escritor.Flush();
                            Console.WriteLine("Respuesta enviada al cliente...");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
