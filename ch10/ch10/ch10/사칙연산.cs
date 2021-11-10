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
    public partial class 사칙연산 : Form
    {
        public 사칙연산()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtRes.Text = (Convert.ToSingle(txtA.Text) + Convert.ToSingle(txtB.Text)).ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            txtRes.Text = (Convert.ToSingle(txtA.Text) - Convert.ToSingle(txtB.Text)).ToString();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            txtRes.Text = (Convert.ToSingle(txtA.Text) * Convert.ToSingle(txtB.Text)).ToString();
        }

        private void BtnDup_Click(object sender, EventArgs e)
        {
            txtRes.Text = (Convert.ToSingle(txtA.Text) / Convert.ToSingle(txtB.Text)).ToString();
        }
    }
}
