namespace LiquidVassel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VesselModel : DbContext
    {
        public VesselModel()
            : base("name=VesselModel")
        {
        }

        public virtual DbSet<AnomalieB> AnomalieBs { get; set; }
        public virtual DbSet<Armateur> Armateurs { get; set; }
        public virtual DbSet<Bateau> Bateaux { get; set; }
        public virtual DbSet<Capitaine> Capitaines { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<codePort> codePorts { get; set; }
        public virtual DbSet<Conteneur> Conteneurs { get; set; }
        public virtual DbSet<distanceheure> distanceheures { get; set; }
        public virtual DbSet<Etat_tc> Etat_tc { get; set; }
        public virtual DbSet<pay> pays { get; set; }
        public virtual DbSet<peut_subir> peut_subir { get; set; }
        public virtual DbSet<Rotation> Rotations { get; set; }
        public virtual DbSet<sequence> sequences { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<transvase> transvases { get; set; }
        public virtual DbSet<Type_Iso> Type_Iso { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnomalieB>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<AnomalieB>()
                .HasMany(e => e.peut_subir)
                .WithRequired(e => e.AnomalieB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Armateur>()
                .Property(e => e.Idarma)
                .IsUnicode(false);

            modelBuilder.Entity<Armateur>()
                .Property(e => e.NomArma)
                .IsUnicode(false);

            modelBuilder.Entity<Armateur>()
                .Property(e => e.LoginArma)
                .IsUnicode(false);

            modelBuilder.Entity<Armateur>()
                .Property(e => e.Motdepassearma)
                .IsUnicode(false);

            modelBuilder.Entity<Armateur>()
                .HasMany(e => e.Bateaux)
                .WithRequired(e => e.Armateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.IDmat)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.nameVsl)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.IDcapitaine)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.cat)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.Idarma)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .Property(e => e.IdRota)
                .IsUnicode(false);

            modelBuilder.Entity<Bateau>()
                .HasMany(e => e.peut_subir)
                .WithRequired(e => e.Bateau)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bateau>()
                .HasMany(e => e.transvases)
                .WithRequired(e => e.Bateau)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Capitaine>()
                .Property(e => e.IDcapitaine)
                .IsUnicode(false);

            modelBuilder.Entity<Capitaine>()
                .Property(e => e.NomCapt)
                .IsUnicode(false);

            modelBuilder.Entity<Capitaine>()
                .Property(e => e.PrenomCapt)
                .IsUnicode(false);

            modelBuilder.Entity<Capitaine>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<Capitaine>()
                .HasMany(e => e.Bateaux)
                .WithRequired(e => e.Capitaine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categorie>()
                .Property(e => e.cat)
                .IsUnicode(false);

            modelBuilder.Entity<Categorie>()
                .Property(e => e.NomCat)
                .IsUnicode(false);

            modelBuilder.Entity<Categorie>()
                .HasMany(e => e.Bateaux)
                .WithRequired(e => e.Categorie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categorie>()
                .HasMany(e => e.Capitaines)
                .WithMany(e => e.Categories)
                .Map(m => m.ToTable("est_habilite", "VLS").MapLeftKey("cat").MapRightKey("IDcapitaine"));

            modelBuilder.Entity<Client>()
                .Property(e => e.nomClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.adressClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LoginClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.motdePasseClient)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.codeVille)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Conteneurs)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<codePort>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<codePort>()
                .Property(e => e.codeVille)
                .IsUnicode(false);

            modelBuilder.Entity<codePort>()
                .Property(e => e.codeVille_1)
                .IsUnicode(false);

            modelBuilder.Entity<codePort>()
                .Property(e => e.codePort1)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .Property(e => e.IdTc)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .Property(e => e.iso)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .Property(e => e.classDgtx)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .Property(e => e.numDouane)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .Property(e => e.iso_Type_Iso)
                .IsUnicode(false);

            modelBuilder.Entity<Conteneur>()
                .HasMany(e => e.transvases)
                .WithRequired(e => e.Conteneur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<distanceheure>()
                .Property(e => e.codePortDep)
                .IsUnicode(false);

            modelBuilder.Entity<distanceheure>()
                .Property(e => e.codePortArr)
                .IsUnicode(false);

            modelBuilder.Entity<Etat_tc>()
                .Property(e => e.IdDamage)
                .IsUnicode(false);

            modelBuilder.Entity<Etat_tc>()
                .Property(e => e.damages)
                .IsUnicode(false);

            modelBuilder.Entity<Etat_tc>()
                .HasMany(e => e.Conteneurs)
                .WithMany(e => e.Etat_tc)
                .Map(m => m.ToTable("est_en", "VLS").MapLeftKey("IdDamage").MapRightKey("IdTc"));

            modelBuilder.Entity<pay>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<pay>()
                .Property(e => e.nomPays)
                .IsUnicode(false);

            modelBuilder.Entity<pay>()
                .HasMany(e => e.Bateaux)
                .WithRequired(e => e.pay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pay>()
                .HasMany(e => e.Capitaines)
                .WithRequired(e => e.pay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pay>()
                .HasMany(e => e.Terminals)
                .WithRequired(e => e.pay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pay>()
                .HasMany(e => e.Villes)
                .WithRequired(e => e.pay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<peut_subir>()
                .Property(e => e.IDmat)
                .IsUnicode(false);

            modelBuilder.Entity<peut_subir>()
                .Property(e => e.codePort)
                .IsUnicode(false);

            modelBuilder.Entity<Rotation>()
                .Property(e => e.IdRota)
                .IsUnicode(false);

            modelBuilder.Entity<Rotation>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Rotation>()
                .HasMany(e => e.sequences)
                .WithRequired(e => e.Rotation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sequence>()
                .Property(e => e.IdRota)
                .IsUnicode(false);

            modelBuilder.Entity<sequence>()
                .Property(e => e.codePortDep)
                .IsUnicode(false);

            modelBuilder.Entity<sequence>()
                .Property(e => e.codePortArr)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.codePort)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.nomPort)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.codePorts)
                .WithRequired(e => e.Terminal)
                .HasForeignKey(e => e.codePort1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.distanceheures)
                .WithRequired(e => e.Terminal)
                .HasForeignKey(e => e.codePortArr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.distanceheures1)
                .WithRequired(e => e.Terminal1)
                .HasForeignKey(e => e.codePortDep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.peut_subir)
                .WithRequired(e => e.Terminal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.sequences)
                .WithRequired(e => e.Terminal)
                .HasForeignKey(e => e.codePortArr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.sequences1)
                .WithRequired(e => e.Terminal1)
                .HasForeignKey(e => e.codePortDep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terminal>()
                .HasMany(e => e.transvases)
                .WithRequired(e => e.Terminal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transvase>()
                .Property(e => e.IDmat)
                .IsUnicode(false);

            modelBuilder.Entity<transvase>()
                .Property(e => e.IdTc)
                .IsUnicode(false);

            modelBuilder.Entity<transvase>()
                .Property(e => e.codePort)
                .IsUnicode(false);

            modelBuilder.Entity<Type_Iso>()
                .Property(e => e.iso)
                .IsUnicode(false);

            modelBuilder.Entity<Type_Iso>()
                .HasMany(e => e.Conteneurs)
                .WithRequired(e => e.Type_Iso)
                .HasForeignKey(e => e.iso_Type_Iso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ville>()
                .Property(e => e.codeVille)
                .IsUnicode(false);

            modelBuilder.Entity<Ville>()
                .Property(e => e.NomVille)
                .IsUnicode(false);

            modelBuilder.Entity<Ville>()
                .Property(e => e.IdPays)
                .IsUnicode(false);

            modelBuilder.Entity<Ville>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Ville)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ville>()
                .HasMany(e => e.codePorts)
                .WithRequired(e => e.Ville)
                .HasForeignKey(e => e.codeVille_1)
                .WillCascadeOnDelete(false);
        }
    }
}
