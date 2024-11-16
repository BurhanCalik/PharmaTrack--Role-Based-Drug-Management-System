namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductNewFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ModulTipi", c => c.String());
            AddColumn("dbo.Products", "EtkinMadde", c => c.String());
            AddColumn("dbo.Products", "Doz", c => c.String());
            AddColumn("dbo.Products", "FarmasotikForm", c => c.String());
            AddColumn("dbo.Products", "SgkDurumu", c => c.String());
            AddColumn("dbo.Products", "SatisIzni", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "TitckBirim", c => c.String());
            AddColumn("dbo.Products", "YaziKonusu", c => c.String());
            AddColumn("dbo.Products", "OnayDurumu", c => c.String());
            AddColumn("dbo.Products", "BakanlikYazi", c => c.String());
            AddColumn("dbo.Products", "BakanlikYaziTarihi", c => c.DateTime());
            AddColumn("dbo.Products", "CevapSonTarih", c => c.DateTime());
            AddColumn("dbo.Products", "YaziCevabi", c => c.String());
            AddColumn("dbo.Products", "CevaplandigiTarih", c => c.DateTime());
            AddColumn("dbo.Products", "SorumluBirim", c => c.String());
            AddColumn("dbo.Products", "UrunSorumlusu", c => c.String());
            AddColumn("dbo.Products", "EksiklikBeklenenDepartman", c => c.String());
            AddColumn("dbo.Products", "BeklemeNedeni", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BeklemeNedeni");
            DropColumn("dbo.Products", "EksiklikBeklenenDepartman");
            DropColumn("dbo.Products", "UrunSorumlusu");
            DropColumn("dbo.Products", "SorumluBirim");
            DropColumn("dbo.Products", "CevaplandigiTarih");
            DropColumn("dbo.Products", "YaziCevabi");
            DropColumn("dbo.Products", "CevapSonTarih");
            DropColumn("dbo.Products", "BakanlikYaziTarihi");
            DropColumn("dbo.Products", "BakanlikYazi");
            DropColumn("dbo.Products", "OnayDurumu");
            DropColumn("dbo.Products", "YaziKonusu");
            DropColumn("dbo.Products", "TitckBirim");
            DropColumn("dbo.Products", "SatisIzni");
            DropColumn("dbo.Products", "SgkDurumu");
            DropColumn("dbo.Products", "FarmasotikForm");
            DropColumn("dbo.Products", "Doz");
            DropColumn("dbo.Products", "EtkinMadde");
            DropColumn("dbo.Products", "ModulTipi");
        }
    }
}
