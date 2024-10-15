using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness.Domain.Interfaces
{
    public interface ISeedUserRoleInitial
    {
        void SeedUsers();
        void SeedRoles();
    }
}