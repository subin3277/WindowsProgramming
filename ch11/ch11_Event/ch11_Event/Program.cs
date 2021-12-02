using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11_Event
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmKeyBoard());
            //Application.Run(new FrmKeyInput());
            //Application.Run(new FrmMouseDown());
            Application.Run(new FrmKeyDown());
        }
    }
}
