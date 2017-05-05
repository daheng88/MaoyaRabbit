using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //处理未捕获的异常
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.Run(new Form1());

        }

        /// <summary>
        /// 是否退出应用程序
        /// </summary>
        static bool glExitApp = false;

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //LogHelper.Save("CurrentDomain_UnhandledException", LogType.Error);
            //LogHelper.Save("IsTerminating : " + e.IsTerminating.ToString(), LogType.Error);
            //LogHelper.Save(e.ExceptionObject.ToString());

            //while (true)
            //{//循环处理，否则应用程序将会退出
            //    if (glExitApp)
            //    {//标志应用程序可以退出，否则程序退出后，进程仍然在运行
            //        LogHelper.Save("ExitApp");
            //        return;
            //    }
            //    System.Threading.Thread.Sleep(2 * 1000);
            //};
           // MessageBox.Show(e.ExceptionObject.ToString());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //LogHelper.Save("Application_ThreadException:" +
            //    e.Exception.Message, LogType.Error);
            //LogHelper.Save(e.Exception);
            //throw new NotImplementedException();
          //  MessageBox.Show(e.Exception.Message);
        }
    }
}
