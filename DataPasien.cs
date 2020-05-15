namespace eAntrian_Skeleton_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class DataPasien
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(20)]
        public string NoBPJS { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int? NoAntrian { get; set; }

        public int SudahAntri { get; set; }

        [StringLength(50)]
        public string JanjiDgnDokter { get; set; }
    }
}
