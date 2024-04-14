using System;

public class Person
{
    public string PublicName;
    private int privateAge;
    protected string ProtectedGender;
    internal string InternalAddress;

    public Person(string name, int age, string gender, string address)
    {
        PublicName = name;
        privateAge = age;
        ProtectedGender = gender;
        InternalAddress = address;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {PublicName}, Age: {privateAge}, Gender: {ProtectedGender}, Address: {InternalAddress}");
        Learn();
    }

    public virtual void Learn()
    {
        Console.WriteLine("Person is learning something new.");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

public class Student : Person
{
    internal string Course;

    public Student(string name, int age, string gender, string address, string course) : base(name, age, gender, address)
    {
        ProtectedGender = "Unknown";
        Course = course;
    }

    public override void Learn()
    {
        Console.WriteLine("Student is learning something new.");
        ProtectedMethod();
    }

    public void Study()
    {
        Console.WriteLine($"Student {PublicName} is studying.");
        ProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John", 25, "Male", "123 Main St");
        Student student = new Student("Alice", 20, "Female", "456 College Ave", "Computer Science");

        person.DisplayInformation();
        student.DisplayInformation();
        student.Study();
    }
}
