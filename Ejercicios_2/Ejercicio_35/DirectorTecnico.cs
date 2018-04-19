using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        public DirectorTecnico(string nombre): base(nombre)
        {            
        }

        public DirectorTecnico(int dni, string nombre, DateTime fechaDeNacimiento) : base(dni, nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }


        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.dni != d2.dni);
        }

        
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.dni == d2.dni);
        }
    }
}
