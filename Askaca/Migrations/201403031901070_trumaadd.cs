namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trumaadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmas", "Inicio", c => c.String());
            AddColumn("dbo.Turmas", "fim", c => c.String());
            DropColumn("dbo.Turmas", "horario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turmas", "horario", c => c.DateTime(nullable: false));
            DropColumn("dbo.Turmas", "fim");
            DropColumn("dbo.Turmas", "Inicio");
        }
    }
}
