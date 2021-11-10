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
    public partial class 과제1 : Form
    {
        public 과제1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            resName.Text = txtName.Text;
            resAge.Text = txtAge.Text;
            lbName.Text = txtName.Text;
            lbAge.Text = txtAge.Text;
        }
    }
}
