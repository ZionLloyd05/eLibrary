﻿using Books.ApplicationCore.Specifications;
using eLibrary.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.ApplicationCore.Specifications
{
    public sealed class LibraryAssetsWithLocationAndStatus : BaseSpecification<LibraryAsset>
    {
        public LibraryAssetsWithLocationAndStatus()
           : base(null)
        {
            AddInclude(asset => asset.Location);
            AddInclude(asset => asset.Status);
        }
    }
}
