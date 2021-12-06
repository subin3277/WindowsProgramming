using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comp_Calculator;

namespace Comp_Calculator
{
    public partial class Comp_Calculator : Form
    {
        Calculator Cal = new Calculator();
        public Comp_Calculator()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")
            {
                MessageBox.Show("Data를 입력해 주세요.");
            }
            else
            {
                float a, b;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);

                // +연산자 대신 Cal 객체의 Plus()메쏘드를 이용해 덧셈
                txtResult.Text = Cal.Plus(a, b).ToString(); ;
            }

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")
            {
                MessageBox.Show("Data를 입력해 주세요.");
            }
            else
            {
                float a, b;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);

                // -연산자 대신 Cal 객체의 Minus()메쏘드를 이용해 뺄셈
                txtResult.Text = Cal.Minus(a, b).ToString();
            }

        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")
            {
                MessageBox.Show("Data를 입력해 주세요.");
            }
            else
            {
                float a, b;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);

                // *연산자 대신 Cal 객체의 Multiply()메쏘드를 이용해 곱셈
                txtResult.Text = Cal.Multiply(a, b).ToString();
            }

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (txtVar1.Text.Trim() == "" || txtVar2.Text.Trim() == "")
            {
                MessageBox.Show("Data를 입력해 주세요.");
            }
            else
            {
                float a, b;
                a = float.Parse(txtVar1.Text);
                b = float.Parse(txtVar2.Text);

                //   나누기 / 연산자 대신 Cal 객체의 Divide()메쏘드를 이용해 나눗셈
                txtResult.Text = Cal.Divide(a, b).ToString();
            }

        }
    }
}
