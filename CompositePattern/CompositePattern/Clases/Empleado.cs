using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Clases
{
    public class Empleado
    {
        private string nombre;
        private string departamento;
        private int salario;
        private List<Empleado> subordinados;

        //constructor
        public Empleado(string Nombre, string Departamento, int Salario)
        {
            this.nombre = Nombre;
            this.departamento = Departamento;
            this.salario = Salario;
            subordinados = new List<Empleado>();
        }


        public void Agregar(Empleado emp)
        {
            subordinados.Add(emp);
        }

        public List<Empleado> ObtenerSubordinados()
        {
            return subordinados;
        }

        public override string ToString()
        {
            return ("Empleado : [ Name : " + this.nombre + ", departamento : " + this.departamento + ", salario : " + this.salario + " ]");
        }
    }
}
