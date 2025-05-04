using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBusquedaBinaria


{

    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearch_ElementPresent_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
            int target = 23;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BinarySearch_ElementNotPresent_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
            int target = 100;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { };
            int target = 5;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_SingleElementArray_Present_ReturnsZero()
        {
            // Arrange
            int[] arr = { 42 };
            int target = 42;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinarySearch_SingleElementArray_NotPresent_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { 42 };
            int target = 24;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_FirstElement_ReturnsZero()
        {
            // Arrange
            int[] arr = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
            int target = 10;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinarySearch_LastElement_ReturnsLastIndex()
        {
            // Arrange
            int[] arr = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
            int target = 91;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void BinarySearch_MiddleElement_ReturnsMiddleIndex()
        {
            // Arrange
            int[] arr = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
            int target = 78;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BinarySearch_LargeArray_ElementPresent_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = i * 2; // Array de números pares 0, 2, 4, ..., 19998
            }
            int target = 1234 * 2;

            // Act
            int result = Program.BinarySearch(arr, target);

            // Assert
            Assert.AreEqual(1234, result);
        }
    }
}