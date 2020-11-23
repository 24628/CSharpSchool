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
    public TextBox inputStart;
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputStart = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();
        this.SuspendLayout();

        inputStart.Dock = System.Windows.Forms.DockStyle.Fill;
        inputStart.Multiline = false;
        inputStart.Location = new Point(30, 60);
        inputStart.Width = 400;
        inputStart.Height = 50;

        calcResultButton.Size = new Size(180, 40);
        calcResultButton.Location = new Point(210, 210);
        calcResultButton.Text = "Calculate final Capital";
        calcResultButton.Click += new EventHandler(CalcResult);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(inputStart);
    }

    private void CalcResult(object sender, EventArgs e)
    {
        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 50;
        result.Text = "Final capital" + String.Format("{0:0.00}", Convert.ToDouble(inputStart.Text) * Math.Pow(1.05, 5));
        this.Controls.Add(result);
    }
}
