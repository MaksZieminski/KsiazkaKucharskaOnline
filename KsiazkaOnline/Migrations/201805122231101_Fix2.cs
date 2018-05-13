namespace KsiazkaOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Email");
        }
    }
}
