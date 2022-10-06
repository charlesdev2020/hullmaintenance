using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HullMaintenance
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (VisualStyleInformation.IsSupportedByOS && VisualStyleInformation.IsEnabledByUser)
            {
                Application.EnableVisualStyles();
            }

            Application.SetCompatibleTextRenderingDefault(false);

            Thread thread1 = new Thread(RunMainForm);
            thread1.Start("Thread1");

            thread1.Join();
        }

        static void RunMainForm(object title)
        {
            MainForm mainForm = new MainForm();

            Application.Run(new MainForm());
        }
    }
}
