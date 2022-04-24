using GUIA.Clases;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUIA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carro carrito;
        
        public MainWindow()
        {
            InitializeComponent();
            carrito = new Carro("Toyota", 2016, "Azul");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabelEstatusCarro.Content = carrito.Encender();
        }

        private void Acelerar_Click(object sender, RoutedEventArgs e)
        {
            LabelAcelerar.Content = carrito.Acelerar();
        }

        private void Bocinar_Click(object sender, RoutedEventArgs e)
        {
            LabelBocina.Content = carrito.Bocinar();
        }

        private void Desacelerar_Click(object sender, RoutedEventArgs e)
        {
            LabelDesacelerar.Content = carrito.Desacelerar();
        }

        private void Frenar_Click(object sender, RoutedEventArgs e)
        {
            LabelFrenar.Content = carrito.frenar();
        }

        private void Apagar_Click(object sender, RoutedEventArgs e)
        {
            LabelApagar.Content = carrito.Apagar();
        }

        private void ReproducMP3_Click(object sender, RoutedEventArgs e)
        {
            reproductor Miventana =new reproductor();
            Miventana.Owner = this;
            Miventana.ShowDialog();
        }
    }
}
