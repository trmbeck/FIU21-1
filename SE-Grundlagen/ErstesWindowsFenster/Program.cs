//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

using System;
using System.Windows.Forms;
using System.Drawing;


namespace ErstesWindowsFenster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");
            //string eingabe = Console.ReadLine();
            //int a = Convert.ToInt32(eingabe);

            Console.WriteLine("Nun kommt ein Fenster/Formular");
            MeinFormular fenster = new MeinFormular();
            
            Application.Run(fenster);
        }
    }

    class MeinFormular : Form
    {
        public MeinFormular()
        {
            this.Text = "Titel des Fensters !!!";
            this.BackColor = Color.Blue;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawString("Hallo Forms :-)", this.Font, Brushes.Beige, 100, 100);
            //Linie
            graphics.DrawLine(new Pen(Color.Red, 5), 10, 10, 100, 100);
            //Ellipse
            graphics.DrawEllipse(new Pen(Color.Red, 2), 100, 100, 200, 200);

            Image bild = Image.FromFile(@"c:\users\michael.beck\Pictures\FIU21-1-Sep21.png"); //Verbatim-String
            graphics.DrawImage(bild, 10,100,200,200);
        }
    }
}
