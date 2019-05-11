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
    public partial class FrmConsultarPersonal : Form
    {
        TcpClient usuario;
        StreamReader lector;
        IPEndPoint remoto;
        string cantidadTipoPersonal = "0";
        public FrmConsultarPersonal()
        {
            InitializeComponent();
        }

        private void FrmConsultarPersonal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void FrmConsultarPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cbxTipoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Definición de la conexión remota con el servidor
            remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8090);
            usuario = new TcpClient();
            usuario.Connect(remoto);

            // Instanciamos una Persona con el comando "cantidad" para consultar por el Tipo de Personal
            Persona persona = new Persona();
            persona.Comando = "cantidad";
            persona.TipoPersonal = cbxTipoPersonal.Text;

            lector = new StreamReader(usuario.GetStream());
            BinaryFormatter bf = new BinaryFormatter();

            // Serialización del objeto para enviarlo al servidor
            bf.Serialize(usuario.GetStream(), persona);

            // Se recibe la cantidad de personal contratado en base a su Tipo
            cantidadTipoPersonal = lector.ReadLine();
            txtCantidad.Text = cantidadTipoPersonal;
            lector.Close();
            usuario.Close();
        }
    }
}
