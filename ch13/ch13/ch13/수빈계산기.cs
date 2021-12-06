using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch13
{
    public partial class 수빈계산기 : Form
    {
        double num1, num2, num3;
        string buff = "";
        string output = "";
        char oper;
        char oper2;
        double result;
        int checkNum = 0; //연속계산을 위한 체크 변수

        public 수빈계산기()
        {
            InitializeComponent();
        }

        private void Bt_num_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            //숫자 키 중 어느게 눌러졌는지 저장
            buff += btn.Text;
            output += btn.Text;
            textBox1.Text = output;
        }

        private void Bt_oper_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (num1 != 0)
            {
                num2 = Convert.ToSingle(buff);
                oper2 = btn.Text[0];
            }
            else
            {
                num1 = Convert.ToSingle(buff);
                oper = btn.Text[0];
            }

            buff = "";
            output += btn.Text;
            textBox1.Text = output;
            
        }

        private void Bt_clear_Click(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;
            num3 = 0;
            buff = "";
            output = "";
            result = 0.0;
            oper2 = ' ';
        }

        private void 수빈계산기_Load(object sender, EventArgs e)
        {
            textBox1.Text = output;
        }

        private void Bt_calc_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (oper2.Equals('+')|| oper2.Equals('-')|| oper2.Equals('*')|| oper2.Equals('/'))
            {
                num3 = Convert.ToInt32(buff);
                switch (oper2)
                {
                    case '+': num2 = num3 + num2; break;
                    case '-': num2 = num2 - num3; break;
                    case '*': num2 = num3 * num2; break;
                    case '/':
                        if (num3 == 0)
                        {
                            textBox1.Text = "0으로 나눌수 없음";
                            return;
                        }
                        num2 = num2 / num3; break;
                }
            } else
            {
                num2 = Convert.ToInt32(buff);
            }
            
            switch (oper)  // +
            {
                case '+': result = num1 + num2; break; 
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        textBox1.Text = "0으로 나눌수 없음";
                        return;
                    }
                    result = num1 / num2; break;
            }

            buff = "";
            buff += result;
            output += btn.Text + result.ToString();   
            textBox1.Text = output;
            num1 = 0;
            num2 = 0;
            num3 = 0;
            oper2 = ' ';
        }
    }
}
