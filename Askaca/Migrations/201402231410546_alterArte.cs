namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterArte : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alunoes", "telefone", c => c.String());
            AddColumn("dbo.Artes", "nome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artes", "nome");
            DropColumn("dbo.Alunoes", "telefone");
        }
    }
}
