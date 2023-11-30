namespace DrawShape
{
    public interface IShape
    {
        double GetPerimeter();

        double GetArea();

        string Draw();

        string GetName();
    }
}
