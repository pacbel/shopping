using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<DomainEntities> entidades { get; set; }
    }
}
