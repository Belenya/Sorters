using System.Collections;

namespace BubbleSortTest
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 6, 4, 99, 12, 97}, new int[] { 1, 2, 3, 4, 6, 12, 97, 99 })]
        [TestCase(new char[] { 'a', 'c', 'b'}, new char[] { 'a', 'b', 'c'})]
        public void BubbleSortTestIncrease(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new IncreaseComparer());
            Assert.AreEqual(expectredResult, input);
        }

        [Test]
        [TestCase(new int[] { 1, 3, 2, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new char[] { 'a', 'c', 'b' }, new char[] { 'c', 'b', 'a' })]
        public void BubbleSortTestDecrace(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new DecreaseComparer());
            Assert.AreEqual(expectredResult, input);
        }

        [Test]
        [TestCase(new int[] {1, 4, 2, 3, 5}, 0, 2, 4, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 4, 2 }, 0, 1, 2, new int[] { 1, 2, 4 })]
        [TestCase(new char[] { 'a', 'c', 'b' }, 0, 1, 2, new char[] { 'a', 'b', 'c'})]
        public void MergeTest(Array inputArray, int start, int middle, int end, Array expectredResult)
        {
            var sorter = new MergeSorter();
            sorter.MergeForTest(inputArray, start, middle, end, new IncreaseComparer());
            Assert.AreEqual(expectredResult, inputArray);
        }

        [Test]
        [TestCase(new int[] { 1, 4, 2, 3, 5 }, 0, 2, 4, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 4, 2 }, 0, 1, 2, new int[] { 1, 2, 4 })]
        [TestCase(new char[] { 'a', 'c', 'b' }, 0, 1, 2, new char[] { 'a', 'b', 'c' })]
        public void MergeSorterTest(Array inputArray, int start, int middle, int end, Array expectredResult)
        {
            var sorter = new MergeSorter();
            sorter.Sort(inputArray, new IncreaseComparer());
            Assert.AreEqual(expectredResult, inputArray);
        }
    }
}