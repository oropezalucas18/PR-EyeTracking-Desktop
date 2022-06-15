using AForge.Imaging.Filters;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaPlayerTest
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Balloon> HeatmapData;
        Bitmap bmHeatmap;

        public MainWindow()
        {
            InitializeComponent();          
        }

        private BitmapImage ToBitmapImage(Bitmap bitmapRes)
        {
            using (var memory = new MemoryStream())
            {
                bitmapRes.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                return bitmapImage;
            }
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {                                   
            GenerateHeatmap();           
        }

        private void GenerateHeatmap()
        {
            if (BalloonsData.IsFileSelected != true)
                lblData.Content = "Seleccione un archivo CSV.";
            else
            {
                try
                {                    
                    HeatmapData = BalloonsData.GetBalloons();                    
                    bmHeatmap = Heatmap.GetHeatmap(HeatmapData, (int)imgDisplay.Width, (int)imgDisplay.Height);

                    bmHeatmap = AForge.Imaging.Image.Clone(bmHeatmap, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Dilatation filter = new Dilatation();
                    filter.ApplyInPlace(bmHeatmap);
                    filter.ApplyInPlace(bmHeatmap);

                    imgDisplay.Source = ToBitmapImage(bmHeatmap);

                    BalloonsData.IsHeatmapGenerated = true;
                    lblData.Content = "Mapa de calor generado correctamente.";
                }
                catch (Exception ex)
                {
                    lblData.Content = ex.Message;
                }
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnImportCsv_Click(object sender, RoutedEventArgs e)
        {
            SelectCsv();
            lblCsv.Content = BalloonsData.FileName;
        }

        private void SelectCsv()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Archivos csv (*.csv)|*.csv";

            if (ofd.ShowDialog() == true)
            {
                BalloonsData.FilePath = ofd.FileName;                
                BalloonsData.FileName = ofd.SafeFileName;
                BalloonsData.IsFileSelected = true;
            }
        }

        private void btnSaveHeatmap_Click(object sender, RoutedEventArgs e)
        {
            SaveHeatmap();
        }

        private void SaveHeatmap()
        {
            if (BalloonsData.IsHeatmapGenerated != true)
                lblData.Content = "Genere un mapa de calor para guardar.";
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image|*.jpg|Image|*.jpeg|Image|*.png";

                if (saveFileDialog.ShowDialog() == true)
                {
                    var encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(imgDisplay.Source as BitmapImage));
                    using (var stream = saveFileDialog.OpenFile())
                    {
                        encoder.Save(stream);
                    }

                    lblData.Content = "Mapa de calor guardado correctamente.";
                }
            }
            
        }

    }
}
