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
using todosEjercicios.Cap10;
using todosEjercicios.Cap12;

namespace todosEjercicios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejer1MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer1Cap10 = new ejer1Cap10();
            ejer1Cap10.Show();
        }

        private void Ejer2MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer2Cap10 = new ejer2Cap10();
            ejer2Cap10.Show();
        }

        private void Ejer_3_4_5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer_3_4_5_Cap10 = new ejer_3_4_5_Cap10();
            ejer_3_4_5_Cap10.Show();
        }

        private void Ejer1Cap12MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var ejer_1_2_Cap12 = new ejer_1_2_Cap12();
            ejer_1_2_Cap12.Show();
        }


    }
}
