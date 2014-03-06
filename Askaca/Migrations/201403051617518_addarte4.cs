namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarte4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artes", "Aluno_Id", "dbo.Alunoes");
            DropForeignKey("dbo.Turmas", "aluno_Id", "dbo.Alunoes");
            DropIndex("dbo.Artes", new[] { "Aluno_Id" });
            DropIndex("dbo.Turmas", new[] { "aluno_Id" });
            AddColumn("dbo.Alunoes", "Arte_ID", c => c.Int());
            AddColumn("dbo.Alunoes", "Turma_ID", c => c.Int());
            CreateIndex("dbo.Alunoes", "Arte_ID");
            CreateIndex("dbo.Alunoes", "Turma_ID");
            AddForeignKey("dbo.Alunoes", "Arte_ID", "dbo.Artes", "ID");
            AddForeignKey("dbo.Alunoes", "Turma_ID", "dbo.Turmas", "ID");
            DropColumn("dbo.Artes", "Aluno_Id");
            DropColumn("dbo.Turmas", "aluno_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turmas", "aluno_Id", c => c.Int());
            AddColumn("dbo.Artes", "Aluno_Id", c => c.Int());
            DropForeignKey("dbo.Alunoes", "Turma_ID", "dbo.Turmas");
            DropForeignKey("dbo.Alunoes", "Arte_ID", "dbo.Artes");
            DropIndex("dbo.Alunoes", new[] { "Turma_ID" });
            DropIndex("dbo.Alunoes", new[] { "Arte_ID" });
            DropColumn("dbo.Alunoes", "Turma_ID");
            DropColumn("dbo.Alunoes", "Arte_ID");
            CreateIndex("dbo.Turmas", "aluno_Id");
            CreateIndex("dbo.Artes", "Aluno_Id");
            AddForeignKey("dbo.Turmas", "aluno_Id", "dbo.Alunoes", "Id");
            AddForeignKey("dbo.Artes", "Aluno_Id", "dbo.Alunoes", "Id");
        }
    }
}
