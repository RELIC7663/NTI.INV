using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
 
using WEB.INT;

public class DBContext : IdentityDbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WEB.INT.Permisos> Permisos { get; set; } = default!;

        public DbSet<WEB.INT.Usuarios> Usuarios { get; set; } = default!;

        public DbSet<WEB.INT.Productos> Productos { get; set; } = default!;

        public DbSet<WEB.INT.Categoria> Categoria { get; set; } = default!;
    }
