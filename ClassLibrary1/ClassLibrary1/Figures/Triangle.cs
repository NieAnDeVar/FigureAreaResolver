using System;

namespace ClassLibrary1.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : BaseFigure
    {
        public int A { get; set; }
        
        public int B { get; set; }
        
        public int C { get; set; }
        
        public bool IsRectangular { get; set; }

        public override double CountArea()
        {
            var p = (A + B + C) / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }
        
        /// <summary>
        /// Метод проверки треугольника на то, что он прямоугольный
        /// </summary>
        /// <returns></returns>
        public bool IsTriangleRectangular()
        {
            IsRectangular = ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A));
            return IsRectangular;
        }

        public Triangle(params int[] param)
        {
            A = param[0];
            B = param[1];
            C = param[2];
        }
    }
    
    
}