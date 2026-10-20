namespace EduHub.Ch01.Domain;
public class FundManager
{
    public Guid Id { get; private set; }
    public string StudentId { get; private set; }

    private FundManager(Guid id, string studentId)
    {
        Id = id;
        StudentId = studentId;
    }
    public static FundManager Create(string studentId)
    {
        if (string.IsNullOrWhiteSpace(studentId)) 
            throw new ArgumentException("Mã số sinh viên thủ quỹ không hợp lệ!");

        return new FundManager(Guid.NewGuid(), studentId);
    }
}
