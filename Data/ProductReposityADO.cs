using RepositoryExample.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace RepositoryExample.Data
{
    public class ProductReposityADO : IProductoRepository
    {

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>();
            var helper = DataHelper.GetInstance();
            var dt = helper.ExecuteSPQuery("SP_recuperar_productos");
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["codigo"].ToString());
                string nombre = row["n_product"].ToString();
                int stock = Convert.ToInt32(row["stock"].ToString());
                bool activo = Convert.ToBoolean(row["activo"].ToString());

                Product product = new Product()
                {
                    Codigo = id,
                    Nombre = nombre,
                    Stock = stock,
                    Activo = activo
                };
                lst.Add(product);
            }
            return lst;
        }

        public bool Save(Product product)
        {/*
            bool result = true;
            string query = "SP_guardar_producto";
            try
            {
                if (product != null)
                {
                    _connection.Open();
                    var cmd = new SqlCommand(query, _connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", product.Nombre);
                    cmd.Parameters.AddWithValue("@stock", product.Stock);
                    result = cmd.ExecuteNonQuery() == 1;
                }
            }
            catch (Exception)
            {
                throw null;
            }
            finally
            {
                if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
                throw null;
            }
            */
            return true;
        }
    }
}
