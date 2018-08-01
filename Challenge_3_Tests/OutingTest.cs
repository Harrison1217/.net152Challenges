using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class OutingTest
    {
        OutingRepository outingRepo = new OutingRepository();
        [TestMethod]
        public void OutingRepository_GetList_CountShouldBeTheSame()
        {
            //--Arrange
            List<OutingClass> outingList = outingRepo.GetList();

            //--Act
            int actual = outingList.Count;
            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_AddingOuting()
        {
            //--Arrange
            OutingClass newOuting = new OutingClass("Basketball Game", 4000, 200, DateTime.Parse("12/12/1212"));
            outingRepo.AddOutingtoList(newOuting);
            List<OutingClass> outingList = outingRepo.GetList();

            //--Act
            int actual = outingList.Count;
            int expected = 5;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OutingRepository_AddingOutingToList()
        {
            //--Arrange
            OutingClass newOuting = new OutingClass("Basketball Game", 4000, 200, DateTime.Parse("12/12/1212"));
            List<OutingClass> newList = new List<OutingClass>();
            newList.Add(newOuting);
            outingRepo.AddOutingtoList(newList);
            List<OutingClass> outingList = outingRepo.GetList();

            //--Act
            int actual = outingList.Count;
            int expected = 5;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void OutingRepository_CalcTotalCostOfAllOutings()
        {
            //--Arrange
            double actual;
            double expected;
            //-Act
            actual = outingRepo.TotalCostoFAllOutings();
            expected = 14000;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
