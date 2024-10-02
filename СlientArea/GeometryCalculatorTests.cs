using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        public void CalculateCircleArea_WithPositiveRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void CalculateCircleArea_WithZeroRadius_ReturnsZero()
        {
            // Arrange
            double radius = 0;
            double expectedArea = 0;

            // Act
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CalculateCircleArea_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateCircleArea(radius));
        }

        [TestMethod]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            // Act
            double actualArea = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void CalculateTriangleArea_WithInvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1;
            double sideB = 1;
            double sideC = 3;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }

        [TestMethod]
        public void CalculateTriangleArea_WithNegativeSide_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = -5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }

        [TestMethod]
        public void CalculateTriangleArea_WithZeroSide_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 3;
            double sideB = 0;
            double sideC = 5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC));
        }
    }
}