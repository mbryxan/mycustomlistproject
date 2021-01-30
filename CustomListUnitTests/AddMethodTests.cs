using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListYtterbium;


namespace CustomListUnitTests
{
    [TestClass]
    public class AddMethodTests
    {

        // How do we know we've successfully added something to our CustomList?
        // Count goes up when we add?
        // test that the item was added to the right index (indexes outside of zero)
        // test for different types of data working correctly         

        [TestMethod]
        public void AddItemToCustomList_CheckCountEquals3()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string color1 = "Red";
            string color2 = "Blue";
            string color3 = "Brown";
            int actual;
            int expected = 3;

            //Act
            list.Add(color1);//{"Red"}
            list.Add(color2);//{"Red", "Blue"}
            list.Add(color3);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void AddItemToCustomList_CheckForItemAtIndex0()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "AirMax";
            string actual;

            // Act
            list.Add(expected);
            actual = list[0];

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void AddItemsToCustomList_CheckForItemAtIndex3()
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

            actual = list[3];

            // Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_CreateANewList_CapacityShouldBeFour()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();

            int actual;
            int expected = 4;

            //Act

            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_CreateListExceedInitalCapacity_CapacityShouldBeEight()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();//whenever it's first created, capacity is 4
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int valueFive = 5;
            int actual;
            int expected = 8;

            //Act
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //create another add test that checks index of the initial list after the capacity is exceeded

        public void Add_CheckIndex_AfterCapacityIsExpanded()
        {
            //arrange
            CustomList<string> materialslist = new CustomList<string>();
            string materialOne = "Cotton";
            string materialTwo = "Polyester";
            string materialThree = "Rayon";
            string materialFour = "Leather";
            string materialFive = "Silk";
            string actual;
            string expected = "Silk";

            //act
            materialslist.Add(materialOne);
            materialslist.Add(materialTwo);
            materialslist.Add(materialThree);
            materialslist.Add(materialFour);
            materialslist.Add(materialFive);

            actual = materialslist[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
