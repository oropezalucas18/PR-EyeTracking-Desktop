using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerTest
{
    public class Heatmap
    {
        private static Bitmap BmHeatmap { get; set; }        
        
        private static Dictionary<IntRange, Color> Colors = new Dictionary<IntRange, Color>()
        {
            //Celeste
            { new IntRange(0, 0), Color.FromArgb(150, 144, 174, 240)},                          
            //Verde
            { new IntRange(1, 2), Color.FromArgb(150, 11, 249, 68)},   
            //Amarillo
            { new IntRange(3, 4), Color.FromArgb(150, 232, 252, 44)},             
            //Rojo
            { new IntRange(5, 100), Color.FromArgb(150, 247, 72, 37)}  
        };

        public static Bitmap GetHeatmap(List<Balloon> balloons, int width, int height)
        {
            BmHeatmap = FillHeatmap(balloons, width, height);
            return BmHeatmap;
        }

        public static Bitmap FillHeatmap(List<Balloon> balloons, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);            

            for (int row = 0; row < b.Width; row++)
            {
                for (int col = 0; col < b.Height; col++)
                {
                    int count = CalculateDistance(balloons, row, col);
                    b.SetPixel(row, col, GetColor(count));
                }
            }

            return b;
        }

        public static int CalculateDistance(List<Balloon> balloons, int xPixel, int yPixel) 
        {
            int count = 0;

            foreach (Balloon balloon in balloons)
            {
                double distance = Math.Sqrt((Math.Pow(balloon.X - xPixel, 2) + Math.Pow(balloon.Y - yPixel, 2)));
                //double distance = Math.Abs(balloon.X - xPixel) + Math.Abs(balloon.Y - yPixel);
                if (distance <= 12) count ++;
            }
            
            return count;            
        }

        public static Color GetColor(double count)
        {
            foreach (var color in Colors)
            {
                if (count >= color.Key.Start && count <= color.Key.End)
                {
                    return color.Value;
                }
            }

            return Color.Transparent;
        }

        public class IntRange
        {
            public int Start { get; set; }
            public int End { get; set; }

            public IntRange(int start, int end)
            {
                Start = start;
                End = end;
            }
        }
    }

    
}
