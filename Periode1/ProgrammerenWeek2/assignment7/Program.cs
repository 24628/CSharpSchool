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
    public Button calcResultButton;
    public Button eraseButton;
    public TextBox inputFieldStartKM;
    public TextBox inputFieldEndKM;
    public TextBox inputFieldPricePerKM;

    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputFieldStartKM = new System.Windows.Forms.TextBox();
        inputFieldEndKM = new System.Windows.Forms.TextBox();
        inputFieldPricePerKM = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();
        eraseButton = new Button();
        this.SuspendLayout();

        inputFieldStartKM.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldStartKM.Multiline = false;
        inputFieldStartKM.Location = new Point(30, 60);
        inputFieldStartKM.Width = 400;
        inputFieldStartKM.Height = 50;

        inputFieldEndKM.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldEndKM.Multiline = false;
        inputFieldEndKM.Location = new Point(30, 110);
        inputFieldEndKM.Width = 400;
        inputFieldEndKM.Height = 50;

        inputFieldPricePerKM.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldPricePerKM.Multiline = false;
        inputFieldPricePerKM.Location = new Point(30, 160);
        inputFieldPricePerKM.Width = 400;
        inputFieldPricePerKM.Height = 50;

        calcResultButton.Size = new Size(180, 40);
        calcResultButton.Location = new Point(210, 210);
        calcResultButton.Text = "Calculate";
        calcResultButton.Click += new EventHandler(CalcResult);

        eraseButton.Size = new Size(180, 40);
        eraseButton.Location = new Point(30, 210);
        eraseButton.Text = "Erase";
        eraseButton.Click += new EventHandler(Erase);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(eraseButton);
        this.Controls.Add(inputFieldStartKM);
        this.Controls.Add(inputFieldEndKM);
        this.Controls.Add(inputFieldPricePerKM);
    }

    private void Erase(object sender, EventArgs e)
    {
        inputFieldNumber1.Text = "";
        inputFieldNumber2.Text = "";
        inputFieldNumber3.Text = "";
    }
    private void CalcResult(object sender, EventArgs e)
    {
        double startKM = Convert.ToDouble(inputFieldStartKM.Text);
        double endKM = Convert.ToDouble(inputFieldEndKM.Text);
        double pricePerKM = Convert.ToDouble(inputFieldPricePerKM.Text);
        double taxes = 1.21;

        double priceExcVat = (endKM - startKM) * pricePerKM;
        double priceWithVat = priceExcVat * taxes;
        double vat = priceWithVat - priceExcVat;

        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 50;
        result.Text =  result.Text =  "\n Price: " + priceExcVat.ToString() + "\n Vat: " + vat.ToString() + "\n Total: " + priceWithVat.ToString();
        this.Controls.Add(result);
    }
}
