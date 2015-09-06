namespace WinFormFileSystem.Forms
{
    partial class Form_ListUsers
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
            this.columnHeader_uname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_passwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_UserLists = new System.Windows.Forms.ListView();
            this.columnHeader_uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_gid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // columnHeader_uname
            // 
            this.columnHeader_uname.Text = "用户名";
            this.columnHeader_uname.Width = 120;
            // 
            // columnHeader_passwd
            // 
            this.columnHeader_passwd.Text = "密码";
            this.columnHeader_passwd.Width = 100;
            // 
            // listView_UserLists
            // 
            this.listView_UserLists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_uid,
            this.columnHeader_uname,
            this.columnHeader_passwd,
            this.columnHeader_gid});
            this.listView_UserLists.FullRowSelect = true;
            this.listView_UserLists.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_UserLists.Location = new System.Drawing.Point(12, 12);
            this.listView_UserLists.Name = "listView_UserLists";
            this.listView_UserLists.Size = new System.Drawing.Size(417, 370);
            this.listView_UserLists.TabIndex = 0;
            this.listView_UserLists.UseCompatibleStateImageBehavior = false;
            this.listView_UserLists.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_uid
            // 
            this.columnHeader_uid.Text = "用户编号";
            this.columnHeader_uid.Width = 80;
            // 
            // columnHeader_gid
            // 
            this.columnHeader_gid.Text = "组编号";
            this.columnHeader_gid.Width = 80;
            // 
            // Form_ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 394);
            this.Controls.Add(this.listView_UserLists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ListUsers";
            this.Load += new System.EventHandler(this.Form_ListUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader_uname;
        private System.Windows.Forms.ColumnHeader columnHeader_passwd;
        private System.Windows.Forms.ListView listView_UserLists;
        private System.Windows.Forms.ColumnHeader columnHeader_uid;
        private System.Windows.Forms.ColumnHeader columnHeader_gid;

    }
}