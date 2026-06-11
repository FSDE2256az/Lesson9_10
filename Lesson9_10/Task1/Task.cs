namespace Lesson9_10.Task1;


public class Shape
{
    protected virtual double Area { get; set; }
    public override string ToString() => $@"Area: {Area}";

}

public class Rectangle : Shape
{
    private double _width;
    public virtual double Width
    {
        get { return _width; }
        set
        {
            _width = value;
            Area = _width * Height;
        }
    }


    private double _height;
    public virtual double Height
    {
        get { return _height; }
        set
        {
            _height = value;
            Area = _height * Width;
        }
    }


    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;

        Area = Width * Height;
    }

    public override string ToString()
    => $@"{base.ToString()}
Heigth :{Height}
Width: {Width}
";

}

public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
    }

    public override double Height
    {
        get => base.Height;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override double Width
    {
        get => base.Width;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        Area = radius * radius * 3.14;
    }

    public override string ToString()
 => $@"{base.ToString()}
Radius: {Radius}
";

}
