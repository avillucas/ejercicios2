using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Paquete
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;        

        enum EEstado  {
            Ingresado,
            EnViaje, 
            Entregado
        }

        public string DireccionEntrega
        {
            get
            {
                return direccionEntrega;
            }
            set
            {
                direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        public string TrackingID{
            get
            {
                return trackingID;
            }
            set
            {
                trackingID = value;
            }
        }

        public void MockCicloDeVida()
        {
            throw new NotImplementedException();
        }
        /*
        
        public Paquete() 
        {
            Paquete.InformaEstado += DelegadoEstado;
        }
         * */

        
        private void DelegadoEstado(Object sender, EventArgs e){

        }

    }
}
