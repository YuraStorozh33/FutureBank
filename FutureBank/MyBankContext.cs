using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureBank
{
    public class MyBankContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public MyBankContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=FutureBank.db");

        }


    }
}
