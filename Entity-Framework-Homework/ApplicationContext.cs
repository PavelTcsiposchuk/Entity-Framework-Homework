using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Homework
{
    class ApplicationContext : DbContext
    {
        static ApplicationContext() 
        {
            Database.SetInitializer<ApplicationContext>(new ApplicationContextInitializater());
        }

        public ApplicationContext() : base("ApplicationContext")
        {
            Database.SetInitializer<ApplicationContext>(new ApplicationContextInitializater());
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Musician> Musicians { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // использование Fluent API
            modelBuilder.Entity<Band>().ToTable("Bands");
            modelBuilder.Entity<Musician>().ToTable("Musicians");
            modelBuilder.Entity<Band>().HasKey(p => p.Name);
            modelBuilder.Entity<Musician>().HasKey(p => new { p.Surname, p.FirstName} ); //key like this isn`t very comfortable, but it is test project
            modelBuilder.Entity<Musician>().Property(p => p.Country).IsOptional();
            //modelBuilder.Entity<Musician>().Property(p => p.Band).IsRequired();
            modelBuilder.Entity<Musician>().Property(p => p.Age).IsOptional();
            modelBuilder.Entity<Musician>().Property(p => p.Role).IsOptional();
            modelBuilder.Entity<Band>().Property(p => p.Genre).IsOptional();
            modelBuilder.Entity<Band>()
                    .HasMany(p => p.Members)
                    .WithRequired(p => p.Band);

            base.OnModelCreating(modelBuilder);
        }

    }


}
