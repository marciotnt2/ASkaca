namespace Askaca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmas", "dias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turmas", "dias");
        }
    }
}
