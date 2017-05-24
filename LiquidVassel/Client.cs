namespace LiquidVassel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VLS.Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Conteneurs = new HashSet<Conteneur>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClient { get; set; }

        [Required]
        [StringLength(10)]
        public string nomClient { get; set; }

        [Required]
        [StringLength(50)]
        public string adressClient { get; set; }

        [Required]
        [StringLength(6)]
        public string LoginClient { get; set; }

        [Required]
        [StringLength(40)]
        public string motdePasseClient { get; set; }

        [Required]
        [StringLength(25)]
        public string codeVille { get; set; }

        public virtual Ville Ville { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conteneur> Conteneurs { get; set; }
    }
}
