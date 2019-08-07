using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP.Otomobile_Indicator
{
    public delegate void OverSpeedEventHandler(int gear, Color color);

    

    public class Otomobile
    {
        public event OverSpeedEventHandler OverSpeed;
        public event OverSpeedEventHandler Gear1;
        public event OverSpeedEventHandler Gear2;
        public event OverSpeedEventHandler Gear3;
        public event OverSpeedEventHandler Gear4;
        public event OverSpeedEventHandler Gear5;
        public event OverSpeedEventHandler Gear6;

        public Otomobile(int speed,string brand)
        {
            this.Speed = speed;
            this.Brand = brand;
        }

        int _speed;
        public int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                if (value >200)
                {
                    OverSpeed(6, Color.FromArgb(255, 65, 54));
                }
                else if (value >=1 && value<=30)
                {
                    Gear1(1, Color.FromArgb(0, 116, 217));
                }
                else if (value>=31 && value <=50)
                {
                    Gear2(2, Color.FromArgb(1, 255, 112));
                }
                else if (value>=51 && value <=70)
                {
                    Gear3(3, Color.FromArgb(46, 204, 64));
                }
                else if (value>=71 && value <=90)
                {
                    Gear4(4, Color.FromArgb(255, 133, 27));
                }
                else if (value>=91 && value <=120)
                {
                    Gear5(5, Color.FromArgb(235,45, 28));
                }
                else if (value>=121 && value<=200)
                {
                    Gear6(6, Color.FromArgb(28, 69, 61));
                }
            }
        }
        public string Brand { get; set; }
    }
}
