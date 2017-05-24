namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Terminal")]
    public partial class Terminal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terminal()
        {
            codePorts = new HashSet<codePort>();
            distanceheures = new HashSet<distanceheure>();
            distanceheures1 = new HashSet<distanceheure>();
            peut_subir = new HashSet<peut_subir>();
            sequences = new HashSet<sequence>();
            sequences1 = new HashSet<sequence>();
            transvases = new HashSet<transvase>();
        }

        [Key]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string codePort { get; set; }

        [Required]
        [StringLength(25)]
        public string nomPort { get; set; }

        public bool Berth { get; set; }

        public int nbgc { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string IdPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<codePort> codePorts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<distanceheure> distanceheures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<distanceheure> distanceheures1 { get; set; }

        public virtual pay pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peut_subir> peut_subir { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sequence> sequences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sequence> sequences1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transvase> transvases { get; set; }
    }
}
