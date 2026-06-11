namespace Lesson9_10.Models;

public class Teacher : Person
{
    public string Group { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }


    public Teacher() : base()
    {
        Console.WriteLine("Teacher Deafult");
    }

    public Teacher(int id, string name, string surname, int age)
        : base(id, name, surname, age) { }



    public Teacher(int id, string name, string surname, int age, string group,
        string subject, string Description)
        : this(id, name, surname, age)
    {
        Group = group;
        Subject = subject;
        this.Description = Description;
    }

    public override void SpeakPoly()
    {
        Console.WriteLine("Teacher Speak Poly");
    }

    // overhide
    public new void Speak()
    {
        Console.WriteLine("Teacher Speak");
    }

    public override string ToString()
    => $@"{base.ToString()}
Group: {Group}
Subject: {Subject}
Desc: {Description}
";

}
