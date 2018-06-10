using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    class Correo
    {
        public List<Paquete> Paquetes {  get; set;  }
        #region Constructores
        public Correo()
        {
            this.Paquetes = new List<Paquete>();
        }
        #endregion
        #region Metodos
        public void FinEntregas()
        {
            throw new NotImplementedException();
        }

        public string MostrarDatos(IMostrar<List<Paquete>>elementos)
        {
            throw new NotImplementedException();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
