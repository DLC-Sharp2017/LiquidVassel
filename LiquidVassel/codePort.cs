namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.codePort")]
    public partial class codePort
    {
        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string IdPays { get; set; }

        [Required]
        [StringLength(25)]
        public string codeVille { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string codeVille_1 { get; set; }

        [Key]
        [Column("codePort", Order = 1, TypeName = "char")]
        [StringLength(5)]
        public string codePort1 { get; set; }

        public virtual Terminal Terminal { get; set; }

        public virtual Ville Ville { get; set; }
    }
}
