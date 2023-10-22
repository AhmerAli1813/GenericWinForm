using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Genrics
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetAllproducts();
        void InsertProducts();
        void UpdateProducts(int? id);
        void DeleteProducts(int? id);
    }
}
