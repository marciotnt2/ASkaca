namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraçãoemturma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmas", "modalidade_ID", c => c.Int());
            CreateIndex("dbo.Turmas", "modalidade_ID");
            AddForeignKey("dbo.Turmas", "modalidade_ID", "dbo.Artes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "modalidade_ID", "dbo.Artes");
            DropIndex("dbo.Turmas", new[] { "modalidade_ID" });
            DropColumn("dbo.Turmas", "modalidade_ID");
        }
    }
}
