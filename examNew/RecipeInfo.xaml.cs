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
    /// Interaction logic for RecipeInfo.xaml
    /// </summary>
    public partial class RecipeInfo : Page
    {
        public string Name1 { get; set; }
        public string KindOfDish { get; set; }
        public string TypeOfDish { get; set; }
        public string StepOne { get; set; }
        public string StepTwo { get; set; }
        public string StepThree { get; set; }
        public string StepLast { get; set; }
        public BitmapImage Image { get; set; }

        public RecipeInfo()
        {
            InitializeComponent();
        }

          public RecipeInfo(int index)
        {
            Name1 = AllRecipes.DishesList[index].Name;
            KindOfDish = AllRecipes.DishesList[index].KindOfDish;
            TypeOfDish = AllRecipes.DishesList[index].TypeOfDish;
            StepOne = AllRecipes.DishesList[index].StepOne;
            StepTwo = AllRecipes.DishesList[index].StepTwo;
            StepThree = AllRecipes.DishesList[index].StepThree;
            StepLast = AllRecipes.DishesList[index].StepLast;
            Image = AllRecipes.DishesList[index].Image;
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
