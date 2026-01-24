namespace HR.Interfaces;

public interface IManagerBenefits : IBonusEligible, IAppraisable
{
    void ApproveLeave();
}