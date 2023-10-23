using RepositoryPattern.Models;
using RepositoryPattern.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryPattern
{
    public partial class ActionProduct : Form
    {
        ProductsDisplay productsDisplay;
        private readonly ProductServices productServices;
        public ActionProduct()
        {
            InitializeComponent();
            //this.productsDisplay = new ProductsDisplay();
            productServices = new ProductServices();
            productsDisplay = new ProductsDisplay();
            saveBtn.Enabled = true;
            saveBtn.BackColor = Color.LightGray;
            updateBtn.Enabled = false;

        }

        //public ActionProduct(ProductsDisplay productsDisplayIsntance)
        //{
        //    this.productsDisplay = productsDisplayIsntance;
        //}

        private void ActionProduct_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string PName = pNameTxtBx.Text;
            string PDesc = descTxtBx.Text;
            double PPrize = Convert.ToDouble(pPerizeTxtBx.Text);
            double PStock = Convert.ToDouble(stockTxtBx.Text);

            Product newProdut = new Product
            {
                p_desc = PDesc,
                p_name = PName,
                p_Stock = PStock,
                p_unitPerPerize = PPrize
                
            };
            productServices.CreateProduct(newProdut);
            MessageBox.Show(" Create Successfully ", "Create Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            productsDisplay.LoadProductList(); // Refreach Data

            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTxtBx.Text);
            string PName = pNameTxtBx.Text;
            string PDesc = descTxtBx.Text;
            double PPrize = Convert.ToDouble(pPerizeTxtBx.Text);
            double PStock = Convert.ToDouble(stockTxtBx.Text);

            Product newProdut = new Product
            {
                p_id = id,
                p_desc = PDesc,
                p_name = PName,
                p_Stock = PStock,
                p_unitPerPerize = PPrize

            };
            productServices.UpdateProduct(newProdut);
            MessageBox.Show(" Update Successfully ", "Create Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            productsDisplay.LoadProductList(); // Refreach Data

            this.Close();
        }
    }
}
