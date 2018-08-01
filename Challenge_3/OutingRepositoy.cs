using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        private List<OutingClass> _Outing = new List<OutingClass>()
        {
            new OutingClass("Golf", 3000, 10, DateTime.Parse("5/15/2017")),
            new OutingClass("Bowling", 2000, 100, DateTime.Parse("6/26/2017")),
            new OutingClass("Amusement Park", 4000, 200, DateTime.Parse("5/18/2018")),
            new OutingClass("Concert", 5000, 200, DateTime.Parse("7/2/2018")),


        };

        public double TotalCostoFAllOutings()
        {
            double sum = 0;
            foreach (OutingClass outing in _Outing)
            {
                sum += outing.TotalCost;

                
            }
            return sum;
        }

        public List<OutingClass> GetList()
        {
            return _Outing;
        }

        public void AddOutingtoList(OutingClass item)
        {
            _Outing.Add(item);
        }

        public void AddOutingtoList(List<OutingClass> items)
        {
            foreach (OutingClass item in items)
            {
                _Outing.Add(item);
               
            }
        }
    }
}
