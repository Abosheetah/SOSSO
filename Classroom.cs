public class Classroom
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> StudentIds { get; set; }

    public Classroom(int id, string name, List<int> studentIds)
    {
        Id = id;
        Name = name;
        StudentIds = studentIds;
    }
}