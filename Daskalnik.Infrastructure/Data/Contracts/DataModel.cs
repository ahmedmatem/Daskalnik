
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Daskalnik.Infrastructure.Data.Contracts
{
    /// <summary>
    /// Base data model.
    /// </summary>
    [Comment("Base data model.")]
    [Index(nameof(IsDeleted))]
    public abstract class DataModel : IAuditable, IDeletable
    {
        [Key]
        [Comment("Unique data model identifier.")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Marks the record in database as deleted or not.
        /// </summary>
        [Comment("Marks the record in database as deleted or not.")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Holds the date-time information about record deletion.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Comment("Holds the date-time information about record deletion.")]
        public DateTime? DeletedOn { get; set; }

        /// <summary>
        /// Holds date of creation for the record in database.
        /// </summary>
        [Comment("Holds date of creation for the record in database.")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Holds date of the last modification for the record in database.
        /// </summary>
        [Comment("Holds date of the last modification for the record in database.")]
        [DataType(DataType.DateTime)]
        public DateTime? LastModifiedOn { get; set; }
    }
}
