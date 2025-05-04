using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBusquedaLineal
{
    [TestClass]
    public class LinearSearchTests
    {
        // Clase que contiene el método LinearSearch para probar
        public class LinearSearchClass
        {
            public static int LinearSearch(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i;
                    }
                }
                // Si el número no está, retorna -1
                return -1;
            }
        }

        [TestMethod]
        public void LinearSearch_TargetExistsInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 30;
            int expected = 2;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_TargetExistsAtBeginning_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 10;
            int expected = 0;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_TargetExistsAtEnd_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 50;
            int expected = 4;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_TargetDoesNotExist_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 25;
            int expected = -1;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { };
            int target = 10;
            int expected = -1;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_UnsortedArray_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { 50, 30, 10, 40, 20 };
            int target = 10;
            int expected = 2;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_DuplicateValues_ReturnsFirstOccurrence()
        {
            // Arrange
            int[] arr = { 10, 20, 20, 20, 30, 40 };
            int target = 20;
            int expected = 1; // La búsqueda lineal siempre devuelve la primera ocurrencia

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_SingleElementArrayTargetFound_ReturnsZero()
        {
            // Arrange
            int[] arr = { 10 };
            int target = 10;
            int expected = 0;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_SingleElementArrayTargetNotFound_ReturnsMinusOne()
        {
            // Arrange
            int[] arr = { 10 };
            int target = 20;
            int expected = -1;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_NegativeNumbers_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = { -30, -20, -10, 0, 10, 20 };
            int target = -10;
            int expected = 2;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LinearSearch_LargeArray_ReturnsCorrectIndex()
        {
            // Arrange
            int[] arr = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                arr[i] = i;
            }
            int target = 999;
            int expected = 999;

            // Act
            int result = LinearSearchClass.LinearSearch(arr, target);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}