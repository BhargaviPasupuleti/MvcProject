namespace LoanDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingEmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sEmployeeName = c.String(),
                        sPassword = c.String(),
                        sDesignation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RiskContentUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sStatus = c.String(),
                        EmployeeDetailsId = c.Int(nullable: false),
                        LoandetailId = c.Int(nullable: false),
                        CustomerDetailsId = c.Int(nullable: false),
                        Customer_Details_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer_Details", t => t.Customer_Details_Id)
                .ForeignKey("dbo.EmployeeDetails", t => t.EmployeeDetailsId, cascadeDelete: true)
                .ForeignKey("dbo.Loandetails", t => t.LoandetailId, cascadeDelete: true)
                .Index(t => t.EmployeeDetailsId)
                .Index(t => t.LoandetailId)
                .Index(t => t.Customer_Details_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RiskContentUnits", "LoandetailId", "dbo.Loandetails");
            DropForeignKey("dbo.RiskContentUnits", "EmployeeDetailsId", "dbo.EmployeeDetails");
            DropForeignKey("dbo.RiskContentUnits", "Customer_Details_Id", "dbo.Customer_Details");
            DropIndex("dbo.RiskContentUnits", new[] { "Customer_Details_Id" });
            DropIndex("dbo.RiskContentUnits", new[] { "LoandetailId" });
            DropIndex("dbo.RiskContentUnits", new[] { "EmployeeDetailsId" });
            DropTable("dbo.RiskContentUnits");
            DropTable("dbo.EmployeeDetails");
        }
    }
}
