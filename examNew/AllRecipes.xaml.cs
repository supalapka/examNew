using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Timers;
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
    public partial class AllRecipes : Page
    {

        static public List<Dishes> DishesList { get; set; }

        public AllRecipes()
        {
            InitializeComponent();
            if (DishesList == null)
            {
                DishesList = new List<Dishes>();
            }
            DataContext = this;

        }

        //void InitializeDishList()
        //{
        //    Dishes dish1 = new Dishes();
        //    dish1.Name = "borsch";
        //    dish1.KindOfDish = "ukrainian";
        //    dish1.TypeOfDish = "first cource";
        //    dish1.OrderOfDish = DishOrder.firstCource;

        //    Dishes dish2 = new Dishes();
        //    dish2.Name = "fried potatoes";
        //    dish2.TypeOfDish = "second cource";
        //    dish2.KindOfDish = "german";
        //    dish2.OrderOfDish = DishOrder.secondCource;

        //    Dishes dish4 = new Dishes();
        //    dish4.Name = "just salad";
        //    dish4.TypeOfDish = "salad";
        //    dish4.KindOfDish = "unknown";
        //    dish4.OrderOfDish = DishOrder.salad;

        //    Dishes dish3 = new Dishes();
        //    dish3.Name = "milkshake";
        //    dish3.TypeOfDish = "dessert";
        //    dish3.KindOfDish = "unknown";
        //    dish3.OrderOfDish = DishOrder.dessert;

        //    Dishes dish5 = new Dishes();
        //    dish5.Name = "just salad2";
        //    dish5.TypeOfDish = "salad";
        //    dish5.KindOfDish = "unknown";
        //    dish5.OrderOfDish = DishOrder.salad;

        //    DishesList.Add(dish1);
        //    DishesList.Add(dish5);
        //    DishesList.Add(dish3);
        //    DishesList.Add(dish2);
        //    DishesList.Add(dish4);

        //    DishesList = DishSortByOrder(DishesList);
        //}


        public List<Dishes> DishSortByOrder(List<Dishes> dishes) //first cource -> 2 cource -> ... -> dessert
        {
            for (int counter = 0; counter < dishes.Count - 1; counter++)
            {
                for (int i = 0; i < dishes.Count - 1; i++)
                {
                    if (dishes[i].OrderOfDish > dishes[i + 1].OrderOfDish)
                    {
                        Dishes tmp = dishes[i];
                        dishes[i] = dishes[i + 1];
                        dishes[i + 1] = tmp;
                    }
                }
            }
            return dishes;
        }


        private void ButtonMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            RecipeInfo recipeInfo = new RecipeInfo(dishList.SelectedIndex);
            this.NavigationService.Navigate(recipeInfo);
            contextMenu1.IsOpen = false;

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            DishesList.RemoveAt(dishList.SelectedIndex);
            contextMenu1.IsOpen = false;
        }

        private void ButtonUploadSomePecipes_Click(object sender, RoutedEventArgs e)
        {
            var path = $"{Environment.CurrentDirectory}\\SomeRecipes.json";
            string output = File.ReadAllText(path);
            var deserialize = (List<Dishes>)JsonConvert.DeserializeObject(output, typeof(List<Dishes>));
            DishesList = deserialize;
            this.DataContext = this;
        }
    }
}

