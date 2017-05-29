namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Rotation")]
    public partial class Rotation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rotation()
        {
            Bateaux = new HashSet<Bateau>();
            sequences = new HashSet<sequence>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string IdRota { get; set; }

        [StringLength(25)]
        public string nom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bateau> Bateaux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sequence> sequences { get; set; }
    }
}
