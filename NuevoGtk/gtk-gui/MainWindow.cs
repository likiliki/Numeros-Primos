
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry entry1;

	private global::Gtk.Button button1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label5;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entryMin;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entryMax;

	private global::Gtk.Button button2;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Numeros Primos");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 10;
		this.hbox1.BorderWidth = ((uint)(5));
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.Justify = ((global::Gtk.Justification)(1));
		this.hbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
		w1.Position = 0;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("menores que->");
		this.label2.Justify = ((global::Gtk.Justification)(1));
		this.hbox1.Add(this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.hbox1.Add(this.entry1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry1]));
		w3.Position = 2;
		w3.Expand = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Generar");
		this.hbox1.Add(this.button1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
		w4.Position = 3;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.hbox2.Add(this.label5);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label5]));
		w6.Position = 0;
		w6.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Entre");
		this.label3.Justify = ((global::Gtk.Justification)(1));
		this.hbox2.Add(this.label3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryMin = new global::Gtk.Entry();
		this.entryMin.CanFocus = true;
		this.entryMin.Name = "entryMin";
		this.entryMin.IsEditable = true;
		this.entryMin.InvisibleChar = '●';
		this.hbox2.Add(this.entryMin);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryMin]));
		w8.Position = 2;
		w8.Expand = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("y");
		this.hbox2.Add(this.label4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label4]));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryMax = new global::Gtk.Entry();
		this.entryMax.CanFocus = true;
		this.entryMax.Name = "entryMax";
		this.entryMax.IsEditable = true;
		this.entryMax.InvisibleChar = '●';
		this.hbox2.Add(this.entryMax);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryMax]));
		w10.Position = 4;
		w10.Expand = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Generar");
		this.hbox2.Add(this.button2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button2]));
		w11.Position = 5;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		w12.Padding = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w14.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add(this.statusbar1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
		w15.Position = 3;
		w15.Expand = false;
		w15.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 612;
		this.DefaultHeight = 551;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
	}
}
