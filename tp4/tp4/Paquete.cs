using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    public class Paquete : IMostrar<Paquete>
    {
        enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }


        #region Propiedades
        public string DireccionEntrega { get; set; }
        public EEstado Estado { get; set; }
        public string TrackingID { get; set; }
        #endregion

        #region Construccion
        public Paquete(string direccionDeEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionDeEntrega;
            this.TrackingID = trackingID;
        }
        #endregion

        #region Metodos

        public void MockCicloDeVida()
        {
            throw new NotImplementedException();
        }

        public override string MostrarDatos(IMostrar<Paquete> elemento)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
