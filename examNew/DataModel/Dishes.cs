using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace examNew
{
    public class Dishes
    {
        public string Name { get; set; }
        public string KindOfDish { get; set; }
        public string TypeOfDish { get; set; }
        public DishOrder OrderOfDish { get; set; }
        public string StepOne { get; set; }
        public string StepTwo { get; set; }
        public string StepThree { get; set; }
        public string StepLast { get; set; }
        public BitmapImage Image { get; set; } /*= new BitmapImage(new Uri("NoImage.png", UriKind.RelativeOrAbsolute));*/
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}
