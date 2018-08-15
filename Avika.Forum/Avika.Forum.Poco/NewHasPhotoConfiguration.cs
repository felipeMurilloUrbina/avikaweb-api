// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Avika.Forum.Model
{
    using Avika.Forum.Model;

    // NewHasPhotos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class NewHasPhotoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<NewHasPhoto>
    {
        public NewHasPhotoConfiguration()
            : this("dbo")
        {
        }

        public NewHasPhotoConfiguration(string schema)
        {
            ToTable("NewHasPhotos", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NewId).HasColumnName(@"NewId").HasColumnType("int").IsRequired();
            Property(x => x.NameHistoric).HasColumnName(@"NameHistoric").HasColumnType("varbinary").IsOptional().HasMaxLength(70);
            Property(x => x.Namephysical).HasColumnName(@"Namephysical").HasColumnType("varbinary").IsOptional().HasMaxLength(70);
            Property(x => x.UserCreatorId).HasColumnName(@"UserCreatorId").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.DateCreation).HasColumnName(@"DateCreation").HasColumnType("datetime").IsRequired();
            Property(x => x.Active).HasColumnName(@"Active").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.News).WithMany(b => b.NewHasPhotoes).HasForeignKey(c => c.NewId).WillCascadeOnDelete(false); // FK_NewHasPhotos_News
        }
    }

}
// </auto-generated>
