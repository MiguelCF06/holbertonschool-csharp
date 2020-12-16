using NUnit.Framework;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void When_NumIsZero_ReturnsNull()
        {
            int [,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int [,] result = Matrix.Divide(matrix, 0);
            Assert.AreEqual(null, result);
        }
        
        [Test]
        public void When_MatrixIsNull_ReturnsNull()
        {
            int [,] matrix = null;
            int [,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Divide_WhenMatrixAndNumAreOkay_ReturnsDividedMatrix()
        {
            int [,] matrix = new int[2, 3] {{4, 34, 2}, {23, 56, 34}};
            int [,] dividedMatrix = Matrix.Divide(matrix, 2);
            Assert.AreEqual(new int[2,3] {{2, 17, 1}, {11, 28, 17}}, dividedMatrix);
        }
    }
}