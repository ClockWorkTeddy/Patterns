public interface IShape
{
    IShape Clone();
}

public class Circle : IShape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public Circle(Circle circle)
    {
        Radius = circle.Radius;
    }

    public IShape Clone()
    {
        return new Circle(this);
    }
}
public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public IShape Clone()
    {
        return (Rectangle)this.MemberwiseClone();
    }
}