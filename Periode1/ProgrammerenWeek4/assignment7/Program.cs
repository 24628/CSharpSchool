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
        calcResultButton.Text = "Create Square";
        calcResultButton.Click += new EventHandler(CalcResult);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(inputStart);
    }

    public static string CreateASCIISquare(int squareSideLenght, char c = 'x'){
        if(squareSideLenght < 1)
            return "";
        if(squareSideLenght == 1)
            return c.ToString();

        var horizontalOuterRow = new String(c, squareSideLenght);
        var horizontalInnerRow = ((c).ToString().PadRight(squareSideLenght - 1, ' ') + c).ToString();
        var squareBuilder = new StringBuilder();
        squareBuilder.AppendLine(horizontalOuterRow);

        for(int i = 0; i < squareSideLenght - 2; i++){
            squareBuilder.AppendLine(horizontalInnerRow);
        }

        squareBuilder.AppendLine(horizontalOuterRow);
        return squareBuilder.ToString();
    }

    private void CalcResult(object sender, EventArgs e)
    {
        Console.WriteLine(CreateASCIISquare(Convert.ToInt32(inputStart.Text)));
        
        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 4000;
        result.Height = 500;
        result.Font = new Font("Courier New", 9);
        result.Text = CreateASCIISquare(Convert.ToInt32(inputStart.Text));
        this.Controls.Add(result);
    }
}
