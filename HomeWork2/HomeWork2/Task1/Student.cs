namespace HomeWork2.Task1;

internal class Student
{
    private string _name;
    private int _age;

    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello , my name is {_name} and I am {_age} years old ");
    }
    public Student(string name, int age)
    {
        name = Name;
        age = Age;
    }
}
