namespace TimeOrganizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false, maxLength: 23));
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String(maxLength: 120));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false, maxLength: 17));
        }
    }
}
