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
  
    public partial class SearchByIngredients : Page
    {
        public SearchByIngredients()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < AllRecipes.DishesList.Count;i++)
            {
                for (int ing = 0; ing < AllRecipes.DishesList[i].Ingredients.Count; ing++)
                if(textBox.Text == AllRecipes.DishesList[i].Ingredients[ing])
                    {
                        textBlock.Text += AllRecipes.DishesList[i].Name;
                        textBlock.Text += "\n";
                    }
            }
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
