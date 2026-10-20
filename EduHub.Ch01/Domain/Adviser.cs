namespace EduHub.Ch01.Domain;
public class Adviser
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Department { get; private set; }
    private Adviser(Guid id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }
    public static Adviser Create(string name, string department)
    {
        if (string.IsNullOrWhiteSpace(name)) 
            throw new ArgumentException("Tên giảng viên không được để trống!");
        if (string.IsNullOrWhiteSpace(department)) 
            throw new ArgumentException("Tên khoa không được để trống!");

        return new Adviser(Guid.NewGuid(), name, department);
    }
}
