namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Capitaine")]
    public partial class Capitaine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Capitaine()
        {
            Bateaux = new HashSet<Bateau>();
            Categories = new HashSet<Categorie>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(7)]
        public string IDcapitaine { get; set; }

        [Required]
        [StringLength(25)]
        public string NomCapt { get; set; }

        [Required]
        [StringLength(25)]
        public string PrenomCapt { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string IdPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bateau> Bateaux { get; set; }

        public virtual pay pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categorie> Categories { get; set; }
    }
}
