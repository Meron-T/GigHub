namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCancelledToGig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "IsCancer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "IsCancer");
        }
    }
}
