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
        string mensajeRecibido;
        public FrmContratacion()
        {
            InitializeComponent();
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Definición de la conexión remota con el servidor
                remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                usuario = new TcpClient();
                usuario.Connect(remoto);
                // Se instancia una persona con la solicitud "nuevo" para ingresar a la base de datos
                Persona persona = new Persona("nuevo", txtCedula.Text, txtNombre.Text, txtApellido.Text, cbxTipo.Text, cbxDepartamento.Text, txtTitulo.Text, "SOLICITADO");
                lector = new StreamReader(usuario.GetStream());
                escritor = new StreamWriter(usuario.GetStream());
                BinaryFormatter bf = new BinaryFormatter();

                // Serialización del objeto para enviarlo al servidor
                bf.Serialize(usuario.GetStream(), persona);

                // Lectura del mensaje recibido por parte del servidor
                mensajeRecibido = lector.ReadLine();
                MessageBox.Show(mensajeRecibido, "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TerminarProceso();
            }
            catch(Exception ex)
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

        private void FrmContratacion_Load(object sender, EventArgs e)
        {
            
        }

        // Método para limpiar los textos 
        private void TerminarProceso()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTitulo.Text = "";
            txtEstado.Text = "";
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
        }

        // Método para buscar una persona en particular
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se valida que el usuario haya ingresado el número de cédula
            if(txtCedula.Text != "")
            {
                // Instanciamos un objeto Persona con el comando de "consulta" y su número de cédula
                Persona persona = new Persona("consulta", txtCedula.Text);
                try
                {
                    // Definición de la conexión remota con el servidor
                    remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
                    usuario = new TcpClient();
                    usuario.Connect(remoto);
                    lector = new StreamReader(usuario.GetStream());
                    escritor = new StreamWriter(usuario.GetStream());
                    BinaryFormatter bf = new BinaryFormatter();

                    // Se envía el objeto Persona Serializado al servidor
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
                }
                else
                {
                    // Se informa al usuario que la persona no existe en el proceso de contratación y que puede iniciar dicho proceso
                    MessageBox.Show("La persona ingresada no se encuentra registrada. Proceda a realizar el proceso de contratación", "MiPrimerContrato.co", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Text = "";
                }
            }
        }
    }
}
