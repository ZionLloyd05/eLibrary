using eLibrary.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Entities
{
    public abstract class BaseEntity : IAggregateRoot
    {
        public int Id { get; set; }
    }
}
