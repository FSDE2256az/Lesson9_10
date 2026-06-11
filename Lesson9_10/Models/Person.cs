namespace Lesson9_10.Models;

public /*sealed*/ class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Console.WriteLine("Person Default constructor");
    }

    public Person(int id, string name, string surname, int age)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;

        Console.WriteLine("Person Parametr Constructor");
    }


    public void Speak() { Console.WriteLine("Person Speak "); }

    public virtual void SpeakPoly()
    {
        Console.WriteLine("Person Speak Poly ");
    }



    public override string ToString()
    => $@"
Id: {Id}
Name: {Name}
Surname: {Surname}
Age: {Age}

";






}
