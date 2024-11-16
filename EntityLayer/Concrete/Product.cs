using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        [StringLength(20)]
        public string LicenseStatus { get; set; }
        [StringLength(20)]
        public string RegisterStatus { get; set; }
        [StringLength(50)]
        public string Brand { get; set; }
        [StringLength(50)]
        public string BrandHistory { get; set; }
        public string ModulTipi { get; set; }
        public string EtkinMadde { get; set; }
        public string Doz { get; set; }
        public string FarmasotikForm { get; set; }
        public string SgkDurumu { get; set; }
        public string SatisIzni { get; set; }
        public string TitckBirim { get; set; }
        public string YaziKonusu { get; set; }
        public string OnayDurumu { get; set; }
        public string BakanlikYazi { get; set; }
        public DateTime? BakanlikYaziTarihi { get; set; }
        public DateTime? CevapSonTarih { get; set; }
        public string YaziCevabi { get; set; }
        public DateTime? CevaplandigiTarih { get; set; }
        public string SorumluBirim { get; set; }
        public string UrunSorumlusu { get; set; }
        public string EksiklikBeklenenDepartman { get; set; }
        public string BeklemeNedeni { get; set; }
    }
}
