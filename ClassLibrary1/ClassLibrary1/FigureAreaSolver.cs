using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Figures;

namespace ClassLibrary1
{
    public class FigureAreaSolver
    {
        /// <summary>
        /// Добавления новых кастомных параметров для вычисления не базовой фигуры
        /// </summary>
        /// <param name="paramWithTypes">Дополнительные параметры</param>
        public static void AddNewFigures(Dictionary<int, Type> paramWithTypes)
        {
            ParamWithTypes = ParamWithTypes.Union(paramWithTypes).ToDictionary(x=>x.Key, x=>x.Value);;
        }
        
        /// <summary>
        /// Конструктор для создание параметров базовых фигур
        /// </summary>
        public FigureAreaSolver()
        {
            /// переменная которая хранит в себе соотношения кол-во параметров и типа фигуры
            ParamWithTypes = new Dictionary<int, Type>
            {
                {1, typeof(Round)},
                {3, typeof(Triangle)}
            };
        }

        private static Dictionary<int,Type> ParamWithTypes { get; set; }
        
        /// <summary>
        /// Метод для вычисления площади известной фигуры
        /// </summary>
        /// <param name="baseFigure">Фигура</param>
        /// <returns>Площадь</returns>
        public double CountFigureArea(BaseFigure baseFigure)
        {
            return baseFigure.CountArea();
        }
        
        /// <summary>
        /// Метод проверки треугольника на прямоугольность
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        public bool IsTriangleRectangular(Triangle triangle)
        {
            return triangle.IsTriangleRectangular();
        }
        
        /// <summary>
        /// Метод для вычисления неизвестной фигуры
        /// Могут возникнуть проблемы, например если заданы 4 параметра
        /// площадь параллелограмма и прямоугольника может быть разная,
        /// тогда в данном случае нужно использовать метод CountFigureArea, с уже известным типом фигуры
        /// </summary>
        /// <param name="parameters">Параметры</param>
        /// <returns>Площадь</returns>
        public double CountArea(params int[] parameters)
        {
            Type figureType;
            ParamWithTypes.TryGetValue(parameters.Length, out figureType);
            dynamic obj = Activator.CreateInstance(figureType, parameters);
            return CountFigureArea(obj);
        }
    }
}
