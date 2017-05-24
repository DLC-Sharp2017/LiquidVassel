namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Bateau")]
    public partial class Bateau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bateau()
        {
            peut_subir = new HashSet<peut_subir>();
            transvases = new HashSet<transvase>();
        }

        [Key]
        [StringLength(25)]
        public string IDmat { get; set; }

        [Required]
        [StringLength(25)]
        public string nameVsl { get; set; }

        public int tirEau { get; set; }

        public int longVsl { get; set; }

        public int largVsl { get; set; }

        public int totalSlots { get; set; }

        public int nbreEquipage { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(7)]
        public string IDcapitaine { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string cat { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string IdPays { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(6)]
        public string Idarma { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public string IdRota { get; set; }

        public virtual Armateur Armateur { get; set; }

        public virtual Categorie Categorie { get; set; }

        public virtual Capitaine Capitaine { get; set; }

        public virtual pay pay { get; set; }

        public virtual Rotation Rotation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peut_subir> peut_subir { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transvase> transvases { get; set; }
    }
}
