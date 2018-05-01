namespace Kidding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerViewModels", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.CustomerViewModels", "MembershipTypeId");
            AddForeignKey("dbo.CustomerViewModels", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerViewModels", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.CustomerViewModels", new[] { "MembershipTypeId" });
            DropColumn("dbo.CustomerViewModels", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
