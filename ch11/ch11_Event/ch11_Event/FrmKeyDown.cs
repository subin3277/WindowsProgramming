using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11_Event
{
    public partial class FrmKeyDown : Form
    {
        private Point p;
        private Point r_p;
        int count = 0;

        public FrmKeyDown()
        {
            InitializeComponent();

            p.X = 50; p.Y = 400;
            r_p.X = 50; r_p.Y = 50;
            
        }

        private void FrmKeyDown_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, p.X, p.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, r_p.X, r_p.Y, 40, 40);
        }

        private void FrmKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    p.X -= 20;
                    Invalidate();
                    if (p.X < 0)
                        p.X = 300;
                    break;
                case Keys.Right:
                    p.X += 20;
                    Invalidate();
                    if (p.X > 300)
                        p.X = 0;
                    break;
                //case Keys.Up:
                //    p.Y -= 20;
                //    Invalidate();
                //    if (p.Y < 0)
                //        p.Y = 500;
                //    break;
                case Keys.Down:
                    r_p.Y += 20;
                    Invalidate();
                    if (r_p.Y > 500)
                        r_p.Y = 0;
                    break;
                default:
                    break;
            }
            if(p.X == r_p.X && p.Y == r_p.Y)
            {
                count++;
                label1.Text = "점수 " + Convert.ToString(count);
                r_p.X = 50; r_p.Y = 50;
                Invalidate();
            }
            if (count>=5)
            {
                MessageBox.Show("게임종료");
                Application.Exit();
            }
        }
    }
}
