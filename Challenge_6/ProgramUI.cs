using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public class ProgramUI
    {
        CarRepository carRepo = new CarRepository();
        private List<CarClass> tempList = new List<CarClass>();
        public void run()
        {
            InitialPrompt();
        }

        public void InitialPrompt()
        {
            Console.Clear();
            Console.WriteLine("Please Select An Option: \n 1) Add A Car \n 2) Delete A car \n 3) Update Car information For a specific car \n 4) Display List of Cars and Detials \n 5) Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                AddNewCar();
            }
            else if (option == 2)
            {
                
                DeleteCar();
            }
            else if (option == 3)
            {
                UpdateCarInfo();
            }
            else if (option == 4)
            {
                DisplayList();
            }
            else
            {
                Exit();
            }


        }

        private void AddNewCar()
        {
            Console.Clear();
            Console.WriteLine("What is the make of the Car?");
            string make = Console.ReadLine();
            Console.WriteLine("What is the model of the Car?");
            string model = Console.ReadLine();
            Console.WriteLine("Is this Car \n  Gas \n  Hybrid \n  Electric");
            string type = Console.ReadLine();
            Console.WriteLine("What is the Year of the Car?");
            string year = Console.ReadLine();
            Console.WriteLine("What is the avg MPG for the car?");
            int mpg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Assign an ID number to this Car");
            int ID = Convert.ToInt32(Console.ReadLine());
            carType gasType;
            switch (type)
            {
                case "Gas":
                    gasType = carType.Gas;
                    break;
                case "gas":
                    gasType = carType.Gas;
                    break;
                case "Hybrid":
                    gasType = carType.Hybrid;
                    break;
                case "hybrid":
                    gasType = carType.Hybrid;
                    break;
                case "Electric":
                    gasType = carType.Electric;
                    break;
                case "electric":
                    gasType = carType.Electric;
                    break;
                default:
                    gasType = carType.Undifined;
                    break;

            }

            CarClass newCar = new CarClass(gasType, make, model, year, mpg, ID);
            carRepo.AddCarToList(newCar);
            Console.Clear();
            InitialPrompt();
        }

        private void DeleteCar()
        {
            Console.Clear();
            tempList = carRepo.GetList();
            foreach (CarClass item in tempList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\n Which Car would you like to remove from the list? Please use ID Number");
            int car = Convert.ToInt32(Console.ReadLine());
            carRepo.RemoveCarByID(car);
            Console.Clear();
            InitialPrompt();

        }
        private void UpdateCarInfo()
        {
            Console.Clear();
            Console.WriteLine("What is the ID of the car being updated?");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the make of the Car?");
            string make = Console.ReadLine();
            Console.WriteLine("What is the model of the Car?");
            string model = Console.ReadLine();
            Console.WriteLine("Is this Car  \n  Gas \n  Hybrid \n  Electric");
            string type = Console.ReadLine();
            Console.WriteLine("What is the Year of the Car?");
            string year = Console.ReadLine();
            Console.WriteLine("What is the avg MPG for the car?");
            int mpg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Assign an ID number to this Car");
            int ID = Convert.ToInt32(Console.ReadLine());
            carType gasType;
            switch (type)
            {
                case "Gas":
                    gasType = carType.Gas;
                    break;
                case "gas":
                    gasType = carType.Gas;
                    break;
                case "Hybrid":
                    gasType = carType.Hybrid;
                    break;
                case "hybrid":
                    gasType = carType.Hybrid;
                    break;
                case "Electric":
                    gasType = carType.Electric;
                    break;
                case "electric":
                    gasType = carType.Electric;
                    break;
                default:
                    gasType = carType.Undifined;
                    break;

            }
            
            carRepo.updateCar(gasType, make, model, year, mpg, id);
            Console.Clear();
            InitialPrompt();

        }
        private void DisplayList()
        {
            Console.Clear();
            tempList = carRepo.GetList();
            foreach (CarClass item in tempList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();

            

        }
        private void Exit()
        {

        }
       
    }
}
