namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewProductFields2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "SatisIzni", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "SatisIzni", c => c.Boolean(nullable: false));
        }
    }
}
