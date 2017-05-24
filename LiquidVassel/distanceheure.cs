namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.distanceheure")]
    public partial class distanceheure
    {
        public int? heures { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(5)]
        public string codePortDep { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(5)]
        public string codePortArr { get; set; }

        public virtual Terminal Terminal { get; set; }

        public virtual Terminal Terminal1 { get; set; }
    }
}
