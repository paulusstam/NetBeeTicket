namespace NetBeeTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubscriptionType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SubscriptionTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "SubscriptionType_Id", c => c.Int());
            AddColumn("dbo.SubscriptionTypes", "Duration", c => c.String());
            AddColumn("dbo.SubscriptionTypes", "Fee", c => c.Short(nullable: false));
            AddColumn("dbo.SubscriptionTypes", "DiscountRate", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "SubscriptionType_Id");
            AddForeignKey("dbo.Customers", "SubscriptionType_Id", "dbo.SubscriptionTypes", "Id");
            DropColumn("dbo.SubscriptionTypes", "TypeOfSubscription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubscriptionTypes", "TypeOfSubscription", c => c.String());
            DropForeignKey("dbo.Customers", "SubscriptionType_Id", "dbo.SubscriptionTypes");
            DropIndex("dbo.Customers", new[] { "SubscriptionType_Id" });
            DropColumn("dbo.SubscriptionTypes", "DiscountRate");
            DropColumn("dbo.SubscriptionTypes", "Fee");
            DropColumn("dbo.SubscriptionTypes", "Duration");
            DropColumn("dbo.Customers", "SubscriptionType_Id");
            DropColumn("dbo.Customers", "SubscriptionTypeId");
        }
    }
}
