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
    public TextBox inputDag;
    public TextBox inputMaand;
    public TextBox inputJaar;
    public Label result;
    public Label labelDag;
    public Label labelMaand;
    public Label labelJaar;
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputDag = new System.Windows.Forms.TextBox();
        inputMaand = new System.Windows.Forms.TextBox();
        inputJaar = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();

        result = new Label();
        labelDag = new Label();
        labelMaand = new Label();
        labelJaar = new Label();

        this.SuspendLayout();

        generateInput(inputDag, 20, 50, 220, 30, "Test", labelDag);
        generateInput(inputMaand, 20, 100, 220, 30, "Maand", labelMaand);
        generateInput(inputJaar, 20, 150, 220, 30, "Jaar", labelJaar);
        generateButton(calcResultButton, 20, 230, 220, 30, "Calculate");
        generateLabel(result, 20, 350, 1000, 500, "");

        calcResultButton.Click += new EventHandler(calcResultButtonAction);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(result);
        this.Controls.Add(labelDag);
        this.Controls.Add(labelMaand);
        this.Controls.Add(labelJaar);
        this.Controls.Add(inputDag);
        this.Controls.Add(inputMaand);
        this.Controls.Add(inputJaar);
    }

    private void calcResultButtonAction(object sender, EventArgs e) {
        DateTime beginDate = new DateTime(Convert.ToInt32(inputJaar.Text), Convert.ToInt32(inputMaand.Text), Convert.ToInt32(inputDag.Text));
        var daysLeft = (DateTime.DaysInMonth(beginDate.Year, beginDate.Month) - beginDate.Day) + 1;//Omdat het anders niet gelijk loopt met de opdracht en altijd 1 dag er naast zit
        string resultText = "resterende dagen: " + daysLeft;
        changeResultText(resultText);
    }

    private void generateInput(TextBox obj, int pointX, int pointY, int width, int height, string name, Label labelObj){
        obj.Dock = System.Windows.Forms.DockStyle.Fill;
        obj.Location = new Point((pointX + 150), pointY);
        obj.Width = width;
        obj.Multiline = false;
        obj.Height = height;

        generateLabel(labelObj, pointX, pointY, 30, height, name);
    }
    private void generateButton(Button obj, int pointX, int pointY, int width, int height, string text){
        obj.Size = new Size(width, height);
        obj.Location = new Point(pointX, pointY);
        obj.Text = text;
    }
    private void generateLabel(Label obj, int pointX, int pointY, int width, int height, string text){
        obj.Location = new Point(pointX, pointY);
        obj.Width = width;
        obj.Height = height;
        obj.Text = text;
    }
    private void changeResultText(string text){
        result.Text = text;
    }
}
