using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hulujan_Lorena_Viorica_Lab8.Models;

namespace Hulujan_Lorena_Viorica_Lab8.Data
{
    public class Hulujan_Lorena_Viorica_Lab8Context : DbContext
    {
        public Hulujan_Lorena_Viorica_Lab8Context (DbContextOptions<Hulujan_Lorena_Viorica_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hulujan_Lorena_Viorica_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hulujan_Lorena_Viorica_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hulujan_Lorena_Viorica_Lab8.Models.Category> Category { get; set; }
    }
}
