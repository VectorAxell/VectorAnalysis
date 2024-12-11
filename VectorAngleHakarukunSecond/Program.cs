//using OBSERLIVES.CapShotViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorAngleHakarukunSecond.VectorHakarukunViews;
using VectorAngleHakarukunSecond.VectorViews;

namespace VectorAngleHakarukunSecond
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VectorView());
        }
    }
}
