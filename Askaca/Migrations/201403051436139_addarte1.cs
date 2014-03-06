namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarte1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alunoes", "Arte_ID", "dbo.Artes");
            DropIndex("dbo.Alunoes", new[] { "Arte_ID" });
            DropColumn("dbo.Alunoes", "Arte_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alunoes", "Arte_ID", c => c.Int());
            CreateIndex("dbo.Alunoes", "Arte_ID");
            AddForeignKey("dbo.Alunoes", "Arte_ID", "dbo.Artes", "ID");
        }
    }
}
