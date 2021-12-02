using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch12
{
    public partial class 체크박스연습 : Form
    {
        public 체크박스연습()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkStr1_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }

        private void ChkStr2_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }

        private void ChkStr3_CheckedChanged(object sender, EventArgs e)
        {
            lbSample.Text = "";
            Str_Mark();
        }
        public void Str_Mark()
        {
            if (chkStr1.CheckState == CheckState.Checked)
                lbSample.Text += chkStr1.Text + "";
            if (chkStr2.CheckState == CheckState.Checked)
                lbSample.Text += chkStr2.Text + "";
            if (chkStr3.CheckState == CheckState.Checked)
                lbSample.Text += chkStr3.Text + "";
        }
    }
}
