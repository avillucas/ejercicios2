using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio_60
{
    public static class ProductDAO 
    {
        
        #region Atributos

        static private string dbName;        
        private static SqlConnection _conexion;
        private static SqlCommand _comando;

        #endregion

        #region Constructores
        
        static ProductDAO()
        {
            ProductDAO._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            ProductDAO._comando = new SqlCommand();            
            ProductDAO._comando.CommandType = System.Data.CommandType.Text;            
            ProductDAO._comando.Connection = ProductDAO._conexion;
            ProductDAO.dbName = "Production.Product";
        }
        #endregion 

        public static Product getOne(int productId)
        {
            bool TodoOk = false;
            Product producto = null;            
            try
            {
                ProductDAO._comando.CommandText = "SELECT ProductID,name  FROM " + ProductDAO.dbName + " WHERE ProductID = "+productId.ToString();
                ProductDAO._conexion.Open();
                SqlDataReader oDr = ProductDAO._comando.ExecuteReader();
                if (oDr.Read())
                {
                    producto = new Product(int.Parse(oDr["ProductID"].ToString()), oDr["name"].ToString());
                }
                oDr.Close();
                TodoOk = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (TodoOk)
                    ProductDAO._conexion.Close();
            }
            return producto;
        }

        /// <summary>
        ///  Retorna una lista de todos los valores
        /// </summary>
        /// <returns></returns>
        public static List<Product> getAll()
        {
            bool TodoOk = false;                        
            List<Product> productos = new List<Product>();
            try
            {
                
                ProductDAO._comando.CommandText = "SELECT id,name  FROM " + ProductDAO.dbName;                               
                ProductDAO._conexion.Open();
                SqlDataReader oDr = ProductDAO._comando.ExecuteReader();                
                if (oDr.Read())
                {
                    productos.Add(new Product(int.Parse(oDr["id"].ToString()), oDr["name"].ToString()));
                }
                oDr.Close();
                TodoOk = true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (TodoOk)
                    ProductDAO._conexion.Close();
            }
            return productos;
        }
    }
}
