namespace NomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        FullName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        BankCard = c.String(),
                        AmountSubscribesMonths = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DepatureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(),
                        Client_Id = c.Guid(),
                        Magazine_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Magazines", t => t.Magazine_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Magazine_Id);
            
            CreateTable(
                "dbo.Magazines",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Content = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Publisher_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .Index(t => t.Publisher_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Magazine_Id", "dbo.Magazines");
            DropForeignKey("dbo.Magazines", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Magazines", new[] { "Publisher_Id" });
            DropIndex("dbo.Orders", new[] { "Magazine_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropTable("dbo.Publishers");
            DropTable("dbo.Magazines");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
        }
    }
}
