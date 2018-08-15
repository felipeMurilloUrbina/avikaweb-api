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

    // Categories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public partial class Category
    {
        public int Id { get; set; } // Id (Primary key)
        public int PatherId { get; set; } // PatherId
        public string Description { get; set; } // Description (length: 50)
        public string UserCreatorId { get; set; } // UserCreatorId (length: 128)
        public string UserModificatorId { get; set; } // UserModificatorId (length: 128)
        public System.DateTime DateCreation { get; set; } // DateCreation
        public bool Active { get; set; } // Active

        // Reverse navigation

        /// <summary>
        /// Child News where [News].[CategoryId] point to this entity (FK_News_Categories)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<News> News { get; set; } // News.FK_News_Categories

        public Category()
        {
            News = new System.Collections.Generic.List<News>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
