using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class MenuTest
    {
        MenuRepository menuRepo = new MenuRepository();
        [TestMethod]
        public void MenuRepository_GetList_CountShouldBeSame()
        {

            //-- Arrange
            List<MenuClasses> menuList = menuRepo.GetList();

            //-- Act
            int actual = menuList.Count;
            int expected = 3;

            //-- Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MenuRepository_AddItem_CountShouldIncrease()
        {

            //-- Arrange
            MenuClasses newItem = new MenuClasses(4, "name", "description", "ingredients", 12.99);
            menuRepo.AddItemToMenu(newItem);
            List<MenuClasses> menuList = menuRepo.GetList();

            //-- Act 
            int actual = menuList.Count;
            int expected = 4;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MenuRepository_RemoveItemFromList_ShouldDecreaseCount()
        {
            //-- Arrange
            List<MenuClasses> menuList = menuRepo.GetList();
            menuRepo.RemoveItemByNumber(1);

            //-- Act 
            int actual = menuList.Count;
            int expected = 2;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_AddItemList_CountShouldIncrease()
        {

            //-- Arrange
            MenuClasses newItem = new MenuClasses(4, "name", "description", "ingredients", 12.99);
            List<MenuClasses> newList = new List<MenuClasses>();
            newList.Add(newItem);
            menuRepo.AddItemToMenu(newList);
            
            List<MenuClasses> menuList = menuRepo.GetList();

            //-- Act 
            int actual = menuList.Count;
            int expected = 4;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
