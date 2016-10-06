namespace PeopleSearchAtHealthCatalyst.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime(nullable: false, precision: 0, storeType: "datetime2"));
            AlterColumn("dbo.People", "ModifiedDate", c => c.DateTime(nullable: false, precision: 0, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
