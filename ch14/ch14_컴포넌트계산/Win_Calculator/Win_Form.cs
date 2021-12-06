using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculator
{
    public partial class Win_Form : Form
    {
        public Win_Form()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")  // OR
            {      // Trim()  앞 뒤 공백 문자 제거
                MessageBox.Show("피연산자를 입력해 주세요.");
            }
            else
            {
                float a, b, c;
                a = float.Parse(txtVar1.Text); // 형 변환
                b = float.Parse(txtVar2.Text);  // 형 변환
                c = a + b;

                txtResult.Text = c.ToString();  // 형 변환
            }

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")  // OR
            {
                MessageBox.Show("데이터를 입력해 주세요.");
            }
            else
            {
                float a, b, c;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);
                c = a - b;

                txtResult.Text = c.ToString();
            }

        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "") // OR
            {
                MessageBox.Show("데이터를 입력해 주세요.");
            }
            else
            {
                float a, b, c;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);
                c = a * b;

                txtResult.Text = c.ToString();
            }

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "") // OR
            {
                MessageBox.Show("데이터를 입력해 주세요.");
            }
            else
            {
                float a, b, c;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);
                c = a / b;

                txtResult.Text = c.ToString();
            }

        }
    }
}
