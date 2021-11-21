namespace ClassLibrary1.Figures
{
    /// <summary>
    /// Абстрактный класс для фигур
    /// </summary>
    public abstract class BaseFigure
    {
        /// <summary>
        /// Площадь 
        /// </summary>
        protected virtual double Area { get; set; }
        
        /// <summary>
        /// Абстрактный метод для вычисление площади
        /// </summary>
        public abstract double CountArea();
    }
}