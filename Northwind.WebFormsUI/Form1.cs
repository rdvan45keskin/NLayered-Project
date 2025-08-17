using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService;
        ICategoryService _categoryService;
        private string _searchKey = string.Empty; // Son arama anahtar kelimesini saklar.
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadCategoriesAdd();
            LoadCategoriesUpdate();
        }


        private void LoadProducts() 
        {
            dgvProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void SearchProduct(string key)
        {
            _searchKey = key;
            if (String.IsNullOrEmpty(key))
            {
                LoadProducts();
            }
            else
            {
                dgvProduct.DataSource = _productService.GetProductsByProductName(key);
            }
        }

        private void LoadCategoriesAdd()
        {
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
        }

        private void LoadCategoriesUpdate()
        {
            cbxUpdateCategoryId.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryId.DisplayMember = "CategoryName";
            cbxUpdateCategoryId.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductsByCategory((int)cbxCategory.SelectedValue);
            }
            catch
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbxSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName.Text,
                    QuantityPerUnit = tbxStockAmount.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxQuantityPerUnit.Text)
                });
                MessageBox.Show("Ürün Eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            { 
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                    ProductName = tbxUpdateProductName.Text,
                    QuantityPerUnit = tbxUpdateStockAmount.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateQuantityPerUnit.Text)
                });
                MessageBox.Show("Ürün Güncellendi");
                SearchProduct(_searchKey);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProduct.CurrentRow;
            cbxUpdateCategoryId.SelectedValue = row.Cells[1].Value;
            tbxUpdateProductName.Text = row.Cells[2].Value.ToString();
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateStockAmount.Text = row.Cells[4].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow!=null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    SearchProduct(_searchKey);
                }
                catch (Exception exception) 
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
            
        }
    }
}
