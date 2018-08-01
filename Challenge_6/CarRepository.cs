using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public class CarRepository
    {
        private List<CarClass> _CarList = new List<CarClass>()
        {
            new CarClass (carType.Hybrid, "Porsche", "918 Spyder", "2013", 89, 1),
            new CarClass (carType.Gas, "Chevrolet", "Silverado 1500 LT", "2011", 20, 2),
            new CarClass (carType.Electric, "Nissan", "Leaf", "2018", 125, 3),

        };

        public void AddCarToList(CarClass car)
        {
            _CarList.Add(car);
        }
        public void AddCarToList(List<CarClass> cars)
        {
            foreach(CarClass car in cars)
            {
                _CarList.Add(car);
            }
        }

        public void RemoveCarByID(int car)
        {
            List<CarClass> removing = _CarList.FindAll(x => x.ID == car);
            foreach (CarClass cars in removing)
            {
                _CarList.Remove(cars);
            }
        }

        public void updateCar(carType Type, string Make, string Model, string Year, int mpg, int id)
        {
            var index = _CarList.FindIndex(x => x.ID == id);
            _CarList[index].ID = id;
            _CarList[index].carMake = Make;
            _CarList[index].carModel = Model;
            _CarList[index].CarType = Type;
            _CarList[index].carYear = Year;
            _CarList[index].MPG = mpg;
            
        }

        public List<CarClass> GetList()
        {
            return _CarList;
        }
        
    }
}
