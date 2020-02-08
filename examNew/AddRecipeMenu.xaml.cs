using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace examNew
{
    /// <summary>
    /// Interaction logic for AddRecipeMenu.xaml
    /// </summary>
    public partial class AddRecipeMenu : Page
    {
        Dishes dish = new Dishes();

        public string Ingredients
        {
            get { return (string)this.GetValue(IngredientsProperty); }
            set { this.SetValue(IngredientsProperty, value); }
        }

        public static readonly DependencyProperty IngredientsProperty =
       DependencyProperty.Register("Ingredients", typeof(string), typeof(AddRecipeMenu));

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

            dish.Image = bitmapImage;

        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            dish.Name = TextBoxDishName.Text;
            dish.KindOfDish = TextBoxKindOfDish.Text;

            if (ComboBoxTypeOfDish.SelectedIndex == 0)
            {
                dish.TypeOfDish = "First course";
            }
            else if (ComboBoxTypeOfDish.SelectedIndex == 1) dish.TypeOfDish = "Second course";
            else if (ComboBoxTypeOfDish.SelectedIndex == 2) dish.TypeOfDish = "Salad";
            else if (ComboBoxTypeOfDish.SelectedIndex == 3) dish.TypeOfDish = "Dessert";

            HowToCookPage howToCookPage = new HowToCookPage(dish);

            this.NavigationService.Navigate(howToCookPage);
        }

        private void buttonAddIngrediente_Click(object sender, RoutedEventArgs e)
        {
            dish.Ingredients.Add(TextBoxIngredient.Text);
            Ingredients += TextBoxIngredient.Text;
            Ingredients += "\n";
            TextBoxIngredient.Clear();
            this.DataContext = this;
        }

       
    }
}
