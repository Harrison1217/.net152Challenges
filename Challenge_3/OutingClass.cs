using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingClass
    {
        public OutingClass(string outingType, double totalcost, int numpeople, DateTime date)
        {
            Outing = outingType;
            TotalCost = totalcost;
            NumPeople = numpeople;
            Date = date;
        }

        public string Outing { get; set; }
        public double TotalCost { get; set; }
        public int NumPeople { get; set; }
        public double CostPerPerson => TotalCost / NumPeople;
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Outing}\n" +
                   $"Total Cost for Outing: {TotalCost}\n" +
                   $"Number of People on Outing: {NumPeople}\n" +
                   $"Cost Per Person: {CostPerPerson}\n" +
                   $"Date of Outing: {Date}\n";
        }
    }
}
