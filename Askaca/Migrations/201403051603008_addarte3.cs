namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarte3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artes", "Aluno_Id", c => c.Int());
            AddColumn("dbo.Turmas", "aluno_Id", c => c.Int());
            CreateIndex("dbo.Artes", "Aluno_Id");
            CreateIndex("dbo.Turmas", "aluno_Id");
            AddForeignKey("dbo.Artes", "Aluno_Id", "dbo.Alunoes", "Id");
            AddForeignKey("dbo.Turmas", "aluno_Id", "dbo.Alunoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "aluno_Id", "dbo.Alunoes");
            DropForeignKey("dbo.Artes", "Aluno_Id", "dbo.Alunoes");
            DropIndex("dbo.Turmas", new[] { "aluno_Id" });
            DropIndex("dbo.Artes", new[] { "Aluno_Id" });
            DropColumn("dbo.Turmas", "aluno_Id");
            DropColumn("dbo.Artes", "Aluno_Id");
        }
    }
}
