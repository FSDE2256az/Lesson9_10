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

        int number = 0;

        Console.WriteLine(number.IsEven());
        Console.WriteLine(number.ToBoolen());

    }
}
