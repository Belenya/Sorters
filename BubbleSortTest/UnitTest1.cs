namespace BubbleSortTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new object[] {1, 2, 3, 6, 4, 99, 12, 97}, new object[] { 1, 2, 3, 4, 6, 12, 97, 99 })]
        [TestCase(new object[] { 'a', 'c', 'b'}, new object[] { 'a', 'b', 'c'})]
        public void BubbleSortTest(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new IncreaseCompare());
            Assert.AreEqual(expectredResult, input);
        }
    }
}