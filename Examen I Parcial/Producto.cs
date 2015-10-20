using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Examen_I_Parcial
{
    class Producto
    {
        public int productId { get; set; }
        public string name { get; set; }
        public bool finishedGoodsFlag { get; set; }

        public static List<Producto> ObtenerProductosVendibles()
        {
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                integrated security = true; database = AdventureWorks2014");
            string sql;
            List<Producto> resultados = new List<Producto>();

            sql = @"Select Name From Production.Product Where FinishedGoodsFlag = 1";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Producto producto = new Producto();

                    producto.name = rdr.GetString(0);

                    resultados.Add(producto);
                }

                return resultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int CodigoProducto(string nombre)
        {
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                integrated security = true; database = AdventureWorks2014");
            string sql;
            int productId = -1;

            sql = @"Select ProductId From Production.Product Where Name = @name";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                SqlDataReader rdr;

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = nombre;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    productId = rdr.GetInt32(0);
                }

                if (productId == -1)
                {
                    throw new CustomException("El producto solicitado no existe.");
                }
                else
                    return productId;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (CustomException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
