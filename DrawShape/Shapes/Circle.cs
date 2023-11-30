using System.Text;

namespace DrawShape.Shapes
{
    public class Circle : IShape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public string Draw()
        {
            var str = new StringBuilder();

            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        str.Append('*');
                    }
                    else
                    {
                        str.Append(' ');
                    }
                }
                str.Append('\n');
            }

            return str.ToString();
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public string GetName()
        {
            return "Круг";
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
