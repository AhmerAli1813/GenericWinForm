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
    public partial class ProductsDisplay : Form
    {
        ProductServices productServices;
        //variables
        private int _currentPage = 1;
        private int _recordsPerPage = 10;
        private int _totalReords = 0;
        private int _totalPage = 0;
        public ProductsDisplay()
        {
            InitializeComponent();
            productServices = new ProductServices();
            LoadProductList();
            LoadRecordsPerPageList();

        }

        private void LoadRecordsPerPageList()
        {
            //Populate the ComboBox with option as per record show in single page    
            DisplayRecordPerPageCb.Items.Add("5");
            DisplayRecordPerPageCb.Items.Add("10");
            DisplayRecordPerPageCb.Items.Add("20");

            // Select Defualt value show limite per page shown
            DisplayRecordPerPageCb.SelectedIndex = 0;
        }

        public void LoadProductList()
        {
            string _SerachCriteria = SerachTxtBx.Text;
            //Use productServices to Get Products by filtering
            List<Product> products = productServices.GetProducts(_SerachCriteria, _currentPage, _recordsPerPage,out _totalReords);
            _totalPage = (int)Math.Ceiling((double)_totalReords / _recordsPerPage);

            //Now we clear Screen of DataGridView 
            ProductDisplayDGV.Rows.Clear();

            int rowNumber = (_currentPage - 1) * _recordsPerPage + 1;
            //display DataGridView for products
            foreach (Product product in products)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ProductDisplayDGV, product.p_id, product.p_name, product.p_unitPerPerize, product.p_Stock, product.p_desc);
                rowNumber++;
                ProductDisplayDGV.Rows.Add(row);
            }
            UpdateNavigationLables();
            UpdatePaginationRecords();

        }

        private void UpdatePaginationRecords()
        {
            int totalPage = (int)Math.Ceiling((double)_totalReords / _recordsPerPage);
            CurrentPageLbl.Text = $"Page {_currentPage} of {totalPage} ";
            TotalRecordsLbl.Text = $"TatalRecords : {_totalReords} ";

        }

        private void UpdateNavigationLables()
        {
            NextBtn.Enabled = _currentPage < _totalPage;
            PervBtn.Enabled = _currentPage > 1;
            FirstPageBtn.Enabled = _currentPage > 1; //display when on the first page
            LastBtn.Enabled = _currentPage < _totalPage;

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ActionProduct actionProduct = new ActionProduct();
            //actionProduct.Show();
             DialogResult result = actionProduct.ShowDialog();
            actionProduct.saveBtn.Enabled = true;
            actionProduct.saveBtn.BackColor = Color.LightGray;
            if(result == DialogResult.OK)
            {

                LoadProductList();
            }

        }

        private void SerachTxtBx_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadProductList();
        }

        private void ProductDisplayDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = ProductDisplayDGV.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    int productId = Convert.ToInt32(ProductDisplayDGV.Rows[e.RowIndex].Cells[0].Value);
                    Product product = productServices.GetProductFromId(productId);
                    if (product != null)
                    {
                        ActionProduct actionProduct = new ActionProduct();
                        actionProduct.Show();
                        actionProduct.idTxtBx.Text = product.p_id.ToString();
                        actionProduct.pNameTxtBx.Text = product.p_name;
                        actionProduct.stockTxtBx.Text = product.p_Stock.ToString();
                        actionProduct.pPerizeTxtBx.Text = product.p_unitPerPerize.ToString();
                        actionProduct.descTxtBx.Text = product.p_desc;

                        //now action
                        actionProduct.saveBtn.Enabled = false;
                        actionProduct.updateBtn.Enabled = true;
                        actionProduct.updateBtn.BackColor = Color.White;
                        actionProduct.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you Sure want to delete this product", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int productDeleteId = Convert.ToInt32(ProductDisplayDGV.Rows[e.RowIndex].Cells[0].Value);
                        //cell the DeleteProduct  method from the productService to delete the product
                        productServices.DeleteProduct(productDeleteId);
                        MessageBox.Show(" delete Successfully ", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Reload the product list of neccessary
                        LoadProductList();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRecordPerPageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _recordsPerPage = int.Parse(DisplayRecordPerPageCb.SelectedItem.ToString());
            _currentPage = 1;//Reset change page when changing records per page
            LoadProductList();
        }

        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            if(_currentPage > 1)
            {
                _currentPage = 1; 
                LoadProductList();
                FirstPageBtn.BackColor = Color.Wheat;

            }
        }

        private void PervBtn_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadProductList();
                PervBtn.BackColor = Color.Wheat;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPage )
            {
                _currentPage++;
                LoadProductList();
                NextBtn.BackColor = Color.Wheat;
            }
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            if (_currentPage >0)
            {
                _currentPage =_totalPage;
                LoadProductList();
                LastBtn.BackColor = Color.Wheat;
            }
        }
    }
}
