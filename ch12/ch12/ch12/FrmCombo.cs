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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string words = comboBox1.Text;
            //txtYear.Text = words;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string words = comboBox1.Text;
            txtYear.Text = words;
        }
    }
}
