using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickergame
{
    public partial class Form1 : Form
    {

        public int Licznik = 0;
        public int Czas = 0;
        public int Punkty = 0;


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Licznik += 1;
            label1.Text=Licznik.ToString();
            timer.Start();


            Punkty = Licznik;

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Czas += 1;
            label2.Text=Czas.ToString();
        }
    }
}
