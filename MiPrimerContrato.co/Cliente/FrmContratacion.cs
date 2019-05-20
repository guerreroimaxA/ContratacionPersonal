using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Clases;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cliente
{
    public partial class FrmContratacion : Form
    {
        TcpClient usuario;
        StreamReader lector;
        StreamWriter escritor;
        IPEndPoint remoto;
        Persona persona;
        string mensajeRecibido;
        public FrmContratacion()
        {
            InitializeComponent();
        }

        // Evento que se desencadena para enviar los datos del usuario al iniciar un nuevo proceso de contratación
        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            // No se pueden eviar los datos si hay campos vacíos.
            if(txtCedula.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (txtApellido.Text != "")
                    {
                        if (cbxDepartamento.Text != "")
                        {
                            if (txtTitulo.Text != "")
                            {
                                if (cbxTipo.Text != "")
                                {
                                    try
                                    {
                                        // Definición de la conexión remota con el servidor
                                        remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                                        usuario = new TcpClient();
                                        usuario.Connect(remoto);
                                        lector = new StreamReader(usuario.GetStream());
                                        escritor = new StreamWriter(usuario.GetStream());

                                        // Se instancia una persona con la solicitud "nuevo" para ingresar a la base de datos
                                        persona = new Persona("nuevo", txtCedula.Text, txtNombre.Text, txtApellido.Text, cbxTipo.Text, cbxDepartamento.Text, txtTitulo.Text, "SOLICITADO");

                                        // Instanciación de un objeto BinaryFormatter para Serializar el objeto Persona
                                        BinaryFormatter bf = new BinaryFormatter();

                                        // Serialización del objeto para enviarlo al servidor
                                        bf.Serialize(usuario.GetStream(), persona);

                                        // Lectura del mensaje recibido por parte del servidor
                                        mensajeRecibido = lector.ReadLine();
                                        MessageBox.Show(mensajeRecibido, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        TerminarProceso();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    finally
                                    {
                                        escritor.Close();
                                        lector.Close();
                                        usuario.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Porfavor seleccione el Tipo.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Porfavor ingrese el Título.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Porfavor seleccione el Departamento.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porfavor ingrese su Apellido.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor ingrese su Nombre.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese su número de cédula.", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Método para limpiar los textos y bloquearlos
        private void TerminarProceso()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTitulo.Text = "";
            txtEstado.Text = "";
            txtNombreDocumento.Text = "";
            cbxTipo.Text = "";
            cbxDepartamento.Text = "";
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTitulo.Enabled = false;
            txtEstado.Enabled = false;
            cbxTipo.Enabled = false;
            cbxDepartamento.Enabled = false;
            btnEnviarDatos.Enabled = false;
            btnCargarDocumento.Enabled = false;
            btnEnviarDocumento.Enabled = false;
            txtNombreDocumento.Enabled = false;
        }

        // Evento para buscar una persona en particular
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se valida que el usuario haya ingresado el número de cédula
            if(txtCedula.Text != "")
            {
                // Instanciamos un objeto Persona con el comando de "consulta" y su número de cédula
                persona = new Persona("consulta", txtCedula.Text);
                try
                {
                    // Definición de la conexión remota con el servidor
                    remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                    usuario = new TcpClient();
                    usuario.Connect(remoto);
                    lector = new StreamReader(usuario.GetStream());
                    escritor = new StreamWriter(usuario.GetStream());

                    // Instanciación de un objeto BinaryFormatter para Serializar el objeto Persona
                    BinaryFormatter bf = new BinaryFormatter();

                    // Se envía el objeto Persona Serializado al servidor para ejecutar la consulta en la base de datos
                    bf.Serialize(usuario.GetStream(), persona);

                    // Recibe el objeto Persona como respuesta del servidor para Deserializalo
                    persona = (Persona)(bf.Deserialize(usuario.GetStream()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    escritor.Close();
                    lector.Close();
                    usuario.Close();
                }

                // Si la Persona existe, se mostrarán todos sus campos en las cajas de Texto
                if (persona.Cedula != null)
                {
                    txtNombre.Text = persona.Nombre;
                    txtApellido.Text = persona.Apellido;
                    cbxDepartamento.Text = persona.Departamento;
                    txtTitulo.Text = persona.Titulo;
                    cbxTipo.Text = persona.TipoPersonal;
                    txtEstado.Text = persona.Estado;
                    txtCedula.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    cbxDepartamento.Enabled = false;
                    txtTitulo.Enabled = false;
                    cbxTipo.Enabled = false;
                    txtEstado.Enabled = false;
                    btnBuscar.Enabled = false;
                    // Si el estado de la persona es "SOLICITADO", se habilitará el envío de un documento
                    if (persona.Estado.Equals("SOLICITADO"))
                    {
                        btnCargarDocumento.Visible = true;
                        btnEnviarDocumento.Visible = true;
                        txtNombreDocumento.Visible = true;
                    }
                    // Caso contrario, si el estado es ENTREGA_DOCUMENTOS se preguntará si desea ser contratado
                    else if (persona.Estado.Equals("ENTREGA_DOCUMENTOS"))
                    {
                        // Almacena el resultado del cliente al preguntar si desea ser contratado
                        DialogResult resultado = MessageBox.Show("¿Desea ser contratado?", "Mi Primer Contrato.co", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        // Se valida el resultado del cliente para modificar su estado
                        if (resultado == DialogResult.Yes)
                        {
                            persona.Estado = "CONTRATADO";
                            txtEstado.Text = "CONTRATADO";
                        }
                        else
                        {
                            persona.Estado = "VALIDADO";
                            txtEstado.Text = "VALIDADO";
                        }

                        // El comando es contratar para modificar el estado de la persona en la base de datos
                        persona.Comando = "contratar";
                        try
                        {
                            // Definición de la conexión remota con el servidor
                            remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                            usuario = new TcpClient();
                            usuario.Connect(remoto);
                            lector = new StreamReader(usuario.GetStream());
                            escritor = new StreamWriter(usuario.GetStream());

                            // Instanciación de un objeto BinaryFormatter para Serializar el objeto Persona
                            BinaryFormatter bf = new BinaryFormatter();

                            // Se envía el objeto Persona Serializado al servidor para actualizar el estado
                            bf.Serialize(usuario.GetStream(), persona);
                            mensajeRecibido = lector.ReadLine();
                            MessageBox.Show("Gracias por su respuesta. Su estado es " + persona.Estado, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(mensajeRecibido, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            escritor.Close();
                            lector.Close();
                            usuario.Close();
                        }
                    }
                }
                else
                {
                    // Se informa al usuario que la persona no existe en el proceso de contratación y que puede iniciar dicho proceso
                    MessageBox.Show("La persona ingresada no se encuentra registrada. Proceda a realizar el proceso de contratación", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese un número de cédula", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar un cuadro de diálogo que permita escoger un documento PDF a enviar
        private void btnCargarDocumento_Click(object sender, EventArgs e)
        {
            // Instacia de un objeto OpenFileDialog para mostrar un cuadro de diálogo
            OpenFileDialog abrirPDF = new OpenFileDialog();
            
            // Aplica el filtro para subir archivos PDF
            abrirPDF.Filter = "Archivos pdf(*.pdf)|*.pdf";

            // Título para el cuadro de diálogo
            abrirPDF.Title = "Archivos PDF";

            // Si se selecciona el documento, se almacena la ruta del archivo en la caja de Texto
            if(abrirPDF.ShowDialog() == DialogResult.OK)
            {
                txtNombreDocumento.Text = abrirPDF.FileName;
            }

            // Liberación de los recursos del cuadro de diálogo
            abrirPDF.Dispose();
        }

        // Evento desencadenado para enviar el documento PDF escogido al servidor
        private void btnEnviarDocumento_Click(object sender, EventArgs e)
        {
            // Validación de que el usuario haya escogido un documento para enviar
            if(txtNombreDocumento.Text != "")
            {
                try
                {
                    // Convierte el documento PDF en un arreglo de bytes para ser enviado
                    persona.Documento = File.ReadAllBytes(txtNombreDocumento.Text);
                    persona.Comando = "guardarpdf";
                    persona.Estado = "ENTREGA_DOCUMENTOS";

                    // Definición de la conexión remota con el servidor
                    remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                    usuario = new TcpClient();
                    usuario.Connect(remoto);
                    lector = new StreamReader(usuario.GetStream());
                    escritor = new StreamWriter(usuario.GetStream());

                    // Instanciación de un objeto BinaryFormatter para Serializar el objeto Persona
                    BinaryFormatter bf = new BinaryFormatter();

                    // Se envía el objeto Persona Serializado al servidor
                    bf.Serialize(usuario.GetStream(), persona);

                    mensajeRecibido = lector.ReadLine();
                    MessageBox.Show(mensajeRecibido, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("Su estado se encuentra en ENTREGA_DOCUMENTOS", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TerminarProceso();
                }
                catch (DirectoryNotFoundException dirEx)
                {
                    // Excepción cuando la ruta del documento no es válida
                    MessageBox.Show("Ingrese un documento válido. \n" + dirEx.Message, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FileNotFoundException filEx)
                {
                    // Excepción cuando el archivo especificado no fue encontrado
                    MessageBox.Show("El archivo no fue encontrado. \n" + filEx.Message, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor adjunte un archivo PDF", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Validación de que solo ingrese número el usuario
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
