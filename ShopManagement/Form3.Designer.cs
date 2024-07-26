namespace ShopManagement
{
    partial class Form3
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
            ProductNameTxt = new TextBox();
            ProductDescriptionTxt = new TextBox();
            ProductPriceTxt = new TextBox();
            CategoriesListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CategoryNameTxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AddProductBtn = new Button();
            AddCategoryBtn = new Button();
            AllProductsListBox = new ListBox();
            UserNameLbl = new Label();
            label10 = new Label();
            UserPanelBtn = new Button();
            LogoutBtn = new Button();
            DeleteCategoryBtn = new Button();
            DeleteProductBtn = new Button();
            SuspendLayout();
            // 
            // ProductNameTxt
            // 
            ProductNameTxt.Location = new Point(217, 359);
            ProductNameTxt.Name = "ProductNameTxt";
            ProductNameTxt.Size = new Size(248, 27);
            ProductNameTxt.TabIndex = 0;
            // 
            // ProductDescriptionTxt
            // 
            ProductDescriptionTxt.Location = new Point(217, 413);
            ProductDescriptionTxt.Multiline = true;
            ProductDescriptionTxt.Name = "ProductDescriptionTxt";
            ProductDescriptionTxt.Size = new Size(248, 137);
            ProductDescriptionTxt.TabIndex = 1;
            // 
            // ProductPriceTxt
            // 
            ProductPriceTxt.Location = new Point(217, 577);
            ProductPriceTxt.Name = "ProductPriceTxt";
            ProductPriceTxt.Size = new Size(248, 27);
            ProductPriceTxt.TabIndex = 2;
            // 
            // CategoriesListBox
            // 
            CategoriesListBox.FormattingEnabled = true;
            CategoriesListBox.Location = new Point(217, 635);
            CategoriesListBox.Name = "CategoriesListBox";
            CategoriesListBox.Size = new Size(248, 104);
            CategoriesListBox.TabIndex = 3;
            CategoriesListBox.SelectedIndexChanged += CategoriesListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 362);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 416);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 4;
            label2.Text = "Product Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 580);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 635);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 4;
            label4.Text = "Product Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 259);
            label5.Name = "label5";
            label5.Size = new Size(291, 41);
            label5.TabIndex = 5;
            label5.Text = "Add Product Section";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 300);
            label6.Name = "label6";
            label6.Size = new Size(465, 20);
            label6.TabIndex = 6;
            label6.Text = "____________________________________________________________________________";
            // 
            // CategoryNameTxt
            // 
            CategoryNameTxt.Location = new Point(815, 355);
            CategoryNameTxt.Name = "CategoryNameTxt";
            CategoryNameTxt.Size = new Size(211, 27);
            CategoryNameTxt.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(711, 259);
            label7.Name = "label7";
            label7.Size = new Size(300, 41);
            label7.TabIndex = 5;
            label7.Text = "Add CategorySection";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 300);
            label8.Name = "label8";
            label8.Size = new Size(465, 20);
            label8.TabIndex = 6;
            label8.Text = "____________________________________________________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(666, 358);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 4;
            label9.Text = "Category Name";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(64, 775);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(401, 29);
            AddProductBtn.TabIndex = 8;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.Location = new Point(666, 416);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(360, 29);
            AddCategoryBtn.TabIndex = 8;
            AddCategoryBtn.Text = "Add Category";
            AddCategoryBtn.UseVisualStyleBackColor = true;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // AllProductsListBox
            // 
            AllProductsListBox.FormattingEnabled = true;
            AllProductsListBox.Location = new Point(666, 577);
            AllProductsListBox.Name = "AllProductsListBox";
            AllProductsListBox.Size = new Size(360, 184);
            AllProductsListBox.TabIndex = 9;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.ForeColor = SystemColors.Highlight;
            UserNameLbl.Location = new Point(89, 46);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(73, 20);
            UserNameLbl.TabIndex = 10;
            UserNameLbl.Text = "username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 46);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 11;
            label10.Text = "User :";
            // 
            // UserPanelBtn
            // 
            UserPanelBtn.Location = new Point(999, 46);
            UserPanelBtn.Name = "UserPanelBtn";
            UserPanelBtn.Size = new Size(103, 29);
            UserPanelBtn.TabIndex = 15;
            UserPanelBtn.Text = "User Panel";
            UserPanelBtn.UseVisualStyleBackColor = true;
            UserPanelBtn.Click += UserPanelBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.ForeColor = Color.DarkRed;
            LogoutBtn.Location = new Point(1016, 81);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(70, 29);
            LogoutBtn.TabIndex = 14;
            LogoutBtn.Text = "LogOut";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // DeleteCategoryBtn
            // 
            DeleteCategoryBtn.Location = new Point(666, 451);
            DeleteCategoryBtn.Name = "DeleteCategoryBtn";
            DeleteCategoryBtn.Size = new Size(360, 29);
            DeleteCategoryBtn.TabIndex = 16;
            DeleteCategoryBtn.Text = "Delete Category";
            DeleteCategoryBtn.UseVisualStyleBackColor = true;
            DeleteCategoryBtn.Click += DeleteCategoryBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(666, 775);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(360, 29);
            DeleteProductBtn.TabIndex = 17;
            DeleteProductBtn.Text = "Delete Product";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 853);
            Controls.Add(DeleteProductBtn);
            Controls.Add(DeleteCategoryBtn);
            Controls.Add(UserPanelBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(UserNameLbl);
            Controls.Add(label10);
            Controls.Add(AllProductsListBox);
            Controls.Add(AddCategoryBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(CategoryNameTxt);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(CategoriesListBox);
            Controls.Add(ProductPriceTxt);
            Controls.Add(ProductDescriptionTxt);
            Controls.Add(ProductNameTxt);
            Name = "Form3";
            Text = "Admin Panel";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductNameTxt;
        private TextBox ProductDescriptionTxt;
        private TextBox ProductPriceTxt;
        private ListBox CategoriesListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox CategoryNameTxt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button AddProductBtn;
        private Button AddCategoryBtn;
        private ListBox AllProductsListBox;
        private Label UserNameLbl;
        private Label label10;
        private Button UserPanelBtn;
        private Button LogoutBtn;
        private Button DeleteCategoryBtn;
        private Button DeleteProductBtn;
    }
}