using System.Collections;

namespace SortersTests
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 6, 4, 99, 12, 97 }, new int[] { 1, 2, 3, 4, 6, 12, 97, 99 })]
        [TestCase(new char[] { 'a', 'c', 'b' }, new char[] { 'a', 'b', 'c' })]
        public void BubbleSortTestIncrease(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new IncreaseComparer());
            Assert.That(input, Is.EqualTo(expectredResult));
        }

        [Test]
        [TestCase(new int[] { 1, 3, 2, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new char[] { 'a', 'c', 'b' }, new char[] { 'c', 'b', 'a' })]
        public void BubbleSortTestDecreace(Array input, Array expectredResult)
        {
            var sorter = new BubbleSorter();
            sorter.Sort(input, new DecreaseComparer());
            Assert.That(input, Is.EqualTo(expectredResult));
        }

        [Test]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 1 }, new int[] { 1, 9 })]
        [TestCase(new int[] { 6, 4, 5 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 9, 10, 5, 6 }, new int[] { 5, 6, 9, 10 })]
        [TestCase(new int[] { 1, 4, 2, 3, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void MergeSortIncrease(Array inputArray, Array expectredResult)
        {
            var sorter = new MergeSorter();
            sorter.Sort(inputArray, new IncreaseComparer());
            Assert.That(inputArray, Is.EqualTo(expectredResult));
        }

        [Test]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 1 }, new int[] {9, 1})]
        [TestCase(new int[] { 6, 4, 5 }, new int[] {6, 5, 4})]
        [TestCase(new int[] { 9, 10, 5, 6 }, new int[] { 10, 9, 6, 5})]
        [TestCase(new int[] { 1, 4, 2, 3, 5 }, new int[] { 5, 4, 3, 2, 1})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        public void MergeSortDecreace(Array inputArray, Array expectredResult)
        {
            var sorter = new MergeSorter();
            sorter.Sort(inputArray, new DecreaseComparer());
            Assert.That(inputArray, Is.EqualTo(expectredResult));
        }
    }
}