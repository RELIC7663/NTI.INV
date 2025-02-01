using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NTI.INV;

    public class DBContext : IdentityDbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<NTI.INV.Permisos> Permisos { get; set; } = default!;

        public DbSet<NTI.INV.Usuarios> Usuarios { get; set; } = default!;

        public DbSet<NTI.INV.Productos> Productos { get; set; } = default!;

        public DbSet<NTI.INV.Categoria> Categoria { get; set; } = default!;
    }
