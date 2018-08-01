using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   public class MenuClasses
    {
        public MenuClasses(int menuNum, string menuName, string description, string ingredients, double price)
        {
            mealNumber = menuNum;
            mealName = menuName;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }
        public int mealNumber { get; set; }
        public string mealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{mealNumber}) {mealName}: {Description}\n" +
                   $"{Ingredients}\n" +
                   $"Price of meal: {Price}\n";
        }
    }
}
