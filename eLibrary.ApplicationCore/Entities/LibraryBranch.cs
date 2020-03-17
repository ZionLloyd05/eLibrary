using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public class LibraryBranch : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }

        public string Description { get; set; }

        public DateTime OpenDate { get; set; }

        public string ImageUrl { get; set; }

        public virtual IEnumerable<Patron> Patrons { get; set; }

        public virtual IEnumerable<LibraryAsset> LibraryAssets { get; set; }
    }
}
