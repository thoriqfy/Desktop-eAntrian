namespace eAntrian_Skeleton_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Pasien")]
    public partial class Pasien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nama { get; set; }
        public string NoBPJS { get; set; }
        public string Password { get; set; }




    }
}