using Northwind.Bussiness.Abstrack;
using Northwind.Bussiness.Concrete;
using Northwind.DataAcces.Concrete.EntityFramework;
using Northwind.DataAcces.Concrete.NHybernate;
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
using System.Globalization;
using Northwind.Bussiness.DependencyResolvers.Ninject;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductAddName.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)
                });
                MessageBox.Show("Data Saved");
                LoadProduct();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(UpdateCbxCategoryId.SelectedValue),
                    ProductName = UpdateTbxProductName.Text,
                    QuantityPerUnit = UpdateTbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(UpdateTbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(UpdateTbxUnitinStoc.Text)
                });
                MessageBox.Show("Data Updated");
                LoadProduct();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            LoadProduct();
        }
        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            UpdateCbxCategoryId.SelectedValue = row.Cells[1].Value;

            UpdateTbxProductName.Text = row.Cells[2].Value.ToString();
            UpdateTbxUnitPrice.Text = row.Cells[3].Value.ToString();
            UpdateTbxQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            UpdateTbxUnitinStoc.Text = row.Cells[5].Value.ToString();
        }
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            UpdateCbxCategoryId.DataSource = _categoryService.GetAll();
            UpdateCbxCategoryId.DisplayMember = "CategoryName";
            UpdateCbxCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {


            }

        }
        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
            }
            else
            {
                LoadProduct();
            }

        }


        //---------------------------------------------------------------
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //---------Drag navPanel-------------
        bool drag;
        Point offs;
        private void navPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            offs = e.Location;
        }
        private void navPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offs.X, currentScreenPos.Y - offs.Y);
            }
        }
        private void navPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //---------Drag navPanel-------------
        //---------------------------------------------------------------
    }
}
