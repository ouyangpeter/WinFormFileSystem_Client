﻿namespace WinFormFileSystem.Forms
{
    partial class Form_test
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_test = new System.Windows.Forms.RadioButton();
            this.radioButton_getUserCounts = new System.Windows.Forms.RadioButton();
            this.radioButton_login = new System.Windows.Forms.RadioButton();
            this.radioButton_isAvailable = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 265);
            this.textBox1.TabIndex = 1;
            // 
            // radioButton_test
            // 
            this.radioButton_test.AutoSize = true;
            this.radioButton_test.Checked = true;
            this.radioButton_test.Location = new System.Drawing.Point(13, 18);
            this.radioButton_test.Name = "radioButton_test";
            this.radioButton_test.Size = new System.Drawing.Size(47, 16);
            this.radioButton_test.TabIndex = 2;
            this.radioButton_test.TabStop = true;
            this.radioButton_test.Text = "test";
            this.radioButton_test.UseVisualStyleBackColor = true;
            // 
            // radioButton_getUserCounts
            // 
            this.radioButton_getUserCounts.AutoSize = true;
            this.radioButton_getUserCounts.Location = new System.Drawing.Point(12, 40);
            this.radioButton_getUserCounts.Name = "radioButton_getUserCounts";
            this.radioButton_getUserCounts.Size = new System.Drawing.Size(101, 16);
            this.radioButton_getUserCounts.TabIndex = 3;
            this.radioButton_getUserCounts.Text = "getUserCounts";
            this.radioButton_getUserCounts.UseVisualStyleBackColor = true;
            // 
            // radioButton_login
            // 
            this.radioButton_login.AutoSize = true;
            this.radioButton_login.Location = new System.Drawing.Point(12, 62);
            this.radioButton_login.Name = "radioButton_login";
            this.radioButton_login.Size = new System.Drawing.Size(53, 16);
            this.radioButton_login.TabIndex = 5;
            this.radioButton_login.Text = "Login";
            this.radioButton_login.UseVisualStyleBackColor = true;
            // 
            // radioButton_isAvailable
            // 
            this.radioButton_isAvailable.AutoSize = true;
            this.radioButton_isAvailable.Location = new System.Drawing.Point(12, 84);
            this.radioButton_isAvailable.Name = "radioButton_isAvailable";
            this.radioButton_isAvailable.Size = new System.Drawing.Size(89, 16);
            this.radioButton_isAvailable.TabIndex = 4;
            this.radioButton_isAvailable.Text = "IsAvailable";
            this.radioButton_isAvailable.UseVisualStyleBackColor = true;
            // 
            // Form_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 289);
            this.Controls.Add(this.radioButton_login);
            this.Controls.Add(this.radioButton_isAvailable);
            this.Controls.Add(this.radioButton_getUserCounts);
            this.Controls.Add(this.radioButton_test);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_test;
        private System.Windows.Forms.RadioButton radioButton_getUserCounts;
        private System.Windows.Forms.RadioButton radioButton_login;
        private System.Windows.Forms.RadioButton radioButton_isAvailable;
    }
}