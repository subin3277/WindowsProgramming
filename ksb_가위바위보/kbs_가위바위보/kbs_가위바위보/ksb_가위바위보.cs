using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 가위바위보_dll;

namespace kbs_가위바위보
{
    public partial class ksb_가위바위보 : Form
    {
        public ksb_가위바위보()
        {
            InitializeComponent();
        }

        bool result_view;
        int User_count = 0, Com_count = 0, Draw_count = 0;

        int User_S = 0, User_R = 0, User_P = 0;
        int Com_S = 0, Com_R = 0, Com_P = 0;



        private void Btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기▶";
                    Timer_View_Result.Stop();
                }
                else
                    Width -= size;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            int my_num = 1; //가위
            pictureBox2.ImageLocation = "Images/gawei.jpg";

            Random su = new Random();
            int com_num = su.Next(1,4);
            User_S++;
            가위바위보 res = new 가위바위보(com_num,my_num);
            
            switch (res.Result)
            {
                case "서로 비김":
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lb_res.Text = "서로 비김";
                    Draw_count++;
                    Com_S++;
                    break;
                case "짐":
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lb_res.Text = "내가 패";
                    Com_count++;
                    Com_R++;
                    break;
                case "이김":
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lb_res.Text = "내가 승";
                    User_count++;
                    Com_P++;
                    break;
            }

            lb_Me_Score.Text = "내가 이긴 횟수 : " + User_count + "번";
            lb_Com_Score.Text = "컴퓨터가 이긴 횟수 : " + Com_count + "번";
            lb_Draw_Score.Text = "서로 비긴 횟수 : " + Draw_count + "번";
            int count = User_count + Com_count + Draw_count;
            lb_Total_Count.Text = "총" + count + "번의 게임을 진행하였습니다.";
            lb_Me_S.Text = "가위 수 : " + User_S;
            lb_Me_R.Text = "바위 수 : " + User_R;
            lb_Me_P.Text = "보 수 : " + User_P;
            lb_Com_S.Text = "가위 수 : " + Com_S;
            lb_Com_R.Text = "바위 수 : " + Com_R;
            lb_Com_P.Text = "보 수 : " + Com_P;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int my_num = 2; //바위
            pictureBox2.ImageLocation = "Images/bawei.jpg";

            Random su = new Random();
            int com_num = su.Next(1, 4);
            User_R++;

            가위바위보 res = new 가위바위보(com_num, my_num);
            switch (res.Result)
            {
                case "이김":
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lb_res.Text = "내가 승";
                    User_count++;
                    Com_S++;
                    break;
                case "서로 비김":
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lb_res.Text = "서로 비김";
                    Draw_count++;
                    Com_R++;
                    break;
                case "짐":
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lb_res.Text = "내가 패";
                    Com_count++;
                    Com_P++;
                    break;
            }
            lb_Me_Score.Text = "내가 이긴 횟수 : " + User_count + "번";
            lb_Com_Score.Text = "컴퓨터가 이긴 횟수 : " + Com_count + "번";
            lb_Draw_Score.Text = "서로 비긴 횟수 : " + Draw_count + "번";
            int count = User_count + Com_count + Draw_count;
            lb_Total_Count.Text = "총" + count + "번의 게임을 진행하였습니다.";
            lb_Me_S.Text = "가위 수 : " + User_S;
            lb_Me_R.Text = "바위 수 : " + User_R;
            lb_Me_P.Text = "보 수 : " + User_P;
            lb_Com_S.Text = "가위 수 : " + Com_S;
            lb_Com_R.Text = "바위 수 : " + Com_R;
            lb_Com_P.Text = "보 수 : " + Com_P;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int my_num = 3; //보
            pictureBox2.ImageLocation = "Images/bo.jpg";

            Random su = new Random();
            int com_num = su.Next(1, 4);
            User_P++;

            가위바위보 res = new 가위바위보(com_num, my_num);

            switch (res.Result)
            {
                case "짐":
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lb_res.Text = "내가 패";
                    Com_count++;
                    Com_S++;
                    break;
                case "이김":
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lb_res.Text = "내가 승";
                    User_count++;
                    Com_R++;
                    break;
                case "서로 비김":
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lb_res.Text = "서로 비김";
                    Draw_count++;
                    Com_P++;
                    break;
            }
            lb_Me_Score.Text = "내가 이긴 횟수 : " + User_count + "번";
            lb_Com_Score.Text = "컴퓨터가 이긴 횟수 : " + Com_count + "번";
            lb_Draw_Score.Text = "서로 비긴 횟수 : " + Draw_count + "번";
            int count = User_count + Com_count + Draw_count;
            lb_Total_Count.Text = "총" + count + "번의 게임을 진행하였습니다.";
            lb_Me_S.Text = "가위 수 : " + User_S;
            lb_Me_R.Text = "바위 수 : " + User_R;
            lb_Me_P.Text = "보 수 : " + User_P;
            lb_Com_S.Text = "가위 수 : " + Com_S;
            lb_Com_R.Text = "바위 수 : " + Com_R;
            lb_Com_P.Text = "보 수 : " + Com_P;
        }
    }

    
}
