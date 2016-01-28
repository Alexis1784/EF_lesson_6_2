using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_2
{
    class MyContext : DbContext 
    {
        static MyContext()
        {
            Database.SetInitializer(new MyContextInitializer());
        }
        public MyContext () : base ("EF_lesson_6_2")
        { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
                .HasRequired(c => c.Company)
                .WithOptional(c => c.BestSeller);

            base.OnModelCreating(modelBuilder);
        }
    }
}
