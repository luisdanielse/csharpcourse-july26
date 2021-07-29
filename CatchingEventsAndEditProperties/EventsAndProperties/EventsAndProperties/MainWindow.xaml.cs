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

namespace EventsAndProperties
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button has been clicked");
        }

        private void MouseEnterMethod(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Opacity = 0.2;
           
        }

        private void MouseLeave(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = Brushes.Red;
            button.Opacity = 1;
        }

        private void RightClickBtn(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = Brushes.Blue;
            button.Opacity = 1;
        }




    }
}
