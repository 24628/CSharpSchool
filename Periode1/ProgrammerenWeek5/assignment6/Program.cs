using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using System.Text;

//mcs Program.cs -pkg:dotnet to compile
//mono the exe file to run mono Program.exe
//do from terminal self note

class Program : Form
{ 
    public Button calcResultButton;
    public TextBox inputStart;
    public int[] array = new int[20];
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
        inputStart.Location = new Point(10, 10);
        inputStart.Width = 50;
        inputStart.Height = 50;

        calcResultButton.Size = new Size(180, 40);
        calcResultButton.Location = new Point(60, 10);
        calcResultButton.Text = "Create Square";
        calcResultButton.Click += new EventHandler(CalcResult);

        Random rnd = new Random();
        var stringBuilder = new StringBuilder();
        for(int i = 0; i < array.Length; i++){
            array[i] = rnd.Next(0, 500);
            string tmp = "Element " + i + " = " + array[i];
            stringBuilder.AppendLine(tmp);
        }

        Label generateString = new Label();
        generateString.Location = new Point(10, 50);
        generateString.Width = 200;
        generateString.Height = 500;
        generateString.Font = new Font("Courier New", 9);
        generateString.Text = stringBuilder.ToString();

        this.Controls.Add(generateString);
        this.Controls.Add(calcResultButton);
        this.Controls.Add(inputStart);
    }

    private void CalcResult(object sender, EventArgs e)
    {   
        int inputCon = Convert.ToInt32(inputStart.Text);
        var stringBuilder = new StringBuilder();
        for(int i = 0; i < array.Length; i++){
            if(inputCon <= array[i]) {
                stringBuilder.AppendLine("Element " + i + " = " + (array[i] + 10));
            }
            else {
                stringBuilder.AppendLine("Element " + i + " = " + (array[i] - 5));
            }
        }

        Label result = new Label();
        result.Location = new Point(270, 50);
        result.Width = 4000;
        result.Height = 500;
        result.Font = new Font("Courier New", 9);
        result.Text = stringBuilder.ToString();
        this.Controls.Add(result);
    }
}
