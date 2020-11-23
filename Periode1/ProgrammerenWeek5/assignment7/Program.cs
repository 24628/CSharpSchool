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
    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        calcResultButton = new Button();
        this.SuspendLayout();

        calcResultButton.Size = new Size(180, 40);
        calcResultButton.Location = new Point(20, 20);
        calcResultButton.Text = "Throw";
        calcResultButton.Click += new EventHandler(CalcResult);

        this.Controls.Add(calcResultButton);
    }

    private void CalcResult(object sender, EventArgs e)
    {   
        var stringBuilder = new StringBuilder();
        int[] diceArray = new int[]{0,0,0,0,0,0};
        Random rnd = new Random();
        for(int i = 0; i < 6000; i++ ){
            switch(rnd.Next(1, 7)){
                case 1:
                    diceArray[0]++;
                    break;
                case 2:
                    diceArray[1]++;
                    break;
                case 3:
                    diceArray[2]++;
                    break;
                case 4:
                    diceArray[3]++;
                    break;
                case 5:
                    diceArray[4]++;
                    break;
                case 6:
                    diceArray[5]++;
                    break;
            }
        }

        for(int i = 0; i < diceArray.Length; i++){
            stringBuilder.AppendLine("Number of throws of value " + (i+1) + " = " + diceArray[i]);
        }

        Label result = new Label();
        result.Location = new Point(20, 80);
        result.Width = 4000;
        result.Height = 500;
        result.Font = new Font("Courier New", 9);
        result.Text = stringBuilder.ToString();
        this.Controls.Add(result);
    }
}
