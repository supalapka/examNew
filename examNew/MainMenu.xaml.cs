﻿using System;
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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonWatchAll_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AllRecipes.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ButtonAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AddRecipeMenu.xaml", UriKind.RelativeOrAbsolute));
        }


        private void ButtonSearchByIngredients_Click(object sender, RoutedEventArgs e)
        {
            //for(int i = 0; i < AllRecipes.DishesList.Count;i++)
            //{

            //}
            this.NavigationService.Navigate(new Uri("SearchByIngredients.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
