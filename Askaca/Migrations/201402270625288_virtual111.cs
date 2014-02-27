namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class virtual111 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alunoes", "arte_ID", "dbo.Artes");
            DropForeignKey("dbo.Alunoes", "turma_ID", "dbo.Turmas");
            DropIndex("dbo.Alunoes", new[] { "arte_ID" });
            DropIndex("dbo.Alunoes", new[] { "turma_ID" });
            AddColumn("dbo.Alunoes", "arte_id_ID", c => c.Int());
            AddColumn("dbo.Alunoes", "turma_id_ID", c => c.Int());
            CreateIndex("dbo.Alunoes", "arte_id_ID");
            CreateIndex("dbo.Alunoes", "turma_id_ID");
            AddForeignKey("dbo.Alunoes", "arte_id_ID", "dbo.Artes", "ID");
            AddForeignKey("dbo.Alunoes", "turma_id_ID", "dbo.Turmas", "ID");
            DropColumn("dbo.Alunoes", "arte_ID");
            DropColumn("dbo.Alunoes", "turma_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alunoes", "turma_ID", c => c.Int());
            AddColumn("dbo.Alunoes", "arte_ID", c => c.Int());
            DropForeignKey("dbo.Alunoes", "turma_id_ID", "dbo.Turmas");
            DropForeignKey("dbo.Alunoes", "arte_id_ID", "dbo.Artes");
            DropIndex("dbo.Alunoes", new[] { "turma_id_ID" });
            DropIndex("dbo.Alunoes", new[] { "arte_id_ID" });
            DropColumn("dbo.Alunoes", "turma_id_ID");
            DropColumn("dbo.Alunoes", "arte_id_ID");
            CreateIndex("dbo.Alunoes", "turma_ID");
            CreateIndex("dbo.Alunoes", "arte_ID");
            AddForeignKey("dbo.Alunoes", "turma_ID", "dbo.Turmas", "ID");
            AddForeignKey("dbo.Alunoes", "arte_ID", "dbo.Artes", "ID");
        }
    }
}
