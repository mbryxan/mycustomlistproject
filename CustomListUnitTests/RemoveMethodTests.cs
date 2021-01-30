using CustomListYtterbium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListUnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]

    public class RemoveMethodTests

    {
        public void RemoveItemFromCustomList_CheckCountEquals2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color1 = "Yellow";
            string color2 = "Purple";
            string color3 = "Black"; ;
            int actual;
            int expected = 2;

            //Act
            list.Add(color1);
            list.Add(color2);
            list.Add(color3);
            list.Remove(color2);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void RemoveItemsFromCustomListAtIndex2_CheckForNewItemAtIndex2()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string customer1 = "Chris";
            string customer2 = "Dave";
            string customer3 = "John";
            string customer4 = "Mark";
            string expected = "Mark";
            string actual;

            // Act
            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);
            list.Add(customer4);
            list.Remove("John");

            actual = list[2];

            // Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CreateANewListOfFiveItemsAndRemoveItem_CapacityShouldBeFour()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            int actual;
            int expected = 8;

            //Act
            list.Add("Sun");
            list.Add("Saturn");
            list.Add("Pluto");
            list.Add("Mars");
            list.Add("Moon");
            list.Remove("Mars");

            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void CreateANewListofAndRemoveZeroIndex_SeeIfMoveUpProperly()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            string customer1 = "Paul";
            string customer2 = "Dave";
            string customer3 = "John";
            string customer4 = "Mark";
            string customer5 = "Ringo";
            string customer6 = "Derek";
            string expected = "Dave";
            string actual;

            //Act

            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);
            list.Add(customer4);
            list.Add(customer5);
            list.Add(customer6);
            list.Remove("Chris");

            actual = list[1];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void CreateNewListAndRemoveTwoItems_CheckIndexOfItemNowAtIndex2()
        {
            CustomList<string> list = new CustomList<string>();

            //Arrange

            string item1 = "thread";
            string item2 = "needle";
            string item3 = "scissors";
            string item4 = "pattern";
            string item5 = "iron";
            string expected = "iron";
            string actual;

            //Act

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Add(item5);
            list.Remove("thread");
            list.Remove("pattern");

            actual = list[2];

            //Assert
            Assert.AreEqual(expected, actual);




        }


    }

}

