using System.Text;

namespace DrawShape.Shapes
{
    public class Rectangle : IShape
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public string Draw()
        {
            var str = new StringBuilder();

            for (int i = 0; i < width; i++)
            {
                str.Append('*', length);
                str.Append('\n');
            }

            return str.ToString();
        }
        public string GetName()
        {
            return "Прямоугольник";
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
