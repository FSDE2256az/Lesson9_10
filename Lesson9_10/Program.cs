using Lesson9_10.Helper;
using Lesson9_10.Models;

namespace Lesson9_10;

internal class Program
{
    static void Main(string[] args)
    {
        // // OOP ( keyword )

        // this     +
        // base     +
        // sealed   +

        // virtual  +
        // override +
        // new      +
        // static

        /// OOP Principles

        // 1. Encapsulation => +
        // 2. Inheritance   
        // 3. Polymorphism
        //   1. Static      => Func overrid
        //   2. Dinamic     => virtual, overrid

        // 4. Abstaction 

        // ///////////////////////////////////////////////////////////


        // var person = new Person()
        // {
        //     Id = 1,
        //     Name = "Kamran",
        //     Surname = "Karimzada"
        // };
        // 
        // Console.WriteLine(person);
        // 
        // var person2 = new Person(1, "Xayyam", "Qasimov", 19);
        // Console.WriteLine(person2);

        // var teacher = new Teacher()
        // {
        //     Id = 1,
        //     Name = "Kamran",
        //     Surname = "Karimzada"
        // };
        // Console.WriteLine(teacher);

        // var teacher2 = new Teacher(1, "Ismayil", "Surname", 30, "Group", "Programming", "Bomba muellimdir");
        // Console.WriteLine(teacher2);
        //
        // teacher2.Speak();
        // teacher2.SpeakPoly();

        // new 

        // Person teacher2 = new Teacher(1, "Ismayil", "Surname", 30, "Group", "Programming", "Bomba muellimdir");
        //
        // //Console.WriteLine(teacher2);
        // teacher2.Speak();
        // teacher2.SpeakPoly();
        //
        // (teacher2 as Teacher)!.Speak();

        // ///////////////////////////////////////////////////////////

        // static

        // Console.WriteLine(Operators.Azercell);
        // Console.WriteLine(Operators.Bakcell);
        // Console.WriteLine(Operators.Nar);
        // Console.WriteLine(Operators.Garabagh);

        // int number = 0;
        // 
        // Console.WriteLine(number.IsEven());
        // Console.WriteLine(number.ToBoolen());


        // Task 1: 
        // Shape => Area, ToString()

        // Square    => P 
        // Rectangle => P
        // Circle


        // ///////////////////////////////////////////////////////////

        static void ChangeSize(Rectangle rectangle)
        {
            rectangle.Width = 50;
        }

        Shape[] shapes =
        {
            new Rectangle(5, 10),
            new Square(5),
            new Circle(5)
        };

        if (shapes[0] is Rectangle s)
        {
            ChangeSize(s);
        }

        foreach (var item in shapes)
        {
            //if (item is Rectangle st)
            //    Console.WriteLine(st.Width);

            Console.WriteLine(item);
        }

    }
}

// ///////////////////////////////////////////////////////////

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
