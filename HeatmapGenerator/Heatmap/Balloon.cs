using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatmapGenerator.Heatmap
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

        public static Balloon BalloonValues(string csvLine, double majorX, double majorY)
        {
            string[] values = csvLine.Split(',');
            Balloon b = new Balloon();

            b.X = (int)Remap(int.Parse(values[0]), 0, majorX, 0, 450);
            b.Y = (values.Length < 2) ? 0 : (int)Remap(int.Parse(values[1]), 0, majorY, 0, 255);

            return b;
        }

        public static double Remap(double value, double low1, double high1, double low2, double high2)
        {
            return low2 + (value - low1) * (high2 - low2) / (high1 - low1);
        }
    }
}
