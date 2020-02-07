using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for HowToCookPage.xaml
    /// </summary>
    public partial class HowToCookPage : Page
    {
        Dishes dish = null;
        public string StepOne { get; set; }
        public string StepTwo { get; set; }
        public string StepThree { get; set; }
        public string StepLast { get; set; }

        public HowToCookPage()
        {
            InitializeComponent();
        }

        public HowToCookPage(Dishes _dish)
        {
            InitializeComponent();
            dish = _dish;
        }

        private void ButtonDone_Click(object sender, RoutedEventArgs e)
        {
            dish.StepOne = TextBoxFirstStep.Text;
            dish.StepTwo = TextBoxSecondStep.Text;
            dish.StepThree = TextBoxThirdStep.Text;
            dish.StepLast = TextBoxLastStep.Text;
            if (AllRecipes.DishesList == null)
                AllRecipes.DishesList = new List<Dishes>();
            AllRecipes.DishesList.Add(dish);
            this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));

            //var path = $"{Environment.CurrentDirectory}\\SomeRecipes.json";
            //var serialize = JsonConvert.SerializeObject(AllRecipes.DishesList);
            //File.WriteAllText(path, serialize);

        }
    }
}
