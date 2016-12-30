namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DADOS_ARQUIVO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_ARQ { get; set; }

        [StringLength(30)]
        public string DESC_ARQ { get; set; }

        public bool? STAT_ARQ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ARQ { get; set; }
    }
}
