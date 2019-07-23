using NUnit.Framework;
using CustomListProject;
using System;
namespace CustomListProjectTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Add_AddToEmptyList_ItemShouldGoToIndexZero()
        {
            //arrange
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 4;
            int actual;

            //act
            test.Add(4);
            actual = test[0];
            Assert.AreEqual(expected, actual);

        }
        public void Add_AddToEmptyList_CountShouldIncreaseToOne()
        {
            //arrange
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 1;
            int actual;
            //act
            test.Add(1);
            actual = test.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddToEmptyList_CapacityShouldIncreasetoEight()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 5;
            int actual;

            test.Capacity(5);
            actual = test.Capacity;
            Assert.AreEqual(expected, actual);


        }
        public void Add_AddToEmptyList_ItemShouldGoToIndexFour()
        {
            CustomListTest<int> test = new CustomListTest<int>();

            int expected = 5;
            int actual;

            test.Add(5);
            actual = test[4];
            Assert.AreEqual(expected, actual);

        }
        public void Add_AddToEmptyList_CountShouldIncreaseToFive()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 5;
            int actual;

            test.Count(5);
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddToPopulatedList_ItemShouldGoToIndexZero()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 1;
            int actual;
            test.Add(1);
            actual = test[0];
            Assert.AreEqual(expected, actual);
        }


        public void Remove_RemoveFromPopulatedList_CountShouldDecreaseByOne()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected;
            int actual = 0;
            test.Remove(0)
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromEmptyList_CountShouldStayTheSame()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 0;
            int actual = 0;
            test.Remove(0);
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromPopulatedList_ItemShouldBeRemovedAtIndexNine()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 9;
            int actual;
            test.Remove(9);
            actual = test[9];
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddToPopulatedList_CountShouldIncreaseToNine()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 9;
            int actual;
            test.Count(9);
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddToPopulatedList_ItemShouldGoToIndexFour()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 5;
            int actual;
            test.Add(5);
            actual = test[4];
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddToPopulatedList_CapacityShouldIncreaseToTwelve()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 9;
            int actual;
            test.Capacity();
            actual = test.Capacity(9);
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddToPopulatedList_ItemShouldGoToIndexEight()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 9;
            int actual;
            test.Add(9);
            actual = test.Add[8];
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddToPopulatedList_CapacityShouldStayAtTwelve()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 10;
            int actual;
            test.Capacity();
            actual = test.Capacity(10);
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddToPopulatedList_CountShouldIncreaseToEleven()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 11;
            int actual;
            test.Count();
            actual = test.Count(11);
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromPopulatedList_CapacityShouldReturntoFour()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 5;
            int actual;
            test.Add(5);
            actual = test[4];
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromPopulatedList_ItemIsRemoved()
    
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 0;
            int actual;
            test.Remove(0);
            actual = test[0];
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromPopulatedList_CountShouldDecreaseByOne()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 0;
            int actual;
            test.Remove(0);
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveFromPopulatedList_ItemShould
    }   
}