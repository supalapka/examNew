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
using System.Windows.Navigation;
    
namespace examNew
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Maximized)
                WindowState = WindowState.Maximized;
            else WindowState = WindowState.Normal;
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMainMenu_Click(object sender, RoutedEventArgs e)
        {
        //  this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }

       
    }
}
