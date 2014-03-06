namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarte7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artes", "Turma_ID", "dbo.Turmas");
            DropIndex("dbo.Artes", new[] { "Turma_ID" });
            AddColumn("dbo.Turmas", "modalidade_ID", c => c.Int());
            CreateIndex("dbo.Turmas", "modalidade_ID");
            AddForeignKey("dbo.Turmas", "modalidade_ID", "dbo.Artes", "ID");
            DropColumn("dbo.Artes", "Turma_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artes", "Turma_ID", c => c.Int());
            DropForeignKey("dbo.Turmas", "modalidade_ID", "dbo.Artes");
            DropIndex("dbo.Turmas", new[] { "modalidade_ID" });
            DropColumn("dbo.Turmas", "modalidade_ID");
            CreateIndex("dbo.Artes", "Turma_ID");
            AddForeignKey("dbo.Artes", "Turma_ID", "dbo.Turmas", "ID");
        }
    }
}
