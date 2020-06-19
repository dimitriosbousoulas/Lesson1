namespace Relationships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneToOneRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardId = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CardId)
                .ForeignKey("dbo.Employees", t => t.CardId)
                .Index(t => t.CardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cards", "CardId", "dbo.Employees");
            DropIndex("dbo.Cards", new[] { "CardId" });
            DropTable("dbo.Cards");
        }
    }
}
