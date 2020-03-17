using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public class Checkout : BaseEntity
    {
        [Required]
        public LibraryAsset LibraryAsset { get; set; }

        public LibraryCard LibraryCard { get; set; }

        public DateTime Since { get; set; }

        public DateTime Until { get; set; }
    }
}
