using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtName.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtResult.Text = null;
        }
    }
}
