namespace MvcPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddvaluetoNamePropertyofMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MemberShipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
