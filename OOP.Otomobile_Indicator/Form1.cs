using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Otomobile_Indicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        Otomobile auto = new Otomobile(0,"Audi");

        private void Form1_Load(object sender, EventArgs e)
        {
            auto.OverSpeed += Auto_OverSpeed;
            auto.Gear1 += Auto_Gear1;
            auto.Gear2 += Auto_Gear1;
            auto.Gear3 += Auto_Gear1;
            auto.Gear4 += Auto_Gear1;
            auto.Gear5 += Auto_Gear1;
            auto.Gear6 += Auto_Gear1;

        }

        private void Auto_Gear1(int gear, Color color)
        {
            circularProgressBar1.SubscriptText = "." + gear;
            circularProgressBar1.ProgressColor = color;
        }

        private void Auto_OverSpeed(int gear, Color color)
        {
             circularProgressBar1.ProgressColor = color;
        }

        bool result = false;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            result = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up)
            {
                timer1.Start();
                result = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (result)
            {
                auto.Speed += 1;
            }
            else
            {
                auto.Speed -= 1;
            }
            if (auto.Speed>=circularProgressBar1.Maximum || auto.Speed <=circularProgressBar1.Minimum)
            {
                timer1.Stop();
                return;
            }
            circularProgressBar1.Value = auto.Speed;
            circularProgressBar1.Text = auto.Speed.ToString();
        }
    }
}
