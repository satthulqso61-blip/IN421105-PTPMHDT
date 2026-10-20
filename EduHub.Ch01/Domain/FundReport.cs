namespace EduHub.Ch01.Domain;
public class FundReport
{
    public Guid Id { get; private set; }
    public Guid FundManagerId { get; private set; }
    public decimal TotalBalance { get; private set; }

    private FundReport(Guid id, Guid fundManagerId, decimal totalBalance)
    {
        Id = id;
        FundManagerId = fundManagerId;
        TotalBalance = totalBalance;
    }

    public static FundReport Create(Guid fundManagerId, decimal totalBalance)
    {
        if (totalBalance < 0) 
            throw new ArgumentException("Số dư quỹ không được âm!");

        return new FundReport(Guid.NewGuid(), fundManagerId, totalBalance);
    }
}
