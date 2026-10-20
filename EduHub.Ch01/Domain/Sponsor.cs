namespace EduHub.Ch01.Domain;

public class Sponsor
{
    public Guid Id { get; private set; }
    public string CompanyName { get; private set; }

    private Sponsor(Guid id, string companyName)
    {
        Id = id;
        CompanyName = companyName;
    }

    public static Sponsor Create(string companyName)
    {
        if (string.IsNullOrWhiteSpace(companyName)) 
            throw new ArgumentException("Tên công ty tài trợ không được trống!");

        return new Sponsor(Guid.NewGuid(), companyName);
    }
}
