using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace NeutecDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager pm = new ProductManager();

        [Authorize(Roles = "admin, dataEntry, dataViewer")]
        public ActionResult Index(bool showTable = false)
        {
            var values = pm.GetAll();
            ViewBag.ShowTable = showTable;
            return View(values);
        }

        [Authorize(Roles = "admin, dataEntry")]
        public ActionResult CreateProduct()
        {
            return View();
        }
            
        [HttpPost]
        [Authorize(Roles = "admin, dataEntry")]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                pm.Add(product);
                TempData["SuccessMessage2"] = "Ürün başarıyla sisteme eklendi";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [Authorize(Roles = "admin")]
        public ActionResult UpdateProduct()
        {
            return View(new Product());
        }

        [HttpGet]
        [Authorize(Roles = "admin, dataEntry, dataViewer")]
        public JsonResult GetProduct(int id, string name)
        {
            var product = pm.repoproduct.List().FirstOrDefault(x => x.ProductId == id && x.ProductName == name);

            if (product == null)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }

            return Json(new
            {
                product.ProductId,
                product.ProductName,
                product.Brand,
                product.BrandHistory,
                product.LicenseStatus,
                product.RegisterStatus,
                product.ModulTipi,
                product.EtkinMadde,
                product.Doz,
                product.FarmasotikForm,
                product.SgkDurumu,
                product.SatisIzni,
                product.TitckBirim,
                product.YaziKonusu,
                product.OnayDurumu,
                product.BakanlikYazi,
                product.BakanlikYaziTarihi,
                product.CevapSonTarih,
                product.YaziCevabi,
                product.CevaplandigiTarih,
                product.SorumluBirim,
                product.UrunSorumlusu,
                product.EksiklikBeklenenDepartman,
                product.BeklemeNedeni
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult UpdateProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                pm.UpdateProduct(p);
                TempData["SuccessMessage"] = "Ürün başarıyla güncellendi";
                return RedirectToAction("Index");
            }

            return View(p);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteProduct(int ProductId)
        {
            if (ProductId <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = pm.repoproduct.GetById(ProductId);
            if (product == null)
            {
                return HttpNotFound();
            }

            pm.DeleteProduct(product);
            TempData["SuccessMessage3"] = "Ürün başarıyla silindi";
            return RedirectToAction("Index");
        }
    }
}
