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
    public Button calcButton;
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
        calcButton = new Button();
        this.SuspendLayout();

        inputField.Dock = System.Windows.Forms.DockStyle.Fill;
        inputField.Multiline = false;
        inputField.Location = new Point(30, 60);
        inputField.Width = 400;
        inputField.Height = 50;

        calcButton.Size = new Size(400, 40);
        calcButton.Location = new Point(30, 110);
        calcButton.Text = "Calculate Time";
        calcButton.Click += new EventHandler(DetemineVat);

        this.Controls.Add(calcButton);
        this.Controls.Add(inputField);
    }
    private void DetemineVat(object sender, EventArgs e)
    {
        TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(inputField.Text));
        string resultTime = time.ToString(@"hh\:mm\:ss");

        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 50;
        result.Text =  "Result: " + resultTime;
        this.Controls.Add(result);
    }
}
