using NUnit.Framework;
using Branching;
namespace BrunchingTests
{
    public class BrunchingTests
    {
        [TestCase(2, 4, -2)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 4, 9)]
        [TestCase(3, 4, -1)]

        public void Conditions1(int a, int b, int expected)
        {
            int actual = Branching.CompareAAndBAndSolve.Condition1(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 4, "1-st quater")]
        [TestCase(2, -2, "4-th quater")]
        [TestCase(-5, -4, "3-d quater")]
        [TestCase(-3, 4, "2-nd quater")]

        public void Quater(int a, int b, string expected)
        {
            string actual = Branching.SearchForQuater.Quater(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AssendingNumbers1()
        {
            int[] expected = new int[3] { 1, 2, 3 };
            int[] actual = Branching.AscendingNumbers.IncreasingNumbers(3, 2, 1);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AssendingNumbers2()
        {
            int[] expected = new int[3] { -10, 250, 450 };
            int[] actual = Branching.AscendingNumbers.IncreasingNumbers(450, 250, -10);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 4, 1, "Корни квадратного уравнения: x1 = -3,2928932188134525, x2 = -4,707106781186548")]
        [TestCase(1, 2, 1, "Уравнение имеет один корень: x1 = -1")]
        [TestCase(1, 2, 0, "Корни квадратного уравнения: x1 = -1, x2 = -3")]
        [TestCase(8, 2, 4, "Квадратное уравнение не имеет решений")]
        public void FindDiscriminant(double a, double b, double c, string expected)
        {
            string actual = Branching.SolveTheQuadraticEquation.FindDiscriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(11, "Одинадцать ")]
        [TestCase(22, "Двадцать Два")]
        [TestCase(43, "Сорок Три")]
        [TestCase(99, "Девяносто Девять")]
        public void WriteNumber(int a, string expected)
        {
            string actual = Branching.WriteNumber.IdentifyNumber(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(9)]
        public void WriteNumberNegative(int a)
        {
            try
            {
                Branching.WriteNumber.IdentifyNumber(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}