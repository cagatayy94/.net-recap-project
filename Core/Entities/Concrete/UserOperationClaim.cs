namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public object UserOperationClaimId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
