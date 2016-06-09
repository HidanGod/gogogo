using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace gogogo.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}