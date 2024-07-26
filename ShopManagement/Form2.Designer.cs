namespace ShopManagement
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ProductsListBox = new ListBox();
            label1 = new Label();
            Label77777 = new Label();
            OrdersListBox = new ListBox();
            label2 = new Label();
            LogoutBtn = new Button();
            label3 = new Label();
            UsernameLbl = new Label();
            EditProductsListBox = new ListBox();
            DeleteProductBtn = new Button();
            label5 = new Label();
            CategoryLbl = new Label();
            AddNewOrder = new Button();
            DeleteOrderBtn = new Button();
            label4 = new Label();
            PriceLbl = new Label();
            ProductDescTxt = new TextBox();
            label6 = new Label();
            AdminPanelBtn = new Button();
            AddSPTSO = new Button();
            ProductUpdateTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.Location = new Point(14, 164);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(381, 244);
            ProductsListBox.TabIndex = 0;
            ProductsListBox.SelectedIndexChanged += ProductsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 122);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // Label77777
            // 
            Label77777.AutoSize = true;
            Label77777.Location = new Point(117, 122);
            Label77777.Name = "Label77777";
            Label77777.Size = new Size(80, 20);
            Label77777.TabIndex = 3;
            Label77777.Text = "Category : ";
            // 
            // OrdersListBox
            // 
            OrdersListBox.FormattingEnabled = true;
            OrdersListBox.Location = new Point(14, 551);
            OrdersListBox.Name = "OrdersListBox";
            OrdersListBox.Size = new Size(300, 104);
            OrdersListBox.TabIndex = 4;
            OrdersListBox.SelectedIndexChanged += OrdersListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 513);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Your Orders";
            label2.UseWaitCursor = true;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.ForeColor = Color.DarkRed;
            LogoutBtn.Location = new Point(576, 63);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(70, 29);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "LogOut";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "User :";
            // 
            // UsernameLbl
            // 
            UsernameLbl.AutoSize = true;
            UsernameLbl.ForeColor = SystemColors.Highlight;
            UsernameLbl.Location = new Point(63, 37);
            UsernameLbl.Name = "UsernameLbl";
            UsernameLbl.Size = new Size(73, 20);
            UsernameLbl.TabIndex = 2;
            UsernameLbl.Text = "username";
            // 
            // EditProductsListBox
            // 
            EditProductsListBox.FormattingEnabled = true;
            EditProductsListBox.Location = new Point(379, 551);
            EditProductsListBox.Name = "EditProductsListBox";
            EditProductsListBox.Size = new Size(283, 104);
            EditProductsListBox.TabIndex = 6;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(379, 676);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(283, 29);
            DeleteProductBtn.TabIndex = 7;
            DeleteProductBtn.Text = "Delete Product From Order";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(379, 513);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 3;
            label5.Text = "Edit Order";
            // 
            // CategoryLbl
            // 
            CategoryLbl.AutoSize = true;
            CategoryLbl.ForeColor = SystemColors.Highlight;
            CategoryLbl.Location = new Point(194, 122);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Size = new Size(69, 20);
            CategoryLbl.TabIndex = 2;
            CategoryLbl.Text = "Category";
            // 
            // AddNewOrder
            // 
            AddNewOrder.Location = new Point(14, 429);
            AddNewOrder.Name = "AddNewOrder";
            AddNewOrder.Size = new Size(648, 38);
            AddNewOrder.TabIndex = 8;
            AddNewOrder.Text = "Add New Order";
            AddNewOrder.UseVisualStyleBackColor = true;
            AddNewOrder.Click += AddNewOrder_Click;
            // 
            // DeleteOrderBtn
            // 
            DeleteOrderBtn.Location = new Point(12, 676);
            DeleteOrderBtn.Name = "DeleteOrderBtn";
            DeleteOrderBtn.Size = new Size(302, 29);
            DeleteOrderBtn.TabIndex = 9;
            DeleteOrderBtn.Text = "Delete Order";
            DeleteOrderBtn.UseVisualStyleBackColor = true;
            DeleteOrderBtn.Click += DeleteOrderBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 122);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Price :";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.ForeColor = SystemColors.Highlight;
            PriceLbl.Location = new Point(379, 122);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(41, 20);
            PriceLbl.TabIndex = 2;
            PriceLbl.Text = "Price";
            // 
            // ProductDescTxt
            // 
            ProductDescTxt.Location = new Point(415, 164);
            ProductDescTxt.Multiline = true;
            ProductDescTxt.Name = "ProductDescTxt";
            ProductDescTxt.Size = new Size(247, 181);
            ProductDescTxt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 141);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 12;
            label6.Text = "Product Description";
            // 
            // AdminPanelBtn
            // 
            AdminPanelBtn.Location = new Point(559, 28);
            AdminPanelBtn.Name = "AdminPanelBtn";
            AdminPanelBtn.Size = new Size(103, 29);
            AdminPanelBtn.TabIndex = 13;
            AdminPanelBtn.Text = "Admin Panel";
            AdminPanelBtn.UseVisualStyleBackColor = true;
            AdminPanelBtn.Click += AdminPanelBtn_Click;
            // 
            // AddSPTSO
            // 
            AddSPTSO.Location = new Point(415, 351);
            AddSPTSO.Name = "AddSPTSO";
            AddSPTSO.Size = new Size(247, 57);
            AddSPTSO.TabIndex = 14;
            AddSPTSO.Text = "add selected product to selected order";
            AddSPTSO.UseVisualStyleBackColor = true;
            AddSPTSO.Click += AddSPTSO_Click;
            // 
            // ProductUpdateTimer
            // 
            ProductUpdateTimer.Interval = 10000;
            ProductUpdateTimer.Tick += ProductUpdateTimer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 749);
            Controls.Add(AddSPTSO);
            Controls.Add(AdminPanelBtn);
            Controls.Add(label6);
            Controls.Add(ProductDescTxt);
            Controls.Add(label4);
            Controls.Add(DeleteOrderBtn);
            Controls.Add(AddNewOrder);
            Controls.Add(DeleteProductBtn);
            Controls.Add(EditProductsListBox);
            Controls.Add(LogoutBtn);
            Controls.Add(OrdersListBox);
            Controls.Add(label5);
            Controls.Add(Label77777);
            Controls.Add(label2);
            Controls.Add(PriceLbl);
            Controls.Add(CategoryLbl);
            Controls.Add(UsernameLbl);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ProductsListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Shop";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ProductsListBox;
        private Button AddToOrderBtn;
        private Label label1;
        private Label Label77777;
        private ListBox OrdersListBox;
        private Label label2;
        private Button LogoutBtn;
        private Label label3;
        private Label UsernameLbl;
        private ListBox EditProductsListBox;
        private Button DeleteProductBtn;
        private Label label5;
        private Label CategoryLbl;
        private Button AddNewOrder;
        private Button DeleteOrderBtn;
        private Label label4;
        private Label PriceLbl;
        private TextBox ProductDescTxt;
        private Label label6;
        private Button AdminPanelBtn;
        private Button AddSPTSO;
        private System.Windows.Forms.Timer ProductUpdateTimer;
    }
}