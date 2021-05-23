namespace Songs_of_groups_example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Groups", "Year", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Groups", "Year", c => c.Int(nullable: false));
        }
    }
}
