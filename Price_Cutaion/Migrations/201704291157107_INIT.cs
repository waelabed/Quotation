namespace Price_Cutaion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INIT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesProducts", "QuotationId_pricecutaionId", c => c.Int());
            AddColumn("dbo.Terms", "QuotationId_pricecutaionId", c => c.Int());
            CreateIndex("dbo.SalesProducts", "QuotationId_pricecutaionId");
            CreateIndex("dbo.Terms", "QuotationId_pricecutaionId");
            AddForeignKey("dbo.SalesProducts", "QuotationId_pricecutaionId", "dbo.Quotations", "pricecutaionId");
            AddForeignKey("dbo.Terms", "QuotationId_pricecutaionId", "dbo.Quotations", "pricecutaionId");
            DropColumn("dbo.SalesProducts", "QuotationId");
            DropColumn("dbo.Terms", "QuotationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Terms", "QuotationId", c => c.String());
            AddColumn("dbo.SalesProducts", "QuotationId", c => c.String());
            DropForeignKey("dbo.Terms", "QuotationId_pricecutaionId", "dbo.Quotations");
            DropForeignKey("dbo.SalesProducts", "QuotationId_pricecutaionId", "dbo.Quotations");
            DropIndex("dbo.Terms", new[] { "QuotationId_pricecutaionId" });
            DropIndex("dbo.SalesProducts", new[] { "QuotationId_pricecutaionId" });
            DropColumn("dbo.Terms", "QuotationId_pricecutaionId");
            DropColumn("dbo.SalesProducts", "QuotationId_pricecutaionId");
        }
    }
}
