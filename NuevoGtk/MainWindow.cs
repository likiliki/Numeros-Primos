using System;
using System.IO;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public string fullText = "";

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public void TestFunction()
    {
        for (int i = 0; i < 19; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }

    public void Primos(int min, int max)
    {
        fullText = "";
        fullText+="\n--NUMEROS PRIMOS ENTRE-> "+ min.ToString() + " Y "+ max.ToString() + "\n";

        int ini = min;
        int fin = max;
        int linea = 6;
        if (ini > 0 && max > 0 && max > ini)
        {
            int lin = 1;
            for (int i = ini; i <= max; i++)
            {
                 Console.Write(i.ToString());
                if (EsPrimo(i))
                {
                    fullText += i.ToString();
                    lin += 1;

                    if (lin != linea) {
                        fullText += "\t-\t";
                    }
                }
               
                if (lin % linea == 0) {
                    fullText += "\n";
                    lin = 1;
                }
            }
            fullText += "\n";
        }
    }

    public bool EsPrimo(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) 
            {
                return false;
            }
        }

        return true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        int num = 0;
        Console.WriteLine("OnButton1Clicked(object sender, EventArgs e)");

        try
        {
            num = Int32.Parse(entry1.Text);
            Primos(1, num);
        }
        catch
        {
            Console.WriteLine("Exception: num = Int32.Parse(entry1.Text);");
        }
        textview1.Buffer.Text = fullText;
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
    }
}
