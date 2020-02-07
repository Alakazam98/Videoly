namespace Videoly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO MOVIES(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Hangover', 5, 2012, 2010, 15)");
            Sql("INSERT INTO MOVIES(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'Interstellar', 2, 2012, 2010, 15)");
            Sql("INSERT INTO MOVIES(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (3, 'The fault in our stars', 1, 2012, 2010, 15)");
            Sql("INSERT INTO MOVIES(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (4, 'The Lord Of The Rings', 3, 2012, 2010, 15)");
            Sql("INSERT INTO MOVIES(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (5, 'Shallow', 4, 2012, 2010, 15)");
            Sql("SET IDENTITY_INSERT Movies OFF");

        }

        public override void Down()
        {
        }
    }
}
