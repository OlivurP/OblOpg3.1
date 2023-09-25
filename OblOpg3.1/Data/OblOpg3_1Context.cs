using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OblOpg3._1.Model;

namespace OblOpg3._1.Data
{
    public class OblOpg3_1Context : DbContext
    {
        public OblOpg3_1Context (DbContextOptions<OblOpg3_1Context> options)
            : base(options)
        {
        }

        public DbSet<OblOpg3._1.Model.Frugt> Frugt { get; set; } = default!;
    }
}
