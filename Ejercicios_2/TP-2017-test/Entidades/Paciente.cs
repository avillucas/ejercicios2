using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente :Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno 
        {
            get
            {
                return turno;
            }
            set
            {
                turno = value;
            }
        }

        #region Constructores

        
        static Paciente()
        {
            ultimoTurnoDado = 0;
        }         
        
        public Paciente(string nombre, string apellido)
            : base(nombre, apellido)                    
        {
            this.turno = ++ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            ultimoTurnoDado = turno;
            this.turno = ultimoTurnoDado;
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("Turno Nº{0}: {2}, {1}", this.turno, this.nombre, this.apellido);
        }
        #endregion
    }
}
