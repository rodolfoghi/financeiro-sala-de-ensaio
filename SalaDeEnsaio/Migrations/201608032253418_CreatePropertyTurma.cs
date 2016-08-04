namespace SalaDeEnsaio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePropertyTurma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContaRecebers", "Turma", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContaRecebers", "Turma");
        }
    }
}
