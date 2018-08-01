using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class ProgramUI
    {
        MenuRepository menuRepo = new MenuRepository();
        private List<MenuClasses> tempList = new List<MenuClasses>();
        public void run()
        {
            InitialPrompt();
        }
        private void InitialPrompt()
        {
            



            Console.WriteLine("Please select an option:\n 1) Add Menu Item \n 2) Remove Menu Item \n 3) Display Menu");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                NewMenuItem();
            }
            else if (option == 2)
            {
                RemoveMenuItem();
            }
            else if (option == 3)
            {
                DisplayList();
            }
        }
        private void NewMenuItem()
        {

            Console.WriteLine("What will be the Menu Number?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give a name to the menu Item:");
            string name = Console.ReadLine();
            Console.WriteLine("Please give a short description of the Item");
            string description = Console.ReadLine();
            Console.WriteLine("Please add the ingredients for this Item");
            string ingredients = Console.ReadLine();
            Console.WriteLine("Please List the Price for this Item");
            double price = Convert.ToDouble(Console.ReadLine());

            MenuClasses newItem = new MenuClasses(num, name, description, ingredients, price);

            menuRepo.AddItemToMenu(newItem);
            InitialPrompt();
        }

        private void RemoveMenuItem()
        {
            Console.WriteLine("Please selece the number of the Item you Would Like to Remove.");
            int num = Convert.ToInt32(Console.ReadLine());
            menuRepo.RemoveItemByNumber(num);
            InitialPrompt();

        }

        private void DisplayList()
        {
            tempList = menuRepo.GetList();
            foreach(MenuClasses item in tempList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            InitialPrompt();

        }

    }
}
