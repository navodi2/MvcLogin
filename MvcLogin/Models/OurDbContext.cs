using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcLogin.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}