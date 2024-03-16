using Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Abstracts
{
    public abstract class PersonModel : DataModel, IActivable
    {
        [Comment("Indicate person as activated ot not.")]
        public bool IsActivated { get; set; }

        [DataType(DataType.DateTime)]
        [Comment("Mark the person activation date.")]
        public DateTime? ActivetedOn { get; set; }
    }
}
