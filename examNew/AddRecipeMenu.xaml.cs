using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Interaction logic for AddRecipeMenu.xaml
    /// </summary>
    public partial class AddRecipeMenu : Page
    {
        public AddRecipeMenu()
        {
            InitializeComponent();
        }

        private void ButtonUploadImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog imgFile = new OpenFileDialog();
            imgFile.Filter = "PNG|*.png|JPG|*.jpg";
            imgFile.ShowDialog();

            BitmapImage bitmapImage = new BitmapImage(new Uri(imgFile.FileName, UriKind.RelativeOrAbsolute));
            imageContent.Source = bitmapImage;
            ButtonUploadImg.Content = "Змінити";
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HowToCookPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
