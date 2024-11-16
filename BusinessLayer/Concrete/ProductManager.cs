using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        public Repository<Product> repoproduct = new Repository<Product>();

        public List<Product> GetAll()
        {
            return repoproduct.List();
        }
        public void Add(Product product)
        {
            repoproduct.Insert(product);
        }
        public void UpdateProduct(Product p)
        {

            var product = repoproduct.GetById(p.ProductId);
            if (product != null)
            {
                product.ProductName = p.ProductName;
                product.LicenseStatus = p.LicenseStatus;
                product.RegisterStatus = p.RegisterStatus;
                product.Brand = p.Brand;
                product.BrandHistory = p.BrandHistory;
                product.ModulTipi = p.ModulTipi;
                product.EtkinMadde = p.EtkinMadde;
                product.Doz = p.Doz;
                product.FarmasotikForm = p.FarmasotikForm;
                product.SgkDurumu = p.SgkDurumu;
                product.SatisIzni = p.SatisIzni;
                product.TitckBirim = p.TitckBirim;
                product.YaziKonusu = p.YaziKonusu;
                product.OnayDurumu = p.OnayDurumu;
                product.BakanlikYazi = p.BakanlikYazi;
                product.BakanlikYaziTarihi = p.BakanlikYaziTarihi;
                product.CevapSonTarih = p.CevapSonTarih;
                product.YaziCevabi = p.YaziCevabi;
                product.CevaplandigiTarih = p.CevaplandigiTarih;
                product.SorumluBirim = p.SorumluBirim;
                product.UrunSorumlusu = p.UrunSorumlusu;
                product.EksiklikBeklenenDepartman = p.EksiklikBeklenenDepartman;
                product.BeklemeNedeni = p.BeklemeNedeni;
                repoproduct.Update(product);
            }
        }
        public void DeleteProduct(Product product)
        {
            repoproduct.Delete(product);
        }

    }
}
