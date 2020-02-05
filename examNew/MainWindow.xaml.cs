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

namespace examNew
{
  
    public partial class MainWindow : Window
    {
        public string ImageLogoPath = $"{Environment.CurrentDirectory}\\resources\\AppLogo.png";

        public MainWindow()
        {
            InitializeComponent();
            ImageLogoPath += "1";
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
    }
}
