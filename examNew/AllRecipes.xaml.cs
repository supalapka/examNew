using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Interaction logic for AllRecipes.xaml
    /// </summary>
    public partial class AllRecipes : Page
    {

        public List<Dishes> DishesList { get;set; }

        public AllRecipes()
        {
            InitializeComponent();
            DishesList = new List<Dishes>();
            InitializeDishList();
        }

        void InitializeDishList()
        {
            Dishes dish1 = new Dishes();
            dish1.Name = "borsch";
            dish1.KindOfDish = "ukrainian";
            dish1.TypeOfDish = "first cource";
            dish1.OrderOfDish = DishOrder.firstCource;

            Dishes dish2 = new Dishes();
            dish2.Name = "fried potatoes";
            dish2.TypeOfDish = "second cource";
            dish2.KindOfDish = "german";
            dish2.OrderOfDish = DishOrder.secondCource;

            Dishes dish4 = new Dishes();
            dish4.Name = "just salad";
            dish4.TypeOfDish = "salad";
            dish4.KindOfDish = "unknown";
            dish4.OrderOfDish = DishOrder.salad;

            Dishes dish3 = new Dishes();
            dish3.Name = "milkshake";
            dish3.TypeOfDish = "dessert";
            dish3.KindOfDish = "unknown";
            dish3.OrderOfDish = DishOrder.dessert;

            Dishes dish5 = new Dishes();
            dish5.Name = "just salad2";
            dish5.TypeOfDish = "salad";
            dish5.KindOfDish = "unknown";
            dish5.OrderOfDish = DishOrder.salad;

            DishesList.Add(dish1);
            DishesList.Add(dish2);
            DishesList.Add(dish3);
            DishesList.Add(dish4);
            DishesList.Add(dish5);
           DishesList = DishSortByOrder(DishesList);
            DataContext = this;
        }
        public List<Dishes> DishSortByOrder(List<Dishes> dishes)
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

        private void dishList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContextMenu contextMenu = new ContextMenu();
            Button buttonWatch = new Button();
          //  buttonWatch.BorderThickness = ;
            buttonWatch.Content = "Watch this recipe";
            contextMenu.Items.Add(buttonWatch);
            contextMenu.IsOpen = true;
            //Timer timer = new Timer();
        }
    }
}
