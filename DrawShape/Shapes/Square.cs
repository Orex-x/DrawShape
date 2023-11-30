using System.Text;

namespace DrawShape.Shapes
{
    public class Square : IShape
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }   

        public string Draw()
        {
            var str = new StringBuilder();

            for(int i = 0; i < side; i++)
            {
                str.Append('*', side);
                str.Append('\n');
            }

            return str.ToString();
        }

        public string GetName()
        {
            return "Квадрат";
        }

        public double GetArea()
        {
            return side * side;
        }

        public double GetPerimeter()
        {
            return 4 * side;
        }
    }
}
