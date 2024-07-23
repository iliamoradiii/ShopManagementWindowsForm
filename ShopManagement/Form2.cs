using Microsoft.VisualBasic.ApplicationServices;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{

    public partial class Form2 : Form
    {
        string Username = AppState.Instance.Username;
        string Password = AppState.Instance.Password;
        bool IsLogin = AppState.Instance.IsLogin;

        private Models.DatabaseContext DatabaseContext { get; set; }

        public Models.User CurrentUser;

        public Form2()
        {
            InitializeComponent();
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

        private void Form2_Load(object sender, EventArgs e)
        {

            UsernameLbl.Text = AppState.Instance.Username;
            DatabaseContext = null;
            OrdersListBox.DataSource = null;

            try
            {
                DatabaseContext = new Models.DatabaseContext();

                CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();

                var Products = DatabaseContext.Products.ToList();
                var Orders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();

                ProductsListBox.Items.Clear();
                OrdersListBox.Items.Clear();

                ProductsListBox.ValueMember = "ID";
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.DataSource = Products;


                OrdersListBox.ValueMember = "OrderID";
                OrdersListBox.DisplayMember = "OrderID";
                OrdersListBox.DataSource = Orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form2 : " + ex.Message);
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

        private void DoTheTest_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                var CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();
                var CustomeCategory = DatabaseContext.Categories.Where(current => current.Name == "Laptop").ToList().FirstOrDefault() ?? new Category();
                //var Iphone13Promax = DatabaseContext.Products.Where(current => current.Name == "IPhone 13 promax").ToList().FirstOrDefault() ?? new Product();

                #region Add New Order
                //Order order1 = new Order();
                //order1.User = CurrentUser;

                //order1.Products = new List<Product>();

                //order1.Products.Add(Iphone13Promax);

                //DatabaseContext.Orders.Add(order1);

                //DatabaseContext.SaveChanges();
                #endregion

                #region Add New Product
                //Product product = new Product();
                //product.Name = "Asus VivoBook";
                //product.Description = "this description for Asus VivoBook";
                //product.Category = CustomeCategory;
                //product.Price = 500;
                //product.PicName = " ";
                //product.Orders = new List<Order>();

                //DatabaseContext.Products.Add(product);

                //DatabaseContext.SaveChanges();
                #endregion

                #region New Category
                Category category = new Category();

                category.Name = "Laptop";
                category.Products = new List<Product>();

                DatabaseContext.Categories.Add(category);

                DatabaseContext.SaveChanges();

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form2 : " + ex.Message);
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

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                var Products = DatabaseContext.Products.ToList();
                var SelectedProduct = Products[ProductsListBox.SelectedIndex];

                CategoryLbl.Text = SelectedProduct.Category.Name;
                PriceLbl.Text = SelectedProduct.Price.ToString();
                ProductDescTxt.Text = SelectedProduct.Description;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form2 : " + ex.Message);
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

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                var CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();

                var Orders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();

                var SelectedOrder = Orders[OrdersListBox.SelectedIndex];

                var Products = SelectedOrder.Products.ToList();


                EditProductsListBox.DataSource = null;

                EditProductsListBox.Items.Clear();

                EditProductsListBox.ValueMember = "ID";
                EditProductsListBox.DisplayMember = "Name";
                EditProductsListBox.DataSource = Products;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form2 : " + ex.Message);
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

        private void AddSPTSO_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();
                var CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();

                var Products = DatabaseContext.Products.ToList();
                var SelectedProduct = Products[ProductsListBox.SelectedIndex];

                var cur = OrdersListBox.SelectedIndex;
                var Orders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();
                var SelectedOrder = Orders[cur];


                SelectedOrder.User = CurrentUser;
                SelectedOrder.Products.Add(SelectedProduct);

                DatabaseContext.Orders.AddOrUpdate(SelectedOrder);

                DatabaseContext.SaveChanges();

                OrdersListBox.SelectedIndex = cur;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Form2 : " + ex.Message);
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

        private void AddNewOrder_Click(object sender, EventArgs e)
        {

            DatabaseContext DatabaseContext = new DatabaseContext();

            var user = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault();

            Order NewOrder = new Order();

            NewOrder.User = user;
            NewOrder.Products = new List<Models.Product>();

            DatabaseContext.Orders.Add(NewOrder);
            DatabaseContext.SaveChanges();

        }
    }
}
