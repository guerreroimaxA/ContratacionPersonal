using System;

namespace Clases
{
    public class Persona
    {
        // Atributos de la clase Persona
        private string cedula;
        private string idPersona;
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

        //Constructor de la clase Persona con todos los parametros
        public Persona(string cedula, string idPersona, string nombre, string apellido, string tipoPersonal, string departamento, string titulo, string estado)
        {
            this.Cedula = cedula;
            this.IdPersona = idPersona;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoPersonal = tipoPersonal;
            this.Departamento = departamento;
            this.Titulo = titulo;
            this.Estado = estado;
        }

        // Métodos get y set para cada uno de los atributos de la clase Persona
        public string Cedula { get => cedula; set => cedula = value; }
        public string IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoPersonal { get => tipoPersonal; set => tipoPersonal = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
