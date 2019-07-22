using NUnit.Framework;
using System;
namespace CustomListProjectTest
{
    [TestFixture()]
    public class CustomListTest<T>
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
            int expected = 
            int actual;

            test.Count
            actual = test.Count;
        }
        public void Add_AddToPopulatedList_CountShouldIncreasetoNine()
        {
            CustomListTest<int> test = new CustomListTest<int>();
            int expected = 9;
            int actual;
            test.Count(9);
            actual = test.Count;
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddToPopulatedList_



       
    }
}
