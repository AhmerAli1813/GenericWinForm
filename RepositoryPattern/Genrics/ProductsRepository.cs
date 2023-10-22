using Dapper;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Genrics
{
    public class ProductsRepository : IProductsRepository
    {
        public void DeleteProducts(int? id)
        {

            using (IDbConnection db = new SqlConnection(ApplConnection.Connection))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                else { db.Close(); }
                 db.Query<Product>($"Delete  from Products Where @P_id ={id} ", commandType: CommandType.Text);

            }
        }

        public IEnumerable<Product> GetAllproducts()
        {
            using (IDbConnection db = new SqlConnection(ApplConnection.Connection))
            {
                if(db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                else { db.Close(); }
                return db.Query<Product>("select * from Products", commandType: CommandType.Text);

            }
        }

        public void InsertProducts()
        {

            using (SqlConnection db = new SqlConnection(ApplConnection.Connection))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    using (SqlCommand cmd = new SqlCommand("Insert into Produts (@p_name ,@p_desc,@p_unitPerPerize,@p_Stock)", db))
                    {

                    }
                }
                else { db.Close(); }
                

            }
        }

        public void UpdateProducts(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
