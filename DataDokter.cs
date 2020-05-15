namespace eAntrian_Skeleton_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class DataDokter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NamaDokter { get; set; }

        [Required]
        [StringLength(20)]
        public string Spesialis { get; set; }

        [Required]
        [StringLength(50)]
        public string Jadwal { get; set; }

        public int JumlahAntrian { get; set; }

        public int AntrianSaatIni { get; set; }

        [StringLength(50)]
        public string NoBPJSygDilayani { get; set; }
    }
}
