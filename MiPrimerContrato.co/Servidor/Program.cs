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
using Clases;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener servidor = new TcpListener(IPAddress.Parse("0.0.0.0"), 8090);
            Console.WriteLine("Iniciando...");
            while (true)
            {
                servidor.Start();
                Console.WriteLine("Esperando cliente...");
                ManejoCliente cliente = new ManejoCliente(servidor.AcceptTcpClient());
                cliente.ProcesarDatos();
            }
        }

        class ManejoCliente
        {
            private Stream flujoDatos;
            private TcpClient cliente;
            StreamReader lector;
            StreamWriter escritor;

            public ManejoCliente(TcpClient cliente)
            {
                this.cliente = cliente;
                flujoDatos = cliente.GetStream();
            }

            public void ProcesarDatos()
            {
                try
                {
                    Console.WriteLine("Se está atendiendo a un cliente...");
                    flujoDatos = cliente.GetStream();
                    lector = new StreamReader(flujoDatos);
                    escritor = new StreamWriter(flujoDatos);
                    BinaryFormatter bf = new BinaryFormatter();

                    // Se recibe el objeto Persona Serializado por parte del usuario
                    Persona persona = (Persona)(bf.Deserialize(flujoDatos));

                    // Validación del tipo de solicitud por parte del usuario
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
                            Console.WriteLine("Respuesta enviada...");
                            break;

                        // Caso 2 para realizar el proceso de consulta de una persona en la base de datos
                        case "consulta":
                            // Ejecución de la consulta hacia la base de datos
                            persona = ConexionBaseDeDato.ConsultarPersona(persona.Cedula);

                            // Se envia el objeto Persona al cliente de forma Serializada
                            bf.Serialize(cliente.GetStream(), persona);
                            Console.WriteLine("Respuesta enviada...");
                            break;
                        case "cantidad":
                            string cantidad = ConexionBaseDeDato.ConsultarCantidadContratados(persona.TipoPersonal);
                            escritor.WriteLine(cantidad);
                            escritor.Flush();
                            Console.WriteLine("Respuesta enviada...");
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
