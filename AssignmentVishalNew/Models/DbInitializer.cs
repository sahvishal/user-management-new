using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject.Models
{
    public static class DbInitializer
    {
        public static void SeedOrganizationTypes(AppDbContext context)
        {
            if(!context.OrganizationTypes.Any())
            {
                context.AddRange
                    (
                    new OrganizationType { Name = "Super Admin", AliasName = "CEO" },
                    new OrganizationType { Name = "Distributor", AliasName = "Distributor" },
                    new OrganizationType { Name = "Customer", AliasName = "Customer" }
                    );
                context.SaveChanges();
            }
        }

        public static void SeedOrganizations(AppDbContext context)
        {
            if (!context.Organizations.Any())
            {
                context.AddRange
                    (
                    new Organization { Name = "Super Admin", Email="vishal.sahu@taazaa.com", OrganizationTypeId=1 }
                    );
                context.SaveChanges();
            }
        }

        public static void SeedUserLogins(AppDbContext context)
        {
            if (!context.UserLogins.Any())
            {
                context.AddRange
                    (
                    new UserLogin { UserName = "vishal.sahu", Password = "taazaa@123", IsDeleted = false }
                    );
                context.SaveChanges();
            }
        }


        public static void SeedPersons(AppDbContext context)
        {
            if (!context.Persons.Any())
            {
                context.AddRange
                    (
                    new Person { FirstName = "Vishal", LastName = "Sahu", IsActive = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
