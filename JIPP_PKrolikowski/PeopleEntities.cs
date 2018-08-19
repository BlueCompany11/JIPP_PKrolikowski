namespace JIPP_PKrolikowski
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PeopleEntities : DbContext
    {
        public PeopleEntities()
            : base("name=PeopleEntities")
        {
        }

        public virtual DbSet<People> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
