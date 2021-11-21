namespace ClassLibrary1.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Round : BaseFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public int R { get; set; }
        
        /// <summary>
        /// Метод вычисления площади круга
        /// </summary>
        public override double CountArea()
        {
            Area = 3.14 * R * R;
            return Area;
        }

        public Round(params int[] r)
        {
            R = r[0];
        }
    }
}