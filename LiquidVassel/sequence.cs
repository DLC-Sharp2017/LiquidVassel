namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.sequence")]
    public partial class sequence
    {
        public DateTime? dateDepart { get; set; }

        public DateTime? dateEstimee { get; set; }

        public DateTime? dateReelle { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(5)]
        public string IdRota { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(5)]
        public string codePortDep { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(5)]
        public string codePortArr { get; set; }

        public virtual Rotation Rotation { get; set; }

        public virtual Terminal Terminal { get; set; }

        public virtual Terminal Terminal1 { get; set; }
    }
}
