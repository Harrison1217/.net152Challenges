using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public enum carType {Gas = 1, Hybrid, Electric, Undifined}
    public class CarClass
    {
        public CarClass(carType Type, string Make, string Model, string Year, int mpg, int id)
        {
            CarType = Type;
            carMake = Make;
            carModel = Model;
            carYear = Year;
            MPG = mpg;
            ID = id;
        }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string carYear { get; set; }
        public carType CarType { get; set; }
        public int MPG { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"Car ID: {ID} \n" + 
                   $"Car Make: {carMake} \n" +
                   $"Car Model: {carModel} \n" +
                   $"Car Year: {carYear} \n" +
                   $"Car Type: {CarType} \n" +
                   $"Miles Per Gallen: {MPG} \n";
        }
    }
}
