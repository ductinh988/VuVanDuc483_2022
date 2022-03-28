using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuVanDuc2022483.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<VuVanDuc2022483.Models.Person> Person { get; set; }

        public DbSet<VuVanDuc2022483.Models.VVD0483> VVD0483 { get; set; }
    }
