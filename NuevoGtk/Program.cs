using System;
using Gtk;

namespace NuevoGtk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // TestFunction();
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            //win.TestFunction();
            //win.Primos(1, 1000);
            Application.Run();
        }

        public static void TestFunction()
        {
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
