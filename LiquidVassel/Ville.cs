namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Ville")]
    public partial class Ville
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ville()
        {
            Clients = new HashSet<Client>();
            codePorts = new HashSet<codePort>();
        }

        [Key]
        [StringLength(25)]
        public string codeVille { get; set; }

        [Required]
        [StringLength(25)]
        public string NomVille { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(2)]
        public string IdPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<codePort> codePorts { get; set; }

        public virtual pay pay { get; set; }
    }
}
