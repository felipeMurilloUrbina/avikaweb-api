namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitaCamposUsuario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CompanyId");
            DropColumn("dbo.AspNetUsers", "DepartmentId");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "IncorporationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IncorporationDate", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DepartmentId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "CompanyId", c => c.Int());
        }
    }
}
