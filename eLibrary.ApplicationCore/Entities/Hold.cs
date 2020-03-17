using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public class Hold : BaseEntity
    {
        public virtual LibraryAsset LibraryAsset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime HoldPlaced { get; set; }
    }
}
