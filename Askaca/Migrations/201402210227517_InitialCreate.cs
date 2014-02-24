namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        RG = c.String(),
                        CPF = c.String(),
                        dataNascimento = c.DateTime(nullable: false),
                        dataPagamento = c.DateTime(nullable: false),
                        logradouro = c.String(),
                        arte_ID = c.Int(),
                        turma_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artes", t => t.arte_ID)
                .ForeignKey("dbo.Turmas", t => t.turma_ID)
                .Index(t => t.arte_ID)
                .Index(t => t.turma_ID);
            
            CreateTable(
                "dbo.Artes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        mensalidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        horario = c.DateTime(nullable: false),
                        professor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Professors", t => t.professor_Id)
                .Index(t => t.professor_Id);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        RG = c.String(),
                        CPF = c.String(),
                        telefone = c.String(),
                        arte_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artes", t => t.arte_ID)
                .Index(t => t.arte_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alunoes", "turma_ID", "dbo.Turmas");
            DropForeignKey("dbo.Turmas", "professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Professors", "arte_ID", "dbo.Artes");
            DropForeignKey("dbo.Alunoes", "arte_ID", "dbo.Artes");
            DropIndex("dbo.Alunoes", new[] { "turma_ID" });
            DropIndex("dbo.Turmas", new[] { "professor_Id" });
            DropIndex("dbo.Professors", new[] { "arte_ID" });
            DropIndex("dbo.Alunoes", new[] { "arte_ID" });
            DropTable("dbo.Professors");
            DropTable("dbo.Turmas");
            DropTable("dbo.Artes");
            DropTable("dbo.Alunoes");
        }
    }
}
