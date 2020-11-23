using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using System.Drawing;

//mcs Program.cs -pkg:dotnet to compile
//mono the exe file to run mono Program.exe
//do from terminal self note

class Program : Form
{ 
    public Button vatButton;
    public TextBox inputField;

    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputField = new System.Windows.Forms.TextBox();
        vatButton = new Button();
        this.SuspendLayout();

        inputField.AcceptsReturn = true;
        inputField.AcceptsTab = true;
        inputField.Dock = System.Windows.Forms.DockStyle.Fill;
        inputField.Multiline = false;
        inputField.Location = new Point(30, 60);
        inputField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        inputField.Width = 400;
        inputField.Height = 50;

        vatButton.Size = new Size(400, 40);
        vatButton.Location = new Point(30, 110);
        vatButton.Text = "Detemine VAT";
        vatButton.Click += new EventHandler(DetemineVat);

        this.Controls.Add(vatButton);
        this.Controls.Add(inputField);
    }
    private void DetemineVat(object sender, EventArgs e)
    {
        double parsedPrice = Convert.ToDouble(inputField.Text);
        double taxes = 1.21;

        double Vat = (taxes * parsedPrice) - parsedPrice;
        double total = taxes * parsedPrice;

        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 50;
        result.Text =  "\n Price: " + parsedPrice.ToString() + "\n Vat: " + Vat.ToString() + "\n Total: " + total.ToString();
        this.Controls.Add(result);
    }
}
