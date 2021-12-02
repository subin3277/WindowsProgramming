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
    public partial class CheckBoxList : Form
    {
        public CheckBoxList()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (chkGwamok.CheckedItems.Count == 0)
            {
                MessageBox.Show("과목 선택 안됨");
            }
            else
            {      // 3개 선택 후 버튼 클릭하면 Count 에는 3이 저장됨
                string chkTitle = "";
                for (int i = 0; i < chkGwamok.CheckedItems.Count; i++)
                {
                    chkTitle += chkGwamok.CheckedItems[i] + "\n";
                }
                MessageBox.Show(chkTitle, "선택 결과");
                // 메시지박스에 chkTitle 내용과  타이틀 출력함
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
