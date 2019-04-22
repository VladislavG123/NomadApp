namespace NomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoney : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Publishers", "Money", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Publishers", "Money");
        }
    }
}
