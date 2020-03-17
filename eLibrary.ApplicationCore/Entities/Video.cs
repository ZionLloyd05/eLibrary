using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}
