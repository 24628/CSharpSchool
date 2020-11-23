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
    public Button calcResultButtonSquareByRef;
    public Button calcResultButtonSquareByOut;
    public Button calcResultButtonSquareByValue;
    public TextBox inputNumber;
    public Label result;
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputNumber = new System.Windows.Forms.TextBox();

        calcResultButtonSquareByRef = new Button();
        calcResultButtonSquareByOut = new Button();
        calcResultButtonSquareByValue = new Button();

        result = new Label();

        this.SuspendLayout();

        generateInput(inputNumber, 60, 20, 100, 40);

        generateButton(calcResultButtonSquareByRef, 20, 130, 120, 60, "Square by reference");
        generateButton(calcResultButtonSquareByOut, 20, 200, 120, 60, "Square by reference Out");
        generateButton(calcResultButtonSquareByValue, 20, 270, 120, 60, "Square by value");

        generateResult();

        calcResultButtonSquareByRef.Click += new EventHandler(calcResultSquareByRef);
        calcResultButtonSquareByOut.Click += new EventHandler(calcResultSquareByOut);
        calcResultButtonSquareByValue.Click += new EventHandler(calcResultSquareByValue);

        this.Controls.Add(calcResultButtonSquareByRef);
        this.Controls.Add(calcResultButtonSquareByOut);
        this.Controls.Add(calcResultButtonSquareByValue);
        this.Controls.Add(result);
        this.Controls.Add(inputNumber);
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
        result.Location = new Point(20, 350);
        result.Width = 4000;
        result.Height = 500;
        result.Font = new Font("Courier New", 9);
    }
    private void changeResultText(string text){
        result.Text = text;
    }
    private void calcResultSquareByRef(object sender, EventArgs e) {
        int number = Convert.ToInt32(inputNumber.Text);
        SquareByReference(ref number);
        changeResultText(number.ToString());
    }
    private void calcResultSquareByOut(object sender, EventArgs e) {
        int number = Convert.ToInt32(inputNumber.Text);
        int square;
        SquareByReferenceOut(number, out square);
        changeResultText(square.ToString());
    }
    private void calcResultSquareByValue(object sender, EventArgs e) {
        changeResultText(SquareByValue(Convert.ToInt32(inputNumber.Text)).ToString());
    }
    void SquareByReference(ref int number){
        number = number * number;
    }
    void SquareByReferenceOut(int number, out int square){
        square = number * number;
    }
    int SquareByValue(int number){
        return number * number;
    }
}
