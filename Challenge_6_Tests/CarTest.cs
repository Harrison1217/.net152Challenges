using System;
using System.Collections.Generic;
using Challenge_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_6_Tests
{
    [TestClass]
    public class CarTest
    {
        CarRepository carRepo = new CarRepository();
        [TestMethod]
        public void CarRepository_GetList_CountShouldBetheSame()
        {
            //--Arrange
            List<CarClass> CarList = carRepo.GetList();

            //--Act
            int actual = CarList.Count;
            int expected = 3;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CarRepository_AddingCar()
        {
            //--Arrange
            CarClass newCar = new CarClass(carType.Hybrid, "Porsche", "918 Spyder", "2013", 89, 1);
            carRepo.AddCarToList(newCar);
            List<CarClass> CarList = carRepo.GetList();

            //--Act
            int actual = CarList.Count;
            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CarRepository_AddingCarToList()
        {
            //--Arrange
            CarClass newCar = new CarClass(carType.Hybrid, "Porsche", "918 Spyder", "2013", 89, 1);
            List<CarClass> newList = new List<CarClass>();
            newList.Add(newCar);
            carRepo.AddCarToList(newList);
            List<CarClass> carList = carRepo.GetList();

            //--Act
            int actual = carList.Count;
            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CarRepository_UpdatingCarInList()
        {
            //--Arrange
            CarClass newCar = new CarClass(carType.Hybrid, "Porsche", "918 Spyder", "2013", 89, 1);
            
            carRepo.AddCarToList(newCar);
            carRepo.updateCar(carType.Gas, "Porsche", "918 Spyder", "2013", 89, 1);

            //--Act
            int actual = carRepo.GetList().Count;
            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
