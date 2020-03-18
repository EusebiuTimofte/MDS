using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Models;

namespace ProiectMDS.Data
{
    public class ProiectMDSContext : DbContext
    {
        public ProiectMDSContext (DbContextOptions<ProiectMDSContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectMDS.Models.Album> Album { get; set; }
    }
}
