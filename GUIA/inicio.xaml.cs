using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUIA
{
    /// <summary>
    /// Lógica de interacción para inicio.xaml
    /// </summary>
    public partial class inicio : Window
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void crearcarro_Click(object sender, RoutedEventArgs e)
        {
            MainWindow miVentanita = new MainWindow();
            miVentanita.Owner = this;
            miVentanita.Show();
        }
    }
}
