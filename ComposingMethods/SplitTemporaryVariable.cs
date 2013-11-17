namespace Composing_Methods
{
    public class SplitTemporaryVariable
    {
        public void SetPerimeterAndArea(decimal height, decimal width)
        {
            var temp = 2*(height + width);
            SetDoublePerimeter(temp);
            temp = height*width;
            SetDoubleArea(temp);
        }

        private decimal doubleArea;
        private void SetDoubleArea(decimal value)
        {
            doubleArea = value * 2;
        }

        public decimal GetDoubleArea()
        {
            return doubleArea;
        }

        private decimal doublePerimeter;
        private void SetDoublePerimeter(decimal value)
        {
            doublePerimeter = value * 2;
        }

        public decimal GetDoublePerimeter()
        {
            return doublePerimeter;
        }
    }
}