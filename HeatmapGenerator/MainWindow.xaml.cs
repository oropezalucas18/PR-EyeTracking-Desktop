using AForge.Imaging.Filters;
using HeatmapGenerator.Heatmap;
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
using System.Windows.Threading;

namespace HeatmapGenerator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Balloon> HeatmapData;
        Bitmap bmHeatmap;
        double initialTime;
        double finalTime;
        double naturalDuration;
        double duration;

       public MainWindow()
       {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += timer_Tick;
            timer.Start();
       }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IsPlaying(false);
            btnApply.IsEnabled = false;
            btnSaveHeatmap.IsEnabled = false;
        }

        #region WindownControls
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var point = Mouse.GetPosition(Application.Current.MainWindow);

            if (e.ChangedButton == MouseButton.Left && point.Y <= 40)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region VideoPart
        private void IsPlaying(bool bValue)
        {
            btnPlayPause.IsEnabled = bValue;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (meDisplay.Source != null)
            {
                if (meDisplay.NaturalDuration.HasTimeSpan)
                {
                    lblVideoStatus.Content = String.Format("{0} / {1}", meDisplay.Position.ToString(@"mm\:ss"), meDisplay.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                    sldNaturalDuration.Value = meDisplay.Position.TotalMilliseconds;
                }
            }
            else
                lblVideoStatus.Content = "Ningún video seleccionado...";
        }

        private void btnImportVideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files (*.mp4) | *.mp4";
            if (ofd.ShowDialog() == true)
            {
                meDisplay.Source = new Uri(ofd.FileName);
                btnPlayPause.IsEnabled = true;
                lblDataVideo.Content = ofd.SafeFileName;
            }

            SetSldInitialFinalTime();
        }

        private void SetSldInitialFinalTime()
        {
            meDisplay.IsMuted = true;
            meDisplay.Play();            

            Thread.Sleep(200);
            if (meDisplay.NaturalDuration.HasTimeSpan)
            {
                sldInitialTime.Maximum = meDisplay.NaturalDuration.TimeSpan.TotalMilliseconds;
                sldFinalTime.Maximum = meDisplay.NaturalDuration.TimeSpan.TotalMilliseconds;
                sldFinalTime.Value = sldFinalTime.Maximum;
                sldNaturalDuration.Maximum = meDisplay.NaturalDuration.TimeSpan.TotalMilliseconds;
                naturalDuration = meDisplay.NaturalDuration.TimeSpan.TotalMilliseconds;
            }

            meDisplay.Stop();
            meDisplay.IsMuted = false;
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            IsPlaying(true);
            if (btnPlayPause.Content.ToString() == "Reproducir")
            {
                meDisplay.Play();
                btnPlayPause.Content = "Pausa";
            }
            else
            {
                meDisplay.Pause();
                btnPlayPause.Content = "Reproducir";
            }


        }

        private void sldInitialTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (meDisplay.Source != null)
            {
                duration = sldFinalTime.Value - sldInitialTime.Value;
                if (sldInitialTime.Value <= finalTime - 5000)
                {
                    initialTime = sldInitialTime.Value;
                    lblInitialTime.Content = TimeSpan.FromMilliseconds(initialTime).ToString(@"mm\:ss");
                    sldNaturalDuration.Value = initialTime;
                    meDisplay.Position = TimeSpan.FromMilliseconds(initialTime);
                    lblDuration.Content = String.Format($"Duración segmento: {TimeSpan.FromMilliseconds(duration):mm\\:ss}");
                }
                else
                    sldInitialTime.Value = finalTime - 5000;
            }
        }

        private void sldFinalTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (meDisplay.Source != null)
            {
                duration = sldFinalTime.Value - sldInitialTime.Value;
                if (sldFinalTime.Value >= initialTime + 5000)
                {
                    finalTime = sldFinalTime.Value;
                    lblFinalTime.Content = TimeSpan.FromMilliseconds(finalTime).ToString(@"mm\:ss");
                    lblDuration.Content = String.Format($"Duración segmento: {TimeSpan.FromMilliseconds(duration):mm\\:ss}");
                }
                else
                    sldFinalTime.Value = initialTime + 5000;
            }
        }

        private void sldNaturalDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (meDisplay.Source != null)
            {
                if (sldNaturalDuration.Value >= initialTime)
                {
                    if (sldNaturalDuration.Value <= finalTime)
                    {
                        double time = sldNaturalDuration.Value;
                        meDisplay.Position = TimeSpan.FromMilliseconds(time);
                    }
                    else
                        sldNaturalDuration.Value = finalTime;
                }
                else
                    sldNaturalDuration.Value = initialTime;

                if (meDisplay.Position.TotalMilliseconds >= finalTime)
                {
                    meDisplay.Pause();
                    btnPlayPause.Content = "Reproducir";
                }

            }
        }
        #endregion

        #region HeatmapPart
        private void btnImportCsv_Click(object sender, RoutedEventArgs e)
        {
            SelectCsv();
            lblData.Content = BalloonsData.FileName;
        }

        private void SelectCsv()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos csv (*.csv)|*.csv";

            if (ofd.ShowDialog() == true)
            {
                BalloonsData.FilePath = ofd.FileName;
                BalloonsData.FileName = ofd.SafeFileName;
                BalloonsData.IsFileSelected = true;
                btnApply.IsEnabled = true;
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
                if (duration <= 60000)
                {
                    try
                    {
                        HeatmapData = BalloonsData.GetBalloons(initialTime, finalTime, naturalDuration);
                        bmHeatmap = HeatmapHandler.GetHeatmap(HeatmapData, (int)imgDisplay.Width, (int)imgDisplay.Height);

                        bmHeatmap = AForge.Imaging.Image.Clone(bmHeatmap, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        Dilatation filter = new Dilatation();
                        filter.ApplyInPlace(bmHeatmap);
                        filter.ApplyInPlace(bmHeatmap);

                        imgDisplay.Source = ToBitmapImage(bmHeatmap);

                        BalloonsData.IsHeatmapGenerated = true;
                        lblData.Content = BalloonsData.FileName + " - Mapa de calor generado correctamente.";
                        btnSaveHeatmap.IsEnabled = true;
                    }
                    catch (Exception ex)
                    {
                        lblData.Content = ex.Message;
                    }
                }
                else
                    lblData.Content = "La duración del segmento de video debe ser menor a 60 segundos.";
            }
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

        private void btnSaveHeatmap_Click(object sender, RoutedEventArgs e)
        {
            SaveHeatmap();
        }

        private void SaveHeatmap()
        {
            if (BalloonsData.IsHeatmapGenerated != true)
                lblData.Content = BalloonsData.FileName + " - Genere un mapa de calor para guardar.";
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

                    lblData.Content = BalloonsData.FileName + " - Mapa de calor guardado correctamente.";
                }
            }
        }
        #endregion


    }
}
