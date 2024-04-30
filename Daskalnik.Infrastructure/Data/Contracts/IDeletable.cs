namespace Daskalnik.Infrastructure.Data.Contracts
{
    /// <summary>
    /// Keeps track about record deletion and its deletion time.
    /// </summary>
    public interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
