using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MediaPlayerTest
{
    public static class BalloonsData
    {
        public static List<Balloon> HeatmapData { get; set; }
        public static string FilePath { get; set; }
        public static string FileName { get; set; }
        public static bool IsFileSelected { get; set; }
        public static bool IsHeatmapGenerated { get; set; }

        public static List<Balloon> GetBalloons()
        {            
            HeatmapData = new List<Balloon>();            
            string[] data = File.ReadAllLines(FilePath);
            int majorX = GetXMajor();
            int majorY = GetYMajor();

            for (int i = 0; i < data.Length; i++)
            {                                
                HeatmapData.Add(Balloon.BalloonValues(data[i], majorX, majorY));                                    
            }
            
            return HeatmapData;
        }        

        private static int GetXMajor()
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

        private static int GetYMajor()
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

    }
}
