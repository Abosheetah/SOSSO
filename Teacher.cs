public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Teacher(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}