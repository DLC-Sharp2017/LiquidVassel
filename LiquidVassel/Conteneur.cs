namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Conteneur")]
    public partial class Conteneur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conteneur()
        {
            transvases = new HashSet<transvase>();
            Etat_tc = new HashSet<Etat_tc>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(11)]
        public string IdTc { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string iso { get; set; }

        public float poidsBrut { get; set; }

        public bool Dgxtc { get; set; }

        [StringLength(3)]
        public string classDgtx { get; set; }

        [Required]
        [StringLength(7)]
        public string numDouane { get; set; }

        public bool autoDouane { get; set; }

        public bool boolDamage { get; set; }

        public int EVP { get; set; }

        public int idClient { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(5)]
        public string iso_Type_Iso { get; set; }

        public virtual Client Client { get; set; }

        public virtual Type_Iso Type_Iso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transvase> transvases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etat_tc> Etat_tc { get; set; }
    }
}
