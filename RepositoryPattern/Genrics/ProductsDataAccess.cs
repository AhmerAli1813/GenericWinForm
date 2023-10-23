using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace RepositoryPattern.Genrics
{
    public class ProductsDataAccess : GenricRepository<Product>
    {

        public override Product MapEntityFromDataReader(SqlDataReader reader)
        {
            int pId = Convert.ToInt32(reader["p_id"]);
            string pName = Convert.ToString(reader["p_name"]);
            string pDesc = Convert.ToString(reader["p_desc"]);
            double pPerize = Convert.ToDouble(reader["p_unitPerPerize"]);
            double pStockQty = Convert.ToDouble(reader["p_Stock"]);

            return new Product
            {
                p_id = pId,
                p_name = pName,
                p_desc = pDesc,
                p_Stock = pStockQty,
                p_unitPerPerize = pPerize

            };
        }

        public override void CreateEntity(Product entity, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //impelementaion new enitiy of product table
                string qurey = $"INSERT INTO  {tableName} (p_name,p_desc,p_unitPerPerize,p_Stock) VALUES(@name , @desc,@peize,@stockQty)";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                cmd.Parameters.AddWithValue("@name", entity.p_name);
                cmd.Parameters.AddWithValue("@desc", entity.p_desc);
                cmd.Parameters.AddWithValue("@peize", entity.p_unitPerPerize);
                cmd.Parameters.AddWithValue("@stockQty", entity.p_Stock);
                cmd.ExecuteNonQuery();
            }

        }

        public override void UpdateEntity(Product entity, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //impelementaion update enitiy of product table
                string qurey = $"UPDATE   ${tableName} SET p_name =@name, p_desc =@desc ,p_unitPerPerize = @peize,p_Stock = @stockQty";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                cmd.Parameters.AddWithValue("@name", entity.p_name);
                cmd.Parameters.AddWithValue("@desc", entity.p_desc);
                cmd.Parameters.AddWithValue("@peize", entity.p_unitPerPerize);
                cmd.Parameters.AddWithValue("@stockQty", entity.p_Stock);
                cmd.ExecuteNonQuery();
            }

        }
        public override void DeleteEntity(int id, string tableName)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //impelementaion update enitiy of product table
                string qurey = $"DELETE FROM   ${tableName} WHERE p_id = @id ";
                SqlCommand cmd = new SqlCommand(qurey, connection);
                cmd.Parameters.AddWithValue("@id", id);
            }
        }
        public Product GetProductById(int id, string tableName)
        {
            //create product object for share data result
            Product product = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //impelementaion get single enitiy of product table
                string qurey = $"SELECT * FROM {tableName} WHERE p_id = @id";
                using (SqlCommand cmd = new SqlCommand(qurey, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //now here we intialize the product data from  the database
                            product = new Product
                            {
                                p_id = (int)reader["p_id"],
                                p_name = (string)reader["p_name"],
                                p_desc = (string)reader["p_desc"],
                                p_Stock = (double)reader["p_Stock"],
                                p_unitPerPerize = (double)reader["p_unitPerPerize"]
                                //add more properties as your need
                            };
                        }
                    }

                }


            }
            return product;

        }

        public List<Product> GetALLProducts(string tableName)
        {
            List<Product> products = new List<Product>();
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //now here we intialize the product data from  the database
                            Product product = new Product
                            { 
                                p_id = Convert.ToInt32(reader["p_id"]),
                             p_name = Convert.ToString(reader["p_name"]),
                             p_desc = Convert.ToString(reader["p_desc"]),
                             p_unitPerPerize = Convert.ToDouble(reader["p_unitPerPerize"]),
                             p_Stock = Convert.ToDouble(reader["p_Stock"])
                            //add more properties as your need
                        };
                            products.Add(product);
                        }
                        
                    }
                }
            }
            return products;
        }
    }
}