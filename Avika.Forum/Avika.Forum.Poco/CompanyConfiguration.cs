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

    // Companies
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class CompanyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
            : this("dbo")
        {
        }

        public CompanyConfiguration(string schema)
        {
            ToTable("Companies", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserCreatorId).HasColumnName(@"UserCreatorId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.UserModificatorId).HasColumnName(@"UserModificatorId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(300);
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Active).HasColumnName(@"Active").HasColumnType("bit").IsRequired();
            Property(x => x.DateCreation).HasColumnName(@"DateCreation").HasColumnType("datetime").IsRequired();
            HasMany(t => t.News).WithMany(t => t.Companies).Map(m =>
            {
                m.ToTable("NewCompanies", "dbo");
                m.MapLeftKey("CompanyId");
                m.MapRightKey("NewId");
            });
        }
    }

}
// </auto-generated>
