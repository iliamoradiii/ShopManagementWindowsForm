using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopManagement
{
    public partial class Form3 : Form
    {
        string Username = AppState.Instance.Username;
        string Password = AppState.Instance.Password;
        bool IsLogin = AppState.Instance.IsLogin;

        private Models.DatabaseContext DatabaseContext { get; set; }

        public Models.User CurrentUser;
        public Form3()
        {
            InitializeComponent();
        }

        private void EmptyAddProductFields()
        {
            ProductNameTxt.Text = string.Empty;
            ProductDescriptionTxt.Text = string.Empty;
            ProductPriceTxt.Text = string.Empty;
            CategoriesListBox.SelectedIndex = 0;
        }
        private void UpdateProductListBox()
        {
            DatabaseContext DatabaseContext = null;
            DatabaseContext = new DatabaseContext();

            var products = DatabaseContext.Products.ToList();

            BindingList<Product> ProductsBL = new BindingList<Product>(products);

            AllProductsListBox.DataSource = ProductsBL;
        }

        private void UpdateCategoryListBox()
        {
            DatabaseContext DatabaseContext = null;
            DatabaseContext = new DatabaseContext();

            var Categories = DatabaseContext.Categories.ToList();

            BindingList<Category> CategorysBL = new BindingList<Category>(Categories);

            CategoriesListBox.DataSource = CategorysBL;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Username = string.Empty;
            Password = string.Empty;
            IsLogin = false;

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void UserPanelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = AppState.Instance.Username;

            DatabaseContext = null;

            try
            {
                DatabaseContext = new Models.DatabaseContext();

                var Products = DatabaseContext.Products.ToList();
                var Categories = DatabaseContext.Categories.ToList();

                AllProductsListBox.ValueMember = "ID";
                AllProductsListBox.DisplayMember = "Name";
                AllProductsListBox.DataSource = Products;


                CategoriesListBox.ValueMember = "Name";
                CategoriesListBox.DisplayMember = "Name";
                CategoriesListBox.DataSource = Categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;
            var Cname = CategoryNameTxt.Text;

            CategoryNameTxt.Text = string.Empty;

            if (Cname.Trim() == string.Empty)
            {
                MessageBox.Show("Category field is empty !");
                return;
            }

            try
            {
                DatabaseContext = new DatabaseContext();

                var SimularCategories = DatabaseContext.Categories.Where(current => current.Name == Cname).ToList();

                if (SimularCategories.Count() > 0)
                {
                    MessageBox.Show("Category already exists !");
                    return;
                }

                Category category = new Category();

                category.Name = Cname;
                category.Products = new List<Product>();

                DatabaseContext.Categories.Add(category);
                DatabaseContext.SaveChanges();
                UpdateCategoryListBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            var Pname = ProductNameTxt.Text;
            var Pdescription = ProductDescriptionTxt.Text;

            int ProductPrice;

            if (!(int.TryParse(ProductPriceTxt.Text, out ProductPrice)))
            {
                MessageBox.Show("Please enter a valid price !");
                return;
            }



            if (Pname.Trim() == string.Empty || Pdescription.Trim() == string.Empty)
            {
                MessageBox.Show("make sure there isnt any empty field!");
                return;
            }


            try
            {
                DatabaseContext = new DatabaseContext();

                var SimularProducts = DatabaseContext.Products.Where(current => current.Name == Pname);

                if (SimularProducts.Count() > 0)
                {
                    MessageBox.Show("[ Conflict ] -> Product already exists !");
                    return;
                }

                var AllCategories = DatabaseContext.Categories.ToList();
                Category SelectedCategory = AllCategories[CategoriesListBox.SelectedIndex];

                Product product = new Product();
                product.Name = Pname;
                product.Description = Pdescription;
                product.Category = SelectedCategory;
                product.Price = ProductPrice;
                product.PicName = " ";
                product.Orders = new List<Order>();

                DatabaseContext.Products.Add(product);

                DatabaseContext.SaveChanges();

                UpdateProductListBox();
                EmptyAddProductFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }
        }

        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                string Cname = CategoryNameTxt.Text;

                if (Cname.Trim() == string.Empty)
                {
                    MessageBox.Show("Category name is empty !");
                    return;
                }

                var Category = DatabaseContext.Categories.Where(current => current.Name == Cname).ToList();

                if (Category.Count == 0)
                {
                    MessageBox.Show("Category not found !");
                    return;
                }

                DatabaseContext.Categories.Remove(Category[0]);
                DatabaseContext.SaveChanges();
                UpdateCategoryListBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = CategoriesListBox.SelectedItem as Category;
            if (selectedCategory != null)
            {
                CategoryNameTxt.Text = selectedCategory.Name;
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                var Products = DatabaseContext.Products.ToList();

                var SelectedProduct = Products[AllProductsListBox.SelectedIndex];

                DatabaseContext.Products.Remove(SelectedProduct);
                DatabaseContext.SaveChanges();
                UpdateProductListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DatabaseContext != null)
                {
                    DatabaseContext.Dispose();
                    DatabaseContext = null;
                }
            }
        }
    }
}
