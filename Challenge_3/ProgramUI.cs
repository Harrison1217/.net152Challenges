using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class ProgramUI
    {
        OutingRepository outingRepo = new OutingRepository();
        private List<OutingClass> tempList = new List<OutingClass>();

        public void run()
        {
            InitialPrompt();
        }

        public void InitialPrompt()
        {
            Console.WriteLine("Please Select an Option: \n 1) Combine Cost of all Outings \n 2) Display List of Outings and Cost of Each \n 3) Add an Outing");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                TotalCostOfAllOutings();
            }
            else if (option == 2)
            {
                DisplayList();
            }
            else if (option == 3)
            {
                AddOuting();
            }
        }

        private void TotalCostOfAllOutings()
        {

            Console.WriteLine("The total from all outings is: " +  outingRepo.TotalCostoFAllOutings() );
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();

            
        }

        private void DisplayList()
        {
            tempList = outingRepo.GetList();
            foreach (OutingClass item in tempList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
            InitialPrompt();

        }
        private void AddOuting()
        {
            Console.WriteLine("What did you do for the Company Outing?");
            string outing = Console.ReadLine();
            Console.WriteLine("What was the total cost of the Outing?");
            double totalcost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many employees went on the Outing?");
            int numpeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the date of the outing. Please Write in this Format. mm/dd/yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());

            OutingClass newOuting = new OutingClass(outing, totalcost, numpeople, date);
            outingRepo.AddOutingtoList(newOuting);
            Console.Clear();
            InitialPrompt();
        }
    }
}
