namespace EduHub.Ch01.Domain;

public class SponsorshipContract
{
    public Guid Id { get; private set; }
    public Guid SponsorId { get; private set; }
    public decimal FundingAmount { get; private set; }

    private SponsorshipContract(Guid id, Guid sponsorId, decimal fundingAmount)
    {
        Id = id;
        SponsorId = sponsorId;
        FundingAmount = fundingAmount;
    }

    public static SponsorshipContract Create(Guid sponsorId, decimal fundingAmount)
    {
        if (fundingAmount <= 0) 
            throw new ArgumentException("Số tiền tài trợ phải lớn hơn 0!");

        return new SponsorshipContract(Guid.NewGuid(), sponsorId, fundingAmount);
    }
}
