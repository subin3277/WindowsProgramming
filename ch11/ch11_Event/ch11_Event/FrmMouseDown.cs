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
    public partial class FrmMouseDown : Form
    {
        public FrmMouseDown()
        {
            InitializeComponent();
        }

        private void FrmMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Graphics g = CreateGraphics();
                g.DrawEllipse(Pens.Red, 0, 0, 20, 20);
                g.DrawEllipse(Pens.Black, e.X, e.Y, 15, 15);
                g.Dispose();
            }
            p.X = e.X;
            p.Y = e.Y;
        }

        private Point p;

        private void FrmMouseDown_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Blue, p.X, p.Y, e.X, e.Y);
                g.Dispose();
            }
        }
    }
}
