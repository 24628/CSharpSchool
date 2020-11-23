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
    public TextBox inputFieldNumber1;
    public TextBox inputFieldNumber2;
    public TextBox inputFieldNumber3;

    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputFieldNumber1 = new System.Windows.Forms.TextBox();
        inputFieldNumber2 = new System.Windows.Forms.TextBox();
        inputFieldNumber3 = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();
        this.SuspendLayout();

        inputFieldNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldNumber1.Multiline = false;
        inputFieldNumber1.Location = new Point(30, 60);
        inputFieldNumber1.Width = 400;
        inputFieldNumber1.Height = 50;

        inputFieldNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldNumber2.Multiline = false;
        inputFieldNumber2.Location = new Point(30, 110);
        inputFieldNumber2.Width = 400;
        inputFieldNumber2.Height = 50;

        inputFieldNumber3.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldNumber3.Multiline = false;
        inputFieldNumber3.Location = new Point(30, 160);
        inputFieldNumber3.Width = 400;
        inputFieldNumber3.Height = 50;

        calcResultButton.Size = new Size(400, 40);
        calcResultButton.Location = new Point(30, 210);
        calcResultButton.Text = "Calculate";
        calcResultButton.Click += new EventHandler(DetemineVat);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(inputFieldNumber1);
        this.Controls.Add(inputFieldNumber2);
        this.Controls.Add(inputFieldNumber3);
    }
    private void DetemineVat(object sender, EventArgs e)
    {
        int number1 = Convert.ToInt32(inputFieldNumber1.Text);
        int number2 = Convert.ToInt32(inputFieldNumber2.Text);
        int number3 = Convert.ToInt32(inputFieldNumber3.Text);

        float resultFloat =  Convert.ToSingle(number1 + number2 + number3) / 3;

        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 50;
        result.Text =  "result: " + resultFloat;
        this.Controls.Add(result);
    }
}
