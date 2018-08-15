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

    // Employees
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public partial class Employee
    {
        public int Id { get; set; } // Id (Primary key)
        public string AspNetUserId { get; set; } // AspNetUserId (length: 128)
        public int? DepartmentId { get; set; } // DepartmentId
        public int? CompanyId { get; set; } // CompanyId
        public string UserCreatorId { get; set; } // UserCreatorId (length: 128)
        public string UserModificatorId { get; set; } // UserModificatorId (length: 128)
        public string Name { get; set; } // Name (length: 200)
        public string LastName { get; set; } // LastName (length: 200)
        public string MotherLastName { get; set; } // MotherLastName (length: 200)
        public string Rfc { get; set; } // RFC (length: 15)
        public string Curp { get; set; } // CURP (length: 50)
        public string Imss { get; set; } // IMSS (length: 50)
        public string Email { get; set; } // Email (length: 100)
        public string Job { get; set; } // Job (length: 150)
        public System.DateTime StartWorkDate { get; set; } // StartWorkDate
        public System.DateTime? BirthDate { get; set; } // BirthDate
        public decimal Gauge { get; set; } // Gauge
        public System.DateTime DateCreation { get; set; } // DateCreation
        public bool Active { get; set; } // Active

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [Employees].([AspNetUserId]) (FK_Employees_AspNetUsers)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_Employees_AspNetUsers

        /// <summary>
        /// Parent Company pointed by [Employees].([CompanyId]) (FK_Employees_Companies)
        /// </summary>
        public virtual Company Company { get; set; } // FK_Employees_Companies

        /// <summary>
        /// Parent Department pointed by [Employees].([DepartmentId]) (FK_Employees_Departments)
        /// </summary>
        public virtual Department Department { get; set; } // FK_Employees_Departments

        public Employee()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
