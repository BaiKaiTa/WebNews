namespace DVCP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Games", c => c.String(maxLength: 50));
            DropColumn("dbo.Posts", "dynasty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "dynasty", c => c.String(maxLength: 50));
            DropColumn("dbo.Posts", "Games");
        }
    }
}
