using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUIA
{
    /// <summary>
    /// Lógica de interacción para reproductor.xaml
    /// </summary>
    public partial class reproductor : Window
    {
        public reproductor()
        {
            InitializeComponent();
        }

        MediaPlayer reprodmusic= new MediaPlayer();
        string nomcanci;
        private void d_click_abrir(object sender, RoutedEventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            })
            {
                bool diaok= Convert.ToBoolean(fileDialog.ShowDialog());
                if (diaok == true)
                {
                    nomcanci = fileDialog.FileName;
                    Dcancion.Text = fileDialog.SafeFileName;
                    reprodmusic.Open(new Uri(nomcanci));
                }
            }
        }

        private void d_clickplay(object sender, RoutedEventArgs e)
        {
            reprodmusic.Play();
        }

        private void d_clickpausa(object sender, RoutedEventArgs e)
        {
            reprodmusic.Pause();
        }

        private void d_clickparar(object sender, RoutedEventArgs e)
        {
            reprodmusic.Stop();
        }
    }
}
