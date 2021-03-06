﻿using eLibrary.ApplicationCore.Entities;
using eLibrary.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLibrary.Infrastructure.Data
{
    public class SpecificationEvaluator<T> where T : BaseEntity, IAggregateRoot
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            var query = inputQuery;

            // modify the IQueryable using the specification's criteria expression
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // Checking if there are criteria definitions used
            if (specification.CriteriaDefinitions != null)
            {
                foreach (var criteria in specification.CriteriaDefinitions)
                {
                    query = query.Where(criteria.Value);
                }
            }

            // Include all expression-based includes
            query = specification.Includes.Aggregate(query,
              (current, include) => current.Include(include));

            // Include any string-based include statements
            query = specification.IncludeStrings.Aggregate(query,
           (current, include) => current.Include(include));

            //Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            if (specification.GroupBy != null)
            {
                query.GroupBy(specification.GroupBy).SelectMany(x => x);
            }

            //Apply paging if enabled
            if (specification.IsPagingEnabled)
            {
                query = query.Skip(specification.Skip)
                    .Take(specification.Take);
            }

            return query;
        }
    }
}
