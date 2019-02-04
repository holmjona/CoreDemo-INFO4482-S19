using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Models
{
    public class DeleteMeContext : DbContext
    {
        public DeleteMeContext (DbContextOptions<DeleteMeContext> options)
            : base(options)
        {
        }

        public DbSet<CoreDemo.Models.Actor> Actor { get; set; }
    }
}
