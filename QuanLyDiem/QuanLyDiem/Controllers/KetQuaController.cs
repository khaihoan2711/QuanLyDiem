using QuanLyDiem.Models;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;

namespace QuanLyDiem.Controllers
{
    public class KetQuaController : Controller
    {
        ApplicationDbContext dbContext = null;
        public KetQuaController()
        {
            dbContext = new ApplicationDbContext();
        }

        // GET: KetQua
        public ActionResult Index()
        {
            var ketQua = dbContext.KetQuas
                .Include(c => c.SinhVien)
                .Include(c => c.MonHoc)
                .OrderBy(c => c.SinhVien.Ten)
                .ToList();

            return View(ketQua);
        }

        [HttpPost]
        public ActionResult Index(int svId = 0)
        {

            if (svId == 0)
            {
                return RedirectToAction("Index");
            }
            var ketQua = dbContext.KetQuas
                .Include(c => c.SinhVien)
                .Include(c => c.MonHoc)
                .Where(c => c.SinhVienId == svId)
                .OrderBy(c => c.MonHoc.TenMonHoc)
                .ToList();

            return View("Index", ketQua);
        }

        // GET: KetQua/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KetQua/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KetQua/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KetQua/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KetQua/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KetQua/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KetQua/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
