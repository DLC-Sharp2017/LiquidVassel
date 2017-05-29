namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Etat_tc")]
    public partial class Etat_tc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etat_tc()
        {
            Conteneurs = new HashSet<Conteneur>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string IdDamage { get; set; }

        [Required]
        [StringLength(50)]
        public string damages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conteneur> Conteneurs { get; set; }
    }
}
