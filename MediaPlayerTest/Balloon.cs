using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MediaPlayerTest
{
    public class Balloon
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double Time { get; set; }        

        public Balloon()
        {

        }

        public Balloon(int x, int y, int time)
        {
            X = x;
            Y = y;
            Time = time;
        }                

        public static Balloon BalloonValues(string csvLine, int majorX, int majorY)
        {
            string[] values = csvLine.Split(',');
            Balloon b = new Balloon();

            b.X = Remap(int.Parse(values[0]), 0, majorX, 0, 450);
            b.Y = (values.Length < 2) ? 0 : Remap(int.Parse(values[1]), 0, majorY, 0, 300);

            return b;
        }

        private static int Remap(int value, int low1, int high1, int low2, int high2)
        {
            return low2 + (value - low1) * (high2 - low2) / (high1 - low1);
        }
    }

}
