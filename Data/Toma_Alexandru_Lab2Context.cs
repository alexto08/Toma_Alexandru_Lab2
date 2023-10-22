using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Toma_Alexandru_Lab2.Models;

namespace Toma_Alexandru_Lab2.Data
{
    public class Toma_Alexandru_Lab2Context : DbContext
    {
        public Toma_Alexandru_Lab2Context (DbContextOptions<Toma_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Toma_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Toma_Alexandru_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
