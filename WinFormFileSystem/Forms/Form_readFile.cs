using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFileSystem.Forms
{
    public partial class Form_readFile : Form
    {
        public Form_readFile(string fileName, string fileContext)
        {
            InitializeComponent();
            this.Text = fileName;
            this.textBox1.Text = fileContext;
        }

        private void Form_readFile_Load(object sender, EventArgs e)
        {

        }
    }
}
