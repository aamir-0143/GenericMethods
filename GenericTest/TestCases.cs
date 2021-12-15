using NUnit.Framework;
using GenericMethods;


namespace GenericTest
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {

            int[] intArray = { 9, 2, 1, 4 };
            int expected = intArray[0];
            MaximumNumber<int> generic = new MaximumNumber<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxInSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {

            int[] intArray = { 2, 9, 1, 4 };
            int expected = intArray[1];
            MaximumNumber<int> generic = new MaximumNumber<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);
        }

        public void GivenMaxInThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {

            int[] intArray = { 1, 2, 9, 4 };
            int expected = intArray[2];
            MaximumNumber<int> generic = new MaximumNumber<int>(); 
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
    }
}