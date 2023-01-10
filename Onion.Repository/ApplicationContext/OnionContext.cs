using Microsoft.EntityFrameworkCore;
using Onion.Data.Access;
using Onion.Data.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository.ApplicationContext
{
    public class OnionContext:DbContext
    {
        public OnionContext(DbContextOptions options)
    : base(options)
        {
        }
        #region Entities
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion
    }
}
