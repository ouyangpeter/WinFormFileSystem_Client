namespace WinFormFileSystem.Forms
{
    partial class Form_FileSystem
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
            this.components = new System.ComponentModel.Container();
            this.listView_Dir = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_curDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_NewDirName = new System.Windows.Forms.TextBox();
            this.button_NewDir = new System.Windows.Forms.Button();
            this.textBox_NewFileName = new System.Windows.Forms.TextBox();
            this.button_NewFile = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Free = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Used = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Dir
            // 
            this.listView_Dir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Dir.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Dir.FullRowSelect = true;
            this.listView_Dir.Location = new System.Drawing.Point(31, 58);
            this.listView_Dir.Name = "listView_Dir";
            this.listView_Dir.Size = new System.Drawing.Size(638, 368);
            this.listView_Dir.TabIndex = 0;
            this.listView_Dir.UseCompatibleStateImageBehavior = false;
            this.listView_Dir.View = System.Windows.Forms.View.Details;
            this.listView_Dir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Dir_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文件类型";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件长度";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "父目录";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "创建用户";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "用户组";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "权限";
            this.columnHeader7.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // textBox_curDir
            // 
            this.textBox_curDir.Location = new System.Drawing.Point(141, 31);
            this.textBox_curDir.Name = "textBox_curDir";
            this.textBox_curDir.ReadOnly = true;
            this.textBox_curDir.Size = new System.Drawing.Size(528, 21);
            this.textBox_curDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前目录";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(31, 31);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(52, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "后退";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_NewDirName
            // 
            this.textBox_NewDirName.Location = new System.Drawing.Point(699, 93);
            this.textBox_NewDirName.Name = "textBox_NewDirName";
            this.textBox_NewDirName.Size = new System.Drawing.Size(137, 21);
            this.textBox_NewDirName.TabIndex = 4;
            // 
            // button_NewDir
            // 
            this.button_NewDir.Location = new System.Drawing.Point(867, 92);
            this.button_NewDir.Name = "button_NewDir";
            this.button_NewDir.Size = new System.Drawing.Size(75, 23);
            this.button_NewDir.TabIndex = 5;
            this.button_NewDir.Text = "新建文件夹";
            this.button_NewDir.UseVisualStyleBackColor = true;
            this.button_NewDir.Click += new System.EventHandler(this.button_NewDir_Click);
            // 
            // textBox_NewFileName
            // 
            this.textBox_NewFileName.Location = new System.Drawing.Point(699, 144);
            this.textBox_NewFileName.Name = "textBox_NewFileName";
            this.textBox_NewFileName.Size = new System.Drawing.Size(137, 21);
            this.textBox_NewFileName.TabIndex = 4;
            // 
            // button_NewFile
            // 
            this.button_NewFile.Location = new System.Drawing.Point(867, 143);
            this.button_NewFile.Name = "button_NewFile";
            this.button_NewFile.Size = new System.Drawing.Size(75, 23);
            this.button_NewFile.TabIndex = 5;
            this.button_NewFile.Text = "新建文件";
            this.button_NewFile.UseVisualStyleBackColor = true;
            this.button_NewFile.Click += new System.EventHandler(this.button_NewFile_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Refresh,
            this.toolStripButton_exit,
            this.toolStripButton_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Refresh.Image = global::WinFormFileSystem.Properties.Resources.refresh;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Refresh.Text = "刷新";
            this.toolStripButton_Refresh.Click += new System.EventHandler(this.toolStripButton_Refresh_Click);
            // 
            // toolStripButton_exit
            // 
            this.toolStripButton_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_exit.Image = global::WinFormFileSystem.Properties.Resources.exit;
            this.toolStripButton_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exit.Name = "toolStripButton_exit";
            this.toolStripButton_exit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_exit.Text = "退出";
            this.toolStripButton_exit.Click += new System.EventHandler(this.toolStripButton_exit_Click);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = global::WinFormFileSystem.Properties.Resources.save;
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_save.Text = "存盘";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_Free,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_Used});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "空闲盘块数：";
            // 
            // toolStripStatusLabel_Free
            // 
            this.toolStripStatusLabel_Free.Name = "toolStripStatusLabel_Free";
            this.toolStripStatusLabel_Free.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel_Free.Text = "NULL";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "使用盘块数：";
            // 
            // toolStripStatusLabel_Used
            // 
            this.toolStripStatusLabel_Used.Name = "toolStripStatusLabel_Used";
            this.toolStripStatusLabel_Used.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel_Used.Text = "NULL";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(699, 208);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(213, 173);
            this.textBox_input.TabIndex = 8;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(867, 387);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(75, 23);
            this.button_write.TabIndex = 9;
            this.button_write.Text = "写到文件";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // Form_FileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 461);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_NewFile);
            this.Controls.Add(this.button_NewDir);
            this.Controls.Add(this.textBox_NewFileName);
            this.Controls.Add(this.textBox_NewDirName);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_curDir);
            this.Controls.Add(this.listView_Dir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_FileSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件系统";
            this.Load += new System.EventHandler(this.Form_FileSystem_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Dir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox textBox_curDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_NewDirName;
        private System.Windows.Forms.Button button_NewDir;
        private System.Windows.Forms.TextBox textBox_NewFileName;
        private System.Windows.Forms.Button button_NewFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Free;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Used;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_exit;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_write;
    }
}