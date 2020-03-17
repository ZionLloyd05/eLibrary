using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public class LibraryCard : BaseEntity
    {
        public decimal Fees { get; set; }

        public DateTime Created { get; set; }

        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
