using Domain.Configuration;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Shopping> Shoppings { get; set; }
        public virtual DbSet<IndiceMonetario> Indices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Shopping;Integrated Security=True");
        }
    }
}
