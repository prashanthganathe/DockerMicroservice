using DockerMicroservice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMicroservice.Context
{
    public class MicroServiceContext:DbContext
    {
        private readonly IConfiguration _config;
        public MicroServiceContext(DbContextOptions options):base(options)
        //public MicroServiceContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            //_config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            base.OnConfiguring(bldr);

            // Connect to local Db
           
        }
        public DbSet<ParentEntity> Parent { get; set; }
        public DbSet<ChildEntity> Children { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<ParentEntity>()
            //                  .Property(p => p.Name)
            //                  .HasMaxLength(100);

           // builder.Entity<ParentEntity>().HasData(SeedData.ParentSeed());
           // builder.Entity<ChildEntity>().HasData(SeedData.ChildSeed());


        }

     
    }
}
