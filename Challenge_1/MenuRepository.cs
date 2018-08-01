using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
   public  class MenuRepository
    {
        private List<MenuClasses> _MenuItems = new List<MenuClasses>()
        {
            new MenuClasses (1, "Cheese Burger", "All Beef Patty, Served on a Sesame Seed Bun", "All Beef Patty, Pickels, American Cheese, Ketchup, Muatard, Onions, Tomatos", 3.49),
            new MenuClasses (2, "Mexican Double Decker Bus", "We take two Beef pattys and 3 buns to make this double decker delight, Add in Sauted Onions and Peppers, Sliced jalapenos, top it off with our home made Salsa.", "Two All Beef Pattys, Sauted Onions and Peppers, SLiced Jalapenos, Pepper Jack Cheese, Home made salsa", 8.99),
            new MenuClasses (3, "Cheese Pizza", "Hand tossed Pizza, Homemade tomato sauce, Covered in our special six cheese blend", "Dough, tomato paste, six cheese blend", 15.89)

        };
        
        public void AddItemToMenu(MenuClasses item)
        {
            _MenuItems.Add(item);
        }

        public void AddItemToMenu(List<MenuClasses> items)
        {
            foreach (MenuClasses item in items)
            {
                _MenuItems.Add(item);
            }
        }



        public List<MenuClasses> GetList()
        {
            return _MenuItems;
        }

        public void RemoveItemByNumber(int Num)
        {
            List<MenuClasses> removing = _MenuItems.FindAll(x => x.mealNumber == Num);
            foreach (MenuClasses meal in removing)
            {
                _MenuItems.Remove(meal);
            }
        }


    }
}
