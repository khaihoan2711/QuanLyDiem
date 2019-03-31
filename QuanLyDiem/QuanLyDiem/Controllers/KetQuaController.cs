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
        public ActionResult Details(int svId, int monHocId, int lanThi)
        {
            var ketqua = dbContext.KetQuas
                .Include(c => c.SinhVien)
                .Include(c => c.MonHoc)
                .Where(c => c.SinhVienId == svId && c.MonHocId == monHocId && c.LanThi == lanThi)
                .FirstOrDefault();
            return View(ketqua);
        }

        // GET: KetQua/Create
        public ActionResult NhapKetQua()
        {
            return View();
        }

        // POST: KetQua/Create
        [HttpPost]
        public ActionResult NhapKetQua(FormCollection collection)
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
        public ActionResult Edit(int svId, int monHocId, int lanThi)
        {
            KetQua model = dbContext.KetQuas
                .Include(c => c.SinhVien)
                .Include(c => c.MonHoc)
                .Where(c => c.SinhVienId == svId && c.MonHocId == monHocId && c.LanThi == lanThi)
                .FirstOrDefault();
            return View(model);
        }

        // POST: KetQua/Edit/5
        [HttpPost]
        public ActionResult Edit(KetQua kq)
        {
            try
            {
                dbContext.KetQuas.Add(kq);
                dbContext.Entry(kq).State = EntityState.Modified;
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KetQua/Delete/5
        public ActionResult Delete(int svId, int monHocId, int lanThi)
        {

            KetQua model = dbContext.KetQuas
                .Include(c => c.SinhVien)
                .Include(c => c.MonHoc)
                .Where(c => c.SinhVienId == svId && c.MonHocId == monHocId && c.LanThi == lanThi)
                .FirstOrDefault();

            dbContext.KetQuas.Add(model);
            dbContext.Entry(model).State = EntityState.Deleted;
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
