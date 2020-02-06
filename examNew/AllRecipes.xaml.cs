using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //public static readonly DependencyProperty DishesListProperty = DependencyProperty.Register("DishesList", typeof(List<Dishes>),
        //    typeof(AllRecipes), new PropertyMetadata()) ;
        static public List<Dishes> DishesList { get; set; }
        //{
        //    get { return (List<Dishes>)this.GetValue(DishesListProperty); }
        //    set { this.SetValue(DishesListProperty, value); }
        //}    

        public AllRecipes()
        {
            InitializeComponent();
            if (DishesList == null)
            {
                DishesList = new List<Dishes>();
                    InitializeDishList();
            }
            DataContext = this;

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
            DishesList.Add(dish5);
            DishesList.Add(dish3);
            DishesList.Add(dish2);
            DishesList.Add(dish4);

            DishesList = DishSortByOrder(DishesList);
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
            //  ContextMenu contextMenu = new ContextMenu();
            //  Button buttonWatch = new Button();
            ////  buttonWatch.BorderThickness = ;
            //  buttonWatch.Content = "Watch this recipe";
            //  contextMenu.Items.Add(buttonWatch);
            //  contextMenu.IsOpen = true;
            //var timer = new System.Windows.Threading.DispatcherTimer();
            //timer.Tick += new EventHandler(timerTick);
            //timer.Interval = new TimeSpan(0, 0, 5);
            //timer.Start();
        }

        //private void timerTick(object sender, EventArgs e)
        //{
        //    System.Threading.Thread.Sleep(5000);
        //}


        private void TypeDishSOrt_Click(object sender, RoutedEventArgs e)
        {
            DishesList = DishSortByOrder(DishesList);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(DishesListProperty.ToString()));
        }

        private void ButtonMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
        }

        //private void dishList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        //{
        //    ContextMenu contextMenu = new ContextMenu();
        //    Button buttonWatch = new Button();
        //    //  buttonWatch.BorderThickness = ;
        //    buttonWatch.Content = "Watch this recipe";
        //    contextMenu.Items.Add(buttonWatch);
        //    contextMenu.IsOpen = true;


        //    var timer = new System.Windows.Threading.DispatcherTimer();
        //    timer.Tick += new EventHandler(timerTick);
        //    timer.Interval = new TimeSpan(0, 0, 50);
        //    timer.IsEnabled = true;
        //    timer.Start();
        //}

        //private void timerTick(object sender, EventArgs e)
        //{
        //    System.Threading.Thread.Sleep(500);
        //}

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
          

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            DishesList.RemoveAt(dishList.SelectedIndex);
            contextMenu1.IsOpen = false;
        }
    }
}

