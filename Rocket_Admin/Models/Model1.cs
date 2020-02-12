namespace Rocket_Admin.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ORID_data> ORID_data { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<week> week { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
