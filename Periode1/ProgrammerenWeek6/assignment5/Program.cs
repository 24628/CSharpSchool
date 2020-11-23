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
    public Button calcResultButtonPlus;
    public Button calcResultButtonMinus;
    public Button calcResultButtonTimes;
    public Button calcResultButtonDevide;
    public TextBox inputNumber1;
    public TextBox inputNumber2;
    public Label result;
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputNumber1 = new System.Windows.Forms.TextBox();
        inputNumber2 = new System.Windows.Forms.TextBox();

        calcResultButtonPlus = new Button();
        calcResultButtonMinus = new Button();
        calcResultButtonTimes = new Button();
        calcResultButtonDevide = new Button();

        result = new Label();

        this.SuspendLayout();

        generateInput(inputNumber1, 60, 20, 100, 40);
        generateInput(inputNumber2, 60, 70, 100, 40);

        generateButton(calcResultButtonPlus, 20, 130, 60, 60, "+");
        generateButton(calcResultButtonMinus, 90, 130, 60, 60, "-");
        generateButton(calcResultButtonTimes, 160, 130, 60, 60, "x");
        generateButton(calcResultButtonDevide, 230, 130, 60, 60, ":");

        generateResult();

        calcResultButtonPlus.Click += new EventHandler(CalcResultPlus);
        calcResultButtonMinus.Click += new EventHandler(CalcResultMinus);
        calcResultButtonTimes.Click += new EventHandler(CalcResultTimes);
        calcResultButtonDevide.Click += new EventHandler(CalcResultDevide);

        this.Controls.Add(calcResultButtonPlus);
        this.Controls.Add(calcResultButtonMinus);
        this.Controls.Add(calcResultButtonTimes);
        this.Controls.Add(calcResultButtonDevide);
        this.Controls.Add(result);
        this.Controls.Add(inputNumber1);
        this.Controls.Add(inputNumber2);
    }
    private void generateInput(TextBox obj, int pointX, int pointY, int width, int height){
        obj.Dock = System.Windows.Forms.DockStyle.Fill;
        obj.Multiline = false;
        obj.Location = new Point(pointX, pointY);
        obj.Width = width;
        obj.Height = height;
    }
    private void generateButton(Button obj, int pointX, int pointY, int width, int height, string text){
        obj.Size = new Size(width, height);
        obj.Location = new Point(pointX, pointY);
        obj.Text = text;
    }
    private void generateResult(){
        result.Location = new Point(20, 200);
        result.Width = 4000;
        result.Height = 500;
        result.Font = new Font("Courier New", 9);
    }
    private void changeResultText(string text){
        result.Text = text;
    }
    private void CalcResultPlus(object sender, EventArgs e) {
        changeResultText((Convert.ToInt32(inputNumber1.Text) + Convert.ToInt32(inputNumber2.Text)).ToString());
    }
    private void CalcResultMinus(object sender, EventArgs e) {
        changeResultText((Convert.ToInt32(inputNumber1.Text) - Convert.ToInt32(inputNumber2.Text)).ToString());
    }
    private void CalcResultTimes(object sender, EventArgs e) {
        changeResultText((Convert.ToDouble(inputNumber1.Text) * Convert.ToDouble(inputNumber2.Text)).ToString());
    }
    private void CalcResultDevide(object sender, EventArgs e) {
        changeResultText((Convert.ToDouble(inputNumber1.Text) / Convert.ToDouble(inputNumber2.Text)).ToString());
    }
}
