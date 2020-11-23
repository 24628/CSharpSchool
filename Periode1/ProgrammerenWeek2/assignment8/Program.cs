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
    const double shirts = 30.00;
    const double jeans = 100.00;
    public Button calcResultButton;
    public TextBox inputFieldShirts;
    public TextBox inputFieldJeans;

    static void Main(string[] args){
        CultureInfo ci = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;

        Application.EnableVisualStyles();
        Application.Run(new Program());
    }

    public Program(){
        inputFieldShirts = new System.Windows.Forms.TextBox();
        inputFieldJeans = new System.Windows.Forms.TextBox();
        calcResultButton = new Button();
        this.SuspendLayout();

        inputFieldShirts.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldShirts.Multiline = false;
        inputFieldShirts.Location = new Point(30, 60);
        inputFieldShirts.Width = 400;
        inputFieldShirts.Height = 50;

        inputFieldJeans.Dock = System.Windows.Forms.DockStyle.Fill;
        inputFieldJeans.Multiline = false;
        inputFieldJeans.Location = new Point(30, 110);
        inputFieldJeans.Width = 400;
        inputFieldJeans.Height = 50;

        calcResultButton.Image = resizeImage(Image.FromFile("icon2.jpg"), new Size(30,30));
        calcResultButton.ImageAlign = ContentAlignment.MiddleLeft;    
        calcResultButton.TextAlign = ContentAlignment.MiddleRight;
        calcResultButton.FlatStyle = FlatStyle.Flat;
        calcResultButton.Size = new Size(180, 40);
        calcResultButton.Location = new Point(210, 210);
        calcResultButton.Text = "Calculate";
        calcResultButton.Click += new EventHandler(CalcResult);

        this.Controls.Add(calcResultButton);
        this.Controls.Add(inputFieldShirts);
        this.Controls.Add(inputFieldJeans);

        this.MaximizeBox = false;
        this.MinimizeBox = false;
    }

    public static Image resizeImage(Image imgToResize, Size size)
    {
        return (Image)(new Bitmap(imgToResize, size));
    }

    private void CalcResult(object sender, EventArgs e)
    {
        double taxes = 1.21;

        double totalExcVat = (Convert.ToDouble(inputFieldShirts.Text) * shirts) + (Convert.ToDouble(inputFieldJeans.Text) * jeans);
        double totalWithVat = totalExcVat * taxes;
        double Vat = totalWithVat - totalExcVat;

        Label result = new Label();
        result.Location = new Point(480, 30);
        result.Width = 400;
        result.Height = 70;
        result.Text = "\n Date: " + DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt") + "\n Price exl vat: €" + totalExcVat.ToString() + "\n Vat: €" + Vat.ToString() + "\n Total: €" + totalWithVat.ToString();
        this.Controls.Add(result);
    }
}
