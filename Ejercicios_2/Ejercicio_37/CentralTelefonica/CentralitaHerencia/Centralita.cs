using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.IO;

=======
>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
namespace CentralitaHerencia
{
    public class Centralita : IGuardar<String>
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
<<<<<<< HEAD
        private string logFilePath ;
        const string DEFAULT_LOG_FILE_NAME = "log.txt";
=======
        const string logPath = "log.txt";

>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
        string IGuardar<String>.RutaDeArchivo
        {
            get {
                
                return this.logFilePath;
            }
            set {
                logFilePath = value;
            }
        }
        /// <summary>
        /// TODO
        /// </summary>
        public float GananciasPorLocal
        {
            get {
                return CalcularGanancia(Llamada.TipoDeLlamada.Local);
            }
        }

        public float GanaciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoDeLlamada.Provincial);
            }
        }

        public float GanaciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoDeLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        private Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
            logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + DEFAULT_LOG_FILE_NAME;
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private void AgregarLlamada(Llamada nuevaLlamada) 
        {       
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará
        /// el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local,
        /// Provincial o de Todas según corresponda).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoDeLlamada tipo)
        {
            float ganacia = 0;
            foreach (Llamada llamada in listaDeLlamadas) {
                if (llamada is Local && ( tipo == Llamada.TipoDeLlamada.Local || tipo == Llamada.TipoDeLlamada.Todas)) {
                    ganacia += ((Local)llamada).CostoLlamada;
                }
                else if(llamada is Provincial && (tipo == Llamada.TipoDeLlamada.Local || tipo == Llamada.TipoDeLlamada.Todas))
                {
                    ganacia += ((Provincial)llamada).CostoLlamada;
                }                
            }
            return ganacia;
        }


        public override string ToString () 
        {
            StringBuilder st = new StringBuilder();                        
            st.AppendFormat("\n razon social {0} ganancia total {1} Ganacias Locales {2} Ganancias Provinciales {3} ", razonSocial, GanaciasPorTotal , GananciasPorLocal,GanaciasPorProvincial);
            foreach(Llamada llamada in  listaDeLlamadas){
                st.AppendFormat("\n llamado {0} ", llamada.ToString());
           }
            return st.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            foreach (Llamada posibleLlamada in central.listaDeLlamadas)
            {
                if (posibleLlamada == (Llamada)llamada) {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {            
            return !(central == llamada);
        }

        ///
        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if (central == llamada)
            {
                throw new CentralitaException("La llamada "+llamada.NroOrigen+"=>"+llamada.NroDestino+" ya se encuentra en la central","Centralita", "operator +");
            }
            central.AgregarLlamada(llamada);
<<<<<<< HEAD
            try
            {
                IGuardar<string> guardar = (IGuardar<string>)central;
                guardar.Guardar();                
            }
            catch (Exception e) 
            {
                throw new FallaLogException("Error al general log",e);
=======
            IGuardar<string> g = (IGuardar<string>)central;
            try
            {               
                g.Guardar();
            }
            catch (Exception e) {
                throw new FallaLogException("Error en el archivo", e);
>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
            }
            return central;
        }

        /// <summary>
<<<<<<< HEAD
        ///El método Guardar de la implementación de IGuardar en Centralita deberá guardar en un
        ///archivo de texto a modo de bitácora fecha y hora con el siguiente formato “Jueves 19 de
        ///octubre de 2017 19:09hs – Se realizó una llamada”; para lo cual este método deberá ser
        ///llamado desde el operador + (suma). En caso de no poder guardar, igualmente agregar la
        ///llamada a la Centralita y luego lanzar la excepción FallaLogException.
        /// </summary>        
        bool IGuardar<String>.Guardar()
        {
            try
            {
                StringBuilder st = new StringBuilder();
                DateTime ahora = DateTime.Now; ;
                //TODO acomodar la hora 
                //TODO traducir mes y dia 
                st.AppendFormat("{0} {1} de {2} de {3} {4}hs - Se realizo una llamada", ahora.DayOfWeek, ahora.Day, ahora.Month, ahora.Year, ahora.TimeOfDay);
                string filePath  = ((IGuardar<string>)this).RutaDeArchivo;
                StreamWriter archivo = new StreamWriter( filePath);
                archivo.WriteLine(st.ToString(),true);
                archivo.Close();
            }catch(Exception e ){
=======
        /// Guardar tomará el objeto y consultará todos sus datos, luego retornará true.
        /// TODO revisar que puede querer decir con revisar todos los datos de un String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool IGuardar<string>.Guardar()
        {
            var culture = new System.Globalization.CultureInfo("es-AR");            
            DateTime now = DateTime.Now;            
            //string logLine = "Jueves 19 de octubre de 2017 19:09hs – Se realizó una llamada";
            StringBuilder st = new StringBuilder();
            var dia = culture.DateTimeFormat.GetDayName(now.DayOfWeek);
            var mes = culture.DateTimeFormat.GetMonthName(now.Month);
            //string diaSemana = ;
            st.AppendFormat("{0} {1} de {2} de {3} {4}:{5}hs – Se realizó una llamada", dia,now.Day.ToString(), mes, now.Year, now.Hour, now.Minute);

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(logPath, true))
                {
                    file.WriteLine(st.ToString());
                }
            }
            catch (Exception e)
            {
>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
                throw e;
            }
            return true;
        }

<<<<<<< HEAD
        public String Leer()
        {
            string contenido;
            string filePath = ((IGuardar<string>)this).RutaDeArchivo;
            StreamReader lector = new StreamReader(filePath);
            contenido = lector.ReadToEnd();
            lector.Close();
=======
        string IGuardar<string>.Leer()
        {
            string contenido;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(logPath))
                {
                    contenido = file.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
>>>>>>> 335e2d1415fcd728d151a4d68e904cca17657e75
            return contenido;
        }

    }
}
