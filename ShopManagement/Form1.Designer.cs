namespace ShopManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameTB = new TextBox();
            PasswordTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // UsernameTB
            // 
            UsernameTB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTB.Location = new Point(108, 202);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(222, 38);
            UsernameTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTB.Location = new Point(108, 288);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(222, 38);
            PasswordTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 179);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 265);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(174, 365);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 29);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Submit";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 62);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 3;
            label3.Text = "Login Page";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 438);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTB);
            Controls.Add(UsernameTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private Label label3;
    }
}
