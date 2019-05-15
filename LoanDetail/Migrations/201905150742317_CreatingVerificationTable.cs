namespace LoanDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingVerificationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditBuyers",
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
            
            CreateTable(
                "dbo.CreditManagers",
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
            
            CreateTable(
                "dbo.Verifications",
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
            DropForeignKey("dbo.Verifications", "LoandetailId", "dbo.Loandetails");
            DropForeignKey("dbo.Verifications", "EmployeeDetailsId", "dbo.EmployeeDetails");
            DropForeignKey("dbo.Verifications", "Customer_Details_Id", "dbo.Customer_Details");
            DropForeignKey("dbo.CreditManagers", "LoandetailId", "dbo.Loandetails");
            DropForeignKey("dbo.CreditManagers", "EmployeeDetailsId", "dbo.EmployeeDetails");
            DropForeignKey("dbo.CreditManagers", "Customer_Details_Id", "dbo.Customer_Details");
            DropForeignKey("dbo.CreditBuyers", "LoandetailId", "dbo.Loandetails");
            DropForeignKey("dbo.CreditBuyers", "EmployeeDetailsId", "dbo.EmployeeDetails");
            DropForeignKey("dbo.CreditBuyers", "Customer_Details_Id", "dbo.Customer_Details");
            DropIndex("dbo.Verifications", new[] { "Customer_Details_Id" });
            DropIndex("dbo.Verifications", new[] { "LoandetailId" });
            DropIndex("dbo.Verifications", new[] { "EmployeeDetailsId" });
            DropIndex("dbo.CreditManagers", new[] { "Customer_Details_Id" });
            DropIndex("dbo.CreditManagers", new[] { "LoandetailId" });
            DropIndex("dbo.CreditManagers", new[] { "EmployeeDetailsId" });
            DropIndex("dbo.CreditBuyers", new[] { "Customer_Details_Id" });
            DropIndex("dbo.CreditBuyers", new[] { "LoandetailId" });
            DropIndex("dbo.CreditBuyers", new[] { "EmployeeDetailsId" });
            DropTable("dbo.Verifications");
            DropTable("dbo.CreditManagers");
            DropTable("dbo.CreditBuyers");
        }
    }
}
