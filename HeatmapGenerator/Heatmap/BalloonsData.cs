using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeatmapGenerator.Heatmap
{
    public static class BalloonsData
    {
        public static List<Balloon> HeatmapData { get; set; }
        public static string FilePath { get; set; }
        public static string FileName { get; set; }
        public static bool IsFileSelected { get; set; }
        public static bool IsHeatmapGenerated { get; set; }

        public static List<Balloon> GetBalloons(double initialTime, double finalTime, double naturalDuration)
        {
            HeatmapData = new List<Balloon>();
            string[] data = File.ReadAllLines(FilePath);
            double majorX = GetXMajor();
            double majorY = GetYMajor();
            double majorTime = GetTimeMajorMenor()[0];
            double menorTime = GetTimeMajorMenor()[1];           

            for (int i = 0; i < data.Length; i++)
            {
                double time = Balloon.Remap(double.Parse(data[i].Split(',')[2]), menorTime, majorTime, 0, naturalDuration);
                if (time >= initialTime && time <= finalTime)
                {                    
                    HeatmapData.Add(Balloon.BalloonValues(data[i], majorX, majorY));
                }
                    
            }
            return HeatmapData;
        }
        private static double GetXMajor()
        {
            string[] data = File.ReadAllLines(FilePath);
            int[] dataInt = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                dataInt[i] = int.Parse(data[i].Split(',')[0]);
            }

            int major = dataInt.Max();

            return major;
        }

        private static double GetYMajor()
        {
            string[] data = File.ReadAllLines(FilePath);
            int[] dataInt = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                dataInt[i] = int.Parse(data[i].Split(',')[1]);
            }

            int major = dataInt.Max();

            return major;
        }

        private static double[] GetTimeMajorMenor()
        {
            string[] data = File.ReadAllLines(FilePath);
            double[] dataInt = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                dataInt[i] = int.Parse(data[i].Split(',')[2]);
            }

            double[] majorMenorTime = new double[2];
            majorMenorTime[0] = dataInt.Max();
            majorMenorTime[1] = dataInt.Min();

            return majorMenorTime;
        }
    }
}
