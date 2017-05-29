namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Type_Iso")]
    public partial class Type_Iso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Type_Iso()
        {
            Conteneurs = new HashSet<Conteneur>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string iso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conteneur> Conteneurs { get; set; }
    }
}
