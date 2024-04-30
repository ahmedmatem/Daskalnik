
namespace Daskalnik.Infrastructure.Data.Contracts
{
    /// <summary>
    /// Applays information on the record about its creation and modification times.
    /// </summary>
    public interface IAuditable
    {
        DateTime? CreatedOn { get; set; }
        
        DateTime? LastModifiedOn { get; set; }
    }
}
