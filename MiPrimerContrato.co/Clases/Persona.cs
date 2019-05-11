using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    [Serializable]
    public class Persona
    {
        // Atributos de la clase Persona
        private string comando;
        private string cedula;
        private string nombre;
        private string apellido;
        private string tipoPersonal;
        private string departamento;
        private string titulo;
        private string estado;

        // Constructor por defecto de la clase Persona
        public Persona()
        {

        }
        public Persona(string comando, string cedula)
        {
            this.comando = comando;
            this.cedula = cedula;
        }

        //Constructor de la clase Persona con todos los parametros
        public Persona(string comando, string cedula, string nombre, string apellido, string tipoPersonal, string departamento, string titulo, string estado)
        {
            this.comando = comando;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoPersonal = tipoPersonal;
            this.departamento = departamento;
            this.titulo = titulo;
            this.estado = estado;
        }

        // Métodos get y set para cada uno de los atributos de la clase Persona
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoPersonal { get => tipoPersonal; set => tipoPersonal = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Comando { get => comando; set => comando = value; }

        // Método ToString()
        public override string ToString()
        {
            return Cedula + "\t" + Comando + "\t" + Nombre + "\t" + Apellido + "\t" + TipoPersonal + "\t" + Departamento + "\t" + Titulo + "\t" + Estado;
        }
    }
}
