using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Troca.Models;

    public class TrocaContext : DbContext
    {
        public TrocaContext (DbContextOptions<TrocaContext> options)
            : base(options)
        {
        }

        public DbSet<Troca.Models.Usuario> Usuario { get; set; }

        public DbSet<Troca.Models.Feedback> Feedback { get; set; }
    }
