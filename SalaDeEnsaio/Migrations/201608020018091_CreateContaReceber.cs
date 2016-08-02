namespace SalaDeEnsaio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContaReceber : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContaRecebers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Recebido = c.Boolean(nullable: false),
                        PessoaId = c.Long(nullable: false),
                        Vencimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContaRecebers", "PessoaId", "dbo.Pessoas");
            DropIndex("dbo.ContaRecebers", new[] { "PessoaId" });
            DropTable("dbo.ContaRecebers");
        }
    }
}
