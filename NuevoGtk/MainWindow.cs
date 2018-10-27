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
        if (ini > 0 && fin > 0 && fin > ini)
        {
            int lin = 1;
            for (int i = ini; i <= fin; i++)
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
        textview1.Buffer.Text = fullText;
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
        catch (FormatException ex)
        {
            fullText = "\n";
            fullText += ex.Message + "\n\nIntroduzca solo numeros enteros.";
            textview1.Buffer.Text = fullText;
        }
        catch (Exception ex)
        {
            fullText = "\n";
            fullText += ex.Message + "\n\nFallo en la Aplicacion.";
            textview1.Buffer.Text = fullText;
        }
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("OnButton2Clicked(object sender, EventArgs e)");

        int minimo = 0;
        int maximo = 0;

        try
        {
            minimo = Int32.Parse(entryMin.Text);
            maximo = Int32.Parse(entryMax.Text);
            Primos(minimo, maximo);
        }
        catch
        {
            Console.WriteLine("minimo = Int32.Parse(entryMin.Text);\nmaximo = Int32.Parse(entryMax.Text);");
        }
    }
}
