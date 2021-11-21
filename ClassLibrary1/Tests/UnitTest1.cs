using ClassLibrary1;
using ClassLibrary1.Figures;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private FigureAreaSolver _solver;
        [SetUp]
        public void Setup()
        {
            _solver = new FigureAreaSolver();
        }

        [Test]
        public void Test_IsTriangleRectangular_3_4_5__true()
        {
            Assert.IsTrue(_solver.IsTriangleRectangular(new Triangle(3,4,5)));
        }
        
        [Test]
        public void Test_IsTriangleRectangular_3_4_4__false()
        {
            Assert.IsFalse(_solver.IsTriangleRectangular(new Triangle(3,4,4)));
        }

        [Test]
        public void Test_CountArea_1__314()
        {
            var _solver = new FigureAreaSolver();
            Assert.AreEqual(_solver.CountArea(1), 3.14);
        }
        
        [Test]
        public void Test_CountArea_3_4_5__6()
        {
            Assert.AreEqual(_solver.CountArea(3,4,5), 6);
        }

        [Test] public void Test_CountArea_Triangle_3_4_5__6()
        {
            Assert.AreEqual(_solver.CountFigureArea(new Triangle(3,4,5)), 6);
        }
    }
}