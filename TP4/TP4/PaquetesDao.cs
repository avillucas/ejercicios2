using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TP4
{
    static class PaquetesDao
    {               
     
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
        static PaquetesDao()
        {            
            PaquetesDao._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            PaquetesDao._comando = new SqlCommand();            
            PaquetesDao._comando.CommandType = System.Data.CommandType.Text;            
            PaquetesDao._comando.Connection = PaquetesDao._conexion;
        }
        #endregion

        #region Metodos
        public static bool Insertar(Paquete p)
        {
            bool flag = false;
            
            string sql = "INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','" + Properties.Settings.Default.NombreAlumno + "')";                        
            try
            {                
                PaquetesDao._comando.CommandText = sql;             
                PaquetesDao._conexion.Open();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                    PaquetesDao._conexion.Close();
            }
            return flag;
        }
        #endregion
    }
}
