namespace LoanDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingCustomerIdForeignKeyForLoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer_Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        sFirst_Name = c.String(nullable: false),
                        sLast_Name = c.String(),
                        iMobile_Number = c.String(nullable: false),
                        sEmail_ID = c.String(nullable: false),
                        sPassword = c.String(nullable: false, maxLength: 10),
                        sCity = c.String(nullable: false),
                        sAddress = c.String(),
                        sOccupation = c.String(nullable: false),
                        sGender = c.String(),
                        sUpi_Id = c.String(nullable: false),
                        iAccount_Number = c.Int(nullable: false),
                        iInitial_Deposite_Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocumentsUploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentityProof = c.String(nullable: false),
                        AddressProof = c.String(nullable: false),
                        Statements = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Loandetails", "dApplied_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Loandetails", "Customer_DetailsId", c => c.Int(nullable: false));
            AlterColumn("dbo.Loandetails", "loan_Type", c => c.String(nullable: false));
            AlterColumn("dbo.Loandetails", "sPayment_Type", c => c.String(nullable: false));
            CreateIndex("dbo.Loandetails", "Customer_DetailsId");
            AddForeignKey("dbo.Loandetails", "Customer_DetailsId", "dbo.Customer_Details", "Id", cascadeDelete: true);
            DropColumn("dbo.Loandetails", "dStart_Date");
            DropColumn("dbo.Loandetails", "dEnd_Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Loandetails", "dEnd_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Loandetails", "dStart_Date", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Loandetails", "Customer_DetailsId", "dbo.Customer_Details");
            DropIndex("dbo.Loandetails", new[] { "Customer_DetailsId" });
            AlterColumn("dbo.Loandetails", "sPayment_Type", c => c.String());
            AlterColumn("dbo.Loandetails", "loan_Type", c => c.String());
            DropColumn("dbo.Loandetails", "Customer_DetailsId");
            DropColumn("dbo.Loandetails", "dApplied_Date");
            DropTable("dbo.DocumentsUploads");
            DropTable("dbo.Customer_Details");
        }
    }
}
