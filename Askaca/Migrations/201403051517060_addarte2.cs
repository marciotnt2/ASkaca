namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarte2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alunoes", "Turma_ID", "dbo.Turmas");
            DropIndex("dbo.Alunoes", new[] { "Turma_ID" });
            DropColumn("dbo.Alunoes", "Turma_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alunoes", "Turma_ID", c => c.Int());
            CreateIndex("dbo.Alunoes", "Turma_ID");
            AddForeignKey("dbo.Alunoes", "Turma_ID", "dbo.Turmas", "ID");
        }
    }
}
