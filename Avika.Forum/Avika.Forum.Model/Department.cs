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

    // Departments
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class Department: IObject
    {
        public int Id { get; set; } // Id (Primary key)
        public string Description { get; set; } // Description (length: 300)
        public string UserCreatorId { get; set; } // UserCreatorId (length: 128)
        public System.DateTime DateCreation { get; set; } // DateCreation
        public bool Active { get; set; } // Active
    }

}
// </auto-generated>
