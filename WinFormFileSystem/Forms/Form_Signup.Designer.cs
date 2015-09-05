namespace WinFormFileSystem.Forms
{
    partial class Form_Signup
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
            this.button_signup = new System.Windows.Forms.Button();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(95, 183);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(102, 28);
            this.button_signup.TabIndex = 10;
            this.button_signup.Text = "注册";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Location = new System.Drawing.Point(98, 120);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(156, 21);
            this.textBox_passwd.TabIndex = 9;
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(98, 50);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(156, 21);
            this.textBox_account.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("XHei SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("XHei SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_1.Location = new System.Drawing.Point(30, 50);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(47, 19);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "账号";
            // 
            // Form_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_1;
    }
}