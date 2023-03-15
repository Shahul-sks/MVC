namespace MVCassignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableMovieCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        mid = c.Int(nullable: false, identity: true),
                        Moviename = c.String(),
                        dateofrelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
