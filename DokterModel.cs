namespace eAntrian_Skeleton_
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DokterModel : DbContext
    {
        public DokterModel()
            : base("name=DokterModel")
        {
        }

        public virtual DbSet<DataDokter> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
