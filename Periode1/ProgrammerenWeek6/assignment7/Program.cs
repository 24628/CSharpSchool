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
    public TextBox inputNumber;
    public Label result;
    public GroupBox groupBox;
    public RadioButton C2KRb;
    public RadioButton C2FRb;
    public RadioButton F2CRb;
    public string selectedRB;
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputNumber = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();
        groupBox = new System.Windows.Forms.GroupBox();
        C2KRb = new System.Windows.Forms.RadioButton();
        C2FRb = new System.Windows.Forms.RadioButton();
        F2CRb = new System.Windows.Forms.RadioButton();

        result = new Label();

        this.SuspendLayout();

        generateInput(inputNumber, 20, 70, 220, 30);
        generateButton(calcResultButton, 20, 230, 220, 30, "Calculate");
        generateGroupBox();
        generateResult();

        calcResultButton.Click += new EventHandler(calcResultButtonAction);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(result);
        this.Controls.Add(inputNumber);
        this.Controls.Add(this.groupBox);
    }

    private void calcResultButtonAction(object sender, EventArgs e) {
        Console.WriteLine("calc res");
        int temp = Convert.ToInt32(inputNumber.Text);
        double convertedTemp = 0;
        switch(selectedRB){
            case "c2k":
                Celsius2Kelvin(temp, out convertedTemp);
                break;
            case "c2f":
                Celsius2Fahrenheit(temp, out convertedTemp);
                break;
            case "f2c":
                Fahrenheit2Celsius(temp, out convertedTemp);
                break;
        }
        convertedTemp = Math.Round(convertedTemp, 2, MidpointRounding.AwayFromZero);
        changeResultText(convertedTemp.ToString());
    }

    void Celsius2Kelvin(int number, out double temp){
        temp = Convert.ToDouble(number) + 273;
    }

    void Celsius2Fahrenheit(int number, out double temp){
        temp =  ((Convert.ToDouble(number) * 9/5) + 32);
    }

    void Fahrenheit2Celsius(int number, out double temp){
        temp = ((Convert.ToDouble(number) - 32) * 5/9);
    }

    void radioButtonCheckedChanged(object sender, EventArgs e)
    {
        RadioButton rb = sender as RadioButton;
        if (rb.Checked) {
            Console.WriteLine(rb.Name);
            selectedRB = rb.Name;
        }
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
    private void generateGroupBox(){
        groupBox.Controls.Add(C2KRb);
        groupBox.Controls.Add(C2FRb);
        groupBox.Controls.Add(F2CRb);
        groupBox.Location = new System.Drawing.Point(20, 100);
        groupBox.Size = new System.Drawing.Size(220, 125);
        groupBox.Text = "Conversions";

        generateRadioButtons(C2KRb, 31, 23, 167, 17, "Celsius to kelvin", "c2k");
        generateRadioButtons(C2FRb, 31, 53, 167, 17, "Celsius to Farenheit", "c2f");
        generateRadioButtons(F2CRb, 31, 83, 167, 17, "Farenheit to Celsius", "f2c");
    }
    private void generateRadioButtons(RadioButton obj, int pointX, int pointY, int width, int height, string text, string name){
        obj.Location = new System.Drawing.Point(pointX, pointY);
        obj.Size = new System.Drawing.Size(width, height);
        obj.Text = text;
        obj.Name = name;
        obj.CheckedChanged += new EventHandler(radioButtonCheckedChanged);
    }
    private void changeResultText(string text){
        result.Text = text;
    }
}
