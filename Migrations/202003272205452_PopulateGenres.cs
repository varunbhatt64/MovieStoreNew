namespace MovieStoreNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) Values(1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) Values(2, 'Thriller')");
            Sql("INSERT INTO Genres(Id, Name) Values(3, 'Suspense')");
            Sql("INSERT INTO Genres(Id, Name) Values(4, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
