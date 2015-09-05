namespace WinFormFileSystem.Forms
{
    partial class Form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.button_signin = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ListUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_test = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("XHei SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_1.Location = new System.Drawing.Point(82, 79);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(47, 19);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "账号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("XHei SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "密码";
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(150, 79);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(156, 21);
            this.textBox_account.TabIndex = 2;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Location = new System.Drawing.Point(150, 149);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(156, 21);
            this.textBox_passwd.TabIndex = 3;
            this.textBox_passwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_passwd_KeyDown);
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(86, 212);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(102, 28);
            this.button_signup.TabIndex = 4;
            this.button_signup.Text = "注册";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click_1);
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(204, 212);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(102, 28);
            this.button_signin.TabIndex = 5;
            this.button_signin.Text = "登录";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ListUsers,
            this.toolStripButton_test});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_ListUsers
            // 
            this.toolStripButton_ListUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ListUsers.Image = global::WinFormFileSystem.Properties.Resources.Users;
            this.toolStripButton_ListUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ListUsers.Name = "toolStripButton_ListUsers";
            this.toolStripButton_ListUsers.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ListUsers.Text = "查看用户";
            this.toolStripButton_ListUsers.Click += new System.EventHandler(this.toolStripButton_ListUsers_Click);
            // 
            // toolStripButton_test
            // 
            this.toolStripButton_test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_test.Image = global::WinFormFileSystem.Properties.Resources.Fire;
            this.toolStripButton_test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_test.Name = "toolStripButton_test";
            this.toolStripButton_test.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_test.Text = "测试";
            this.toolStripButton_test.Click += new System.EventHandler(this.toolStripButton_test_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_ListUsers;
        private System.Windows.Forms.ToolStripButton toolStripButton_test;
    }
}

