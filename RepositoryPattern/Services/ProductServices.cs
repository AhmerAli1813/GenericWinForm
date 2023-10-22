using RepositoryPattern.Genrics;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class ProductServices
    {
        private readonly ProductsDataAccess productsDataAccess;

        public ProductServices()
        {
            this.productsDataAccess = new ProductsDataAccess();
        }
        public List<Product> GetProducts(string SearchCarieria,int page ,int recordsPerPage,out int totalRecords)
        {
            return productsDataAccess.GetEntities(SearchCarieria, "Products","p_id","p_name,p_id", page,recordsPerPage,out totalRecords); 
        }
        public void CreateProduct(Product product)
        {
            productsDataAccess.CreateEntity(product, "Products");
        }
        public void UpdateProduct(Product product)
        {
            productsDataAccess.UpdateEntity(product, "Products");
        }
        public void DeleteProduct(int id)
        {
            //here you can add validation to check if the product exists or handel Exceptions acconrdingly 
            productsDataAccess.DeleteEntity(id, "Products");
        }
        public List<Product> ShowAllProducts()
        {
            return productsDataAccess.GetALLProducts("Products");
        }
        public Product GetProductFromId(int id)
        {
            return productsDataAccess.GetProductById(id, "Products");
        }


    }
}
