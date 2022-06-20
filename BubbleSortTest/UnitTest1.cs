using System.Collections;

namespace BubbleSortTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 6, 4, 99, 12, 97}, new int[] { 1, 2, 3, 4, 6, 12, 97, 99 })]
        [TestCase(new char[] { 'a', 'c', 'b'}, new char[] { 'a', 'b', 'c'})]
        public void BubbleSortTestIncrease(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new IncreaseComparer());
            Assert.AreEqual(expectredResult, input);
        }
    }
}