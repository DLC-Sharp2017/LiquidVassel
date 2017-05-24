namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Armateur")]
    public partial class Armateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Armateur()
        {
            Bateaux = new HashSet<Bateau>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(6)]
        public string Idarma { get; set; }

        [Required]
        [StringLength(25)]
        public string NomArma { get; set; }

        [Required]
        [StringLength(25)]
        public string LoginArma { get; set; }

        [Required]
        [StringLength(40)]
        public string Motdepassearma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bateau> Bateaux { get; set; }
    }
}
