namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCancelledToGig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "IsCancel", c => c.Boolean(nullable: false));
            DropColumn("dbo.Gigs", "IsCancer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "IsCancer", c => c.Boolean(nullable: false));
            DropColumn("dbo.Gigs", "IsCancel");
        }
    }
}
