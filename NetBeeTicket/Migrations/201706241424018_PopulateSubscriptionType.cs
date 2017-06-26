namespace NetBeeTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubscriptionType : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT SubscriptionTypes ON");
            Sql("INSERT INTO SubscriptionTypes (Id, Duration, Fee, DiscountRate) VALUES (1, 1, 20, 0)");
            Sql("INSERT INTO SubscriptionTypes (Id, Duration, Fee, DiscountRate) VALUES (2, 3, 50, 20)");
            Sql("INSERT INTO SubscriptionTypes (Id, Duration, Fee, DiscountRate) VALUES (3, 6, 100, 20)");
            Sql("INSERT INTO SubscriptionTypes (Id, Duration, Fee, DiscountRate) VALUES (4, 12, 200, 20)");
            Sql("SET IDENTITY_INSERT SubscriptionTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
