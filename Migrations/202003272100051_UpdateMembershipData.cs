namespace MovieStoreNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'None' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Silver' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Gold' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Platinum' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
