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
            this.toolStripMenuItem_NewDir = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_curDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_NewDirName = new System.Windows.Forms.TextBox();
            this.button_NewDir = new System.Windows.Forms.Button();
            this.textBox_NewFileName = new System.Windows.Forms.TextBox();
            this.button_NewFile = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
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
            this.listView_Dir.Location = new System.Drawing.Point(31, 41);
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
            this.toolStripMenuItem_NewDir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // toolStripMenuItem_NewDir
            // 
            this.toolStripMenuItem_NewDir.Name = "toolStripMenuItem_NewDir";
            this.toolStripMenuItem_NewDir.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem_NewDir.Text = "新建文件夹";
            this.toolStripMenuItem_NewDir.Click += new System.EventHandler(this.toolStripMenuItem_NewDir_Click);
            // 
            // textBox_curDir
            // 
            this.textBox_curDir.Location = new System.Drawing.Point(141, 14);
            this.textBox_curDir.Name = "textBox_curDir";
            this.textBox_curDir.ReadOnly = true;
            this.textBox_curDir.Size = new System.Drawing.Size(528, 21);
            this.textBox_curDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前目录";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(31, 14);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(52, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "后退";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_NewDirName
            // 
            this.textBox_NewDirName.Location = new System.Drawing.Point(699, 76);
            this.textBox_NewDirName.Name = "textBox_NewDirName";
            this.textBox_NewDirName.Size = new System.Drawing.Size(137, 21);
            this.textBox_NewDirName.TabIndex = 4;
            // 
            // button_NewDir
            // 
            this.button_NewDir.Location = new System.Drawing.Point(867, 75);
            this.button_NewDir.Name = "button_NewDir";
            this.button_NewDir.Size = new System.Drawing.Size(75, 23);
            this.button_NewDir.TabIndex = 5;
            this.button_NewDir.Text = "新建文件夹";
            this.button_NewDir.UseVisualStyleBackColor = true;
            this.button_NewDir.Click += new System.EventHandler(this.button_NewDir_Click);
            // 
            // textBox_NewFileName
            // 
            this.textBox_NewFileName.Location = new System.Drawing.Point(699, 127);
            this.textBox_NewFileName.Name = "textBox_NewFileName";
            this.textBox_NewFileName.Size = new System.Drawing.Size(137, 21);
            this.textBox_NewFileName.TabIndex = 4;
            // 
            // button_NewFile
            // 
            this.button_NewFile.Location = new System.Drawing.Point(867, 126);
            this.button_NewFile.Name = "button_NewFile";
            this.button_NewFile.Size = new System.Drawing.Size(75, 23);
            this.button_NewFile.TabIndex = 5;
            this.button_NewFile.Text = "新建文件";
            this.button_NewFile.UseVisualStyleBackColor = true;
            this.button_NewFile.Click += new System.EventHandler(this.button_NewFile_Click);
            // 
            // Form_FileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 437);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewDir;
        private System.Windows.Forms.TextBox textBox_NewDirName;
        private System.Windows.Forms.Button button_NewDir;
        private System.Windows.Forms.TextBox textBox_NewFileName;
        private System.Windows.Forms.Button button_NewFile;
    }
}