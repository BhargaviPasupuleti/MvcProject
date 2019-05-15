namespace LoanDetail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLoanDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loandetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        loan_Type = c.String(),
                        dIntrest = c.Double(nullable: false),
                        dAmount = c.Double(nullable: false),
                        sPayment_Type = c.String(),
                        dStart_Date = c.DateTime(nullable: false),
                        dEnd_Date = c.DateTime(nullable: false),
                        dDue_Date = c.DateTime(nullable: false),
                        sDocument_Type = c.String(),
                        sStatus = c.String(),
                        iDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Loandetails");
        }
    }
}
