using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Espacio de nombres para permitir el desplazamiento de la ventana
using System.Runtime.InteropServices;

namespace Cliente
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Importamos las librerías DLL para controlar el manejo del movimiento de la ventana - RealeseCapture y SendMessage
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        // Usa el modificador extern para declarar que el método importado del DLL está implementado externamente
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Evento del botón cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Almacena el resultado del cliente antes de cerrar el formulario
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Mi Primer Contrato.co", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Se valida el resultado del cliente antes de cerrar la aplicación
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        // Evento para minimizar la ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Método que permite abrir un formulario dentro del panel "pnlContenedor"
        public void abrirFormHijo(object frmHijo)
        {
            //Verificamos si el panel tiene controles y los eliminamos
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);

            //El objeto recibido se lo convierte en un objeto Formulario
            Form fh = frmHijo as Form;
            
            //Se especifica que es un formulario secundario
            fh.TopLevel = false;
            
            //Se permite que el formulario ocupe todo el panel
            fh.Dock = DockStyle.Fill;

            //Añade el formulario recibido al panel
            pnlContenedor.Controls.Add(fh);
            pnlContenedor.Tag = fh;

            //Mostramos el formulario
            fh.Show();
        }

        // Evento del botón "Consultar Personal"
        private void btnConsultarPersonal_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario para Consultar el Personal
            FrmConsultarPersonal frmConsultar = new FrmConsultarPersonal();
            // Abrimos el formulario dentro del panel "Contenedor"
            abrirFormHijo(frmConsultar);
        }

        // Evento del botón "Buscar Persona"
        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario para Consultar el Personal
            FrmContratacion frmContratacion = new FrmContratacion();

            // Control de visibilidad de botones requeridos
            frmContratacion.btnBuscar.Visible = true;
            frmContratacion.btnEnviarDatos.Visible = false;
            // Abrimos el formulario dentro del panel "Contenedor"
            abrirFormHijo(frmContratacion);
        }

        // Evento del botón "Iniciar Contratación"
        private void btnIniciarContratacion_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario para Iniciar el Proceso de Contratación
            FrmContratacion frmContratacion = new FrmContratacion();
            // Abrimos el formulario dentro del panel "Contenedor"
            abrirFormHijo(frmContratacion);
        }

        // Evento del botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Almacena el resultado del cliente antes de cerrar el formulario
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Mi Primer Contrato.co", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Se valida el resultado del cliente antes de cerrar la aplicación
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        // Método que permite mover la ventana al mantener presionado un botón del mouse sobre el panel superior
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Evento load del formulario
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Instaciamos el formulario que contiene la presentación inicial
            FrmPresentacion frmPresentacion = new FrmPresentacion();
            // Se abre el formulario en el panel Contenedor
            abrirFormHijo(frmPresentacion);
        }
    }
}
