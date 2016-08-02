namespace SalaDeEnsaio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Nascimento = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
