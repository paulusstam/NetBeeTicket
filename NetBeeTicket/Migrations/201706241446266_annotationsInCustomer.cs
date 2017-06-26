namespace NetBeeTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotationsInCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
