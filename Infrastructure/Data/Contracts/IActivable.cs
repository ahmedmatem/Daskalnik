using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Contracts
{
    public interface IActivable
    {
        bool IsActivated { get; set; }

        DateTime? ActivetedOn { get; set; }
    }
}
