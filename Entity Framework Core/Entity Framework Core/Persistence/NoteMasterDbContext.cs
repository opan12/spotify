using Entity_Framework_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Persistence
{
    public class NoteMasterDbContext : DbContext
    {
   
    public DbSet<Note> Notes { get; set; }
        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        optionsBuilder.UseInMemoryDatabase("NoteMaster");
        }

    }
}
