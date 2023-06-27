using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bingit.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bingit.Models.TXTLOPHOC> TXTLOPHOC { get; set; } = default!;

        public DbSet<Bingit.Models.TXTSINHVIEN> TXTSINHVIEN { get; set; } = default!;
    }
