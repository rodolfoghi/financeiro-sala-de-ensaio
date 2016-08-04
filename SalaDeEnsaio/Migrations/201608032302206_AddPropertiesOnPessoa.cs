namespace SalaDeEnsaio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesOnPessoa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Telefone", c => c.String());
            AddColumn("dbo.Pessoas", "Celular", c => c.String());
            AddColumn("dbo.Pessoas", "Email", c => c.String());
            AddColumn("dbo.Pessoas", "Responsavel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "Responsavel");
            DropColumn("dbo.Pessoas", "Email");
            DropColumn("dbo.Pessoas", "Celular");
            DropColumn("dbo.Pessoas", "Telefone");
        }
    }
}
