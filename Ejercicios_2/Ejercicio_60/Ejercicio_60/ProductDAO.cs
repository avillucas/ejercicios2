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
                ProductDAO._comando.CommandText = "SELECT ProductID,name  FROM " + ProductDAO.dbName + " WHERE ProductID = " + productId.ToString();
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

        public static void Guardar(Product producto)
        {
            bool todoOk = false;
            try{
                StringBuilder consulta = new StringBuilder();
                consulta.AppendFormat("UPDATE {0} SET name = '{1}' WHERE ProductID = {2}", ProductDAO.dbName, producto.Name, producto.Id);
                ProductDAO._comando.CommandText = consulta.ToString();
                ProductDAO._conexion.Open();
                ProductDAO._comando.ExecuteNonQuery();            
                todoOk = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (todoOk)
                    ProductDAO._conexion.Close();
            }
        }

        public static void Crear(Product producto)
        {
            bool todoOk = false;
            try{
                StringBuilder consulta = new StringBuilder();
                consulta.AppendFormat(@"
INSERT INTO [Production].[Product]
           (
		   [Name]
           ,[ProductNumber]
           ,[MakeFlag]
           ,[FinishedGoodsFlag]
           ,[Color]
           ,[SafetyStockLevel]
           ,[ReorderPoint]
           ,[StandardCost]
           ,[ListPrice]
           ,[Size]
           ,[SizeUnitMeasureCode]
           ,[WeightUnitMeasureCode]
           ,[Weight]
           ,[DaysToManufacture]
           ,[ProductLine]
           ,[Class]
           ,[Style]
           ,[ProductSubcategoryID]
           ,[ProductModelID]
           ,[SellStartDate]
           ,[SellEndDate]
           ,[DiscontinuedDate]
           ,[rowguid]
           ,[ModifiedDate]
		   )
     VALUES
           (
		  		'{0}',
				'BE-5385',
			 	0,
				0,
				NULL,
				'1000',
				'750',
				'0,00',
				'0,00',
				NULL,
				NULL,
				NULL,
				NULL,
				0,
				NULL,
				NULL,
				NULL,
				NULL,
				NULL,
				'2008-04-30T00:00:00',	
				'2008-04-30T00:00:00',		
				'2008-04-30T00:00:00',	
				'694215B7-08F7-4C0D-ACB1-D734BA44C0C9',
				'2014-02-08T10:01:36.827'
			)", ProductDAO.dbName, producto.Name );
                ProductDAO._comando.CommandText = consulta.ToString();
                ProductDAO._conexion.Open();
                ProductDAO._comando.ExecuteNonQuery();            
                todoOk = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (todoOk)
                    ProductDAO._conexion.Close();
            }
        }

        public static void Delete(int id)
        {
            bool todoOk = false;
            try
            {
                StringBuilder consulta = new StringBuilder();
                consulta.AppendFormat("DELETE {0} WHERE ProductID = {1}", ProductDAO.dbName, id);
                ProductDAO._comando.CommandText = consulta.ToString();
                ProductDAO._conexion.Open();
                ProductDAO._comando.ExecuteNonQuery();
                todoOk = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (todoOk)
                    ProductDAO._conexion.Close();
            }
        }

    }
}
