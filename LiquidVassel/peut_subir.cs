namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.peut_subir")]
    public partial class peut_subir
    {
        public DateTime? dateDebut { get; set; }

        public DateTime? dateFinEstimee { get; set; }

        public DateTime? datefinReelle { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string IDmat { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_AnomB { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(5)]
        public string codePort { get; set; }

        public virtual AnomalieB AnomalieB { get; set; }

        public virtual Bateau Bateau { get; set; }

        public virtual Terminal Terminal { get; set; }
    }
}
