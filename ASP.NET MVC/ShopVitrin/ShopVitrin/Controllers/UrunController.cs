using Microsoft.AspNetCore.Mvc;
using ShopVitrin.Models;

namespace ShopVitrin.Controllers
{
    public class UrunController : Controller
    {
        public static UrunContext _db = new UrunContext();

        public IActionResult Index()
        {

            List<Urun> urunler = _db.Urunler.ToList();
            return View(urunler);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            List<Urun> urunler = _db.Urunler.ToList();
            var eklenecekUrun = urunler.FirstOrDefault(u => u.UrunId == id);
            if (eklenecekUrun != null)
            {
                Urun urun = new()
                {
                    Isim = eklenecekUrun.Isim,
                    Resim = eklenecekUrun.Resim,
                    Aciklama = eklenecekUrun.Aciklama
                };
                _db.Urunler.Add(urun);
                _db.SaveChanges();
            }
            return View("Index", _db.Urunler.ToList());
        }

        [HttpGet]
        public IActionResult UrunGuncelle(int id)
        {
            List<Urun> urunler = _db.Urunler.ToList();
            var guncellenecekUrun = urunler.FirstOrDefault(u => u.UrunId == id);
            return View(guncellenecekUrun);
        }

        [HttpPost]
        public IActionResult UrunGuncelle(int id, string isim, string aciklama, IFormFile resim)
        {
            List<Urun> urunler = _db.Urunler.ToList();
            var guncellenecekUrun = urunler.FirstOrDefault(u => u.UrunId == id);
            guncellenecekUrun.Isim = isim ?? guncellenecekUrun.Isim;
            guncellenecekUrun.Aciklama = aciklama ?? guncellenecekUrun.Aciklama;
            if (resim != null && resim.Length > 0)
            {
                var dosyaYolu = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Picture", resim.FileName);

                using (var dosyaStream = new FileStream(dosyaYolu, FileMode.Create))
                {
                    resim.CopyTo(dosyaStream);
                }

                guncellenecekUrun.Resim = "/Picture/" + resim.FileName;
            }
            _db.SaveChanges();
            // Kayıt işlemi tamamlandıktan sonra, ilgili bir sonraki sayfaya yönlendirilebilirsiniz.
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UrunEkle(int id)
        {
            List<Urun> urunler = _db.Urunler.ToList();
            var eklenecekUrun = urunler.FirstOrDefault(u => u.UrunId == id);
            if (eklenecekUrun != null)
            {
                Urun urun = new()
                {
                    Isim = eklenecekUrun.Isim,
                    Resim = eklenecekUrun.Resim,
                    Aciklama = eklenecekUrun.Aciklama
                };
                _db.Urunler.Add(urun);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UrunSil(int id)
        {
            List<Urun> urunler = _db.Urunler.ToList();
            var silinecekUrun = urunler.FirstOrDefault(u => u.UrunId == id);
            if (silinecekUrun != null)
            {
                _db.Urunler.Remove(silinecekUrun);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


















    }
}
