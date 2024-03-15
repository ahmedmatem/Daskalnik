using Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;

namespace Infrastructure.Data.Abstracts
{
    public abstract class DataModel : IAuditable, IDeletable
    {
        [Key]
        [Comment("Unique data model identifier.")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Comment("Indicate a record in table as deleted or not.")]
        public bool IsDeleted { get; set; }

        [DataType(DataType.DateTime)]
        [Comment("Mark the date of deleting the record in the table.")]
        public DateTime? DeletedOn { get; set; }

        [DataType(DataType.DateTime)]
        [Comment("Mark the date of created the record on in the table.")]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        [Comment("Mark the date of last modifing the record in the table.")]
        public DateTime? LastModifiedOn { get; set; }
    }
}
