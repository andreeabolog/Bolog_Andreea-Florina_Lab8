using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bolog_Andreea_Florina_Lab8.Models;

namespace Bolog_Andreea_Florina_Lab8.Data
{
    public class Bolog_Andreea_Florina_Lab8Context : DbContext
    {
        public Bolog_Andreea_Florina_Lab8Context (DbContextOptions<Bolog_Andreea_Florina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bolog_Andreea_Florina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bolog_Andreea_Florina_Lab8.Models.Publisher> Publisher { get; set; }
        public DbSet<Bolog_Andreea_Florina_Lab8.Models.Category> Category { get; set; }
    }
}
