namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.transvase")]
    public partial class transvase
    {
        public DateTime DateTransv { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string IDmat { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "char")]
        [StringLength(11)]
        public string IdTc { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "char")]
        [StringLength(5)]
        public string codePort { get; set; }

        public virtual Bateau Bateau { get; set; }

        public virtual Conteneur Conteneur { get; set; }

        public virtual Terminal Terminal { get; set; }
    }
}
