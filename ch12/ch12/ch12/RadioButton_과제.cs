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
    public partial class RadioButton_과제 : Form
    {
        public RadioButton_과제()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (txBox.Text)
            {
                case "여자":
                    radBtn1.Checked = true;
                    break;
                case "남자":
                    radBtn2.Checked = true;
                    break;
                case "중성":
                    radBtn3.Checked = true;
                    break;
            }
        }
    }
}
