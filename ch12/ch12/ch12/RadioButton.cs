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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Checked 초기값은 False
            if (radB1.Checked == true)
                lbSample.Text = radB1.Text;

            if (radB2.Checked == true)
                lbSample.Text = radB2.Text;

            if (radB3.Checked == true)
                lbSample.Text = radB3.Text;

        }
    }
}
