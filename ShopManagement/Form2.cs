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

        public int Temp_Products_SelectedIndex;
        public int Temp_Orders_SelectedIndex;


        public Form2()
        {
            InitializeComponent();
        }

        private void UpdateProductListBox()
        {
            Models.DatabaseContext DatabaseContext = null;
            DatabaseContext = new Models.DatabaseContext();

            var products = DatabaseContext.Products.ToList();

            BindingList<Product> ProductsBL = new BindingList<Product>(products);

            ProductsListBox.DataSource = ProductsBL;

            OrdersListBox.SelectedIndex = Temp_Orders_SelectedIndex;
            ProductsListBox.SelectedIndex = Temp_Products_SelectedIndex;

        }

        private void UpdateOrderListBoxAndOrderProducts()
        {
            DatabaseContext = null;
            try
            {
                DatabaseContext = new Models.DatabaseContext();
                var UserOrders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();

                var Orders = UserOrders;

                BindingList<Order> OrdersBL = new BindingList<Order>(Orders);

                OrdersListBox.DataSource = OrdersBL;

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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Username = string.Empty;
            Password = string.Empty;
            IsLogin = false;
            ProductUpdateTimer.Enabled = false;

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ProductUpdateTimer.Enabled = true;
            UsernameLbl.Text = AppState.Instance.Username;
            DatabaseContext = null;
            OrdersListBox.DataSource = null;

            Temp_Products_SelectedIndex = 0;
            Temp_Orders_SelectedIndex = 0;

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

        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseContext = null;
            Temp_Products_SelectedIndex = ProductsListBox.SelectedIndex;
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
            Temp_Orders_SelectedIndex = OrdersListBox.SelectedIndex;
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
                UpdateOrderListBoxAndOrderProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("please add an Order and then select your product");
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
            UpdateOrderListBoxAndOrderProducts();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();
                var CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();

                var cur = OrdersListBox.SelectedIndex;
                var Orders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();
                var SelectedOrder = Orders[cur];

                var curProduct = EditProductsListBox.SelectedIndex;

                var ProductsInOrder = SelectedOrder.Products.ToList();
                Product? SelectedProduct = ProductsInOrder[curProduct];

                //DatabaseContext.
                SelectedOrder.Products.Remove(SelectedProduct);

                DatabaseContext.SaveChanges();
                MessageBox.Show("Product Removed Successfuly from Selected Order");
                UpdateOrderListBoxAndOrderProducts();

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

        private void ProductUpdateTimer_Tick(object sender, EventArgs e)
        {
            //UpdateProductListBox();
            //UpdateOrderListBoxAndOrderProducts();
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            DatabaseContext = null;

            try
            {
                DatabaseContext = new DatabaseContext();

                var CurrentUser = DatabaseContext.Users.Where(current => current.UserName == Username && current.Password == Password).ToList().FirstOrDefault() ?? new Models.User();

                var UserOrders = DatabaseContext.Orders.Where(current => current.User.ID == CurrentUser.ID).ToList();

                var Order = UserOrders[OrdersListBox.SelectedIndex];

                for (int i = 0; i <= Order.Products.Count - 1; i++)
                {
                    Order.Products.RemoveAt(i);
                }

                DatabaseContext.Orders.Remove(Order);

                DatabaseContext.SaveChanges();

                BindingList<Product> ProductsBL = new BindingList<Product>();
                EditProductsListBox.DataSource = ProductsBL;


                UpdateOrderListBoxAndOrderProducts();

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
    }
}
