using System.Text;

namespace DrawShape.Shapes
{
    public class Triangle : IShape
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public string Draw()
        {
            if (!IsTriangleValid()) return "Invalid triangle sides. Cannot draw.";

            var str = new StringBuilder();

            int[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            var height = sides[2];


            if (IsRightTriangle())
            {
                for (int i = 1; i <= height; i++)
                {
                    str.Append('*', i);
                    str.Append('\n');
                }
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    str.Append(new string(' ', height - i - 1));
                    str.Append(new string('*', i * 2 + 1));
                    str.Append('\n');
                }
            }

            return str.ToString();
        }


        public string GetName()
        {
            return "Треугольник";
        }


        public double GetArea()
        {
            if (!IsTriangleValid())
                return 0;

            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public double GetPerimeter()
        {
            if (!IsTriangleValid())
                return 0;

            return sideA + sideB + sideC;
        }

        private bool IsTriangleValid()
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public bool IsRightTriangle()
        {
            int[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
