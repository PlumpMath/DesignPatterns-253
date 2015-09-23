﻿using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class PersonAdapter :
        Adapter<ICustomer, IPerson>
    {
        public override IPerson Adapt(ICustomer value)
        {
            if (value == null)
                return null;

            return new Person
            {
                Id = value.Id,
                FirstName = value.FirstName,
                MiddleName = value.MiddleName,
                LastName = value.LastName,
                Email = value.Email,
                CreatedOn = value.CreatedOn,
                CreatedBy = value.CreatedBy,
                LastModifiedOn = value.LastModifiedOn,
                LastModifiedBy = value.LastModifiedBy
            };
        }
    }
}
