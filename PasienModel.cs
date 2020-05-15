namespace eAntrian_Skeleton_
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PasienModel : DbContext
    {
        public PasienModel()
            : base("name=PasienModel")
        {
        }

        public virtual DbSet<DataPasien> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
