using QuanLyDiem.Models;
using QuanLyDiem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace QuanLyDiem.Controllers
{
    public class KhoaController : Controller
    {
        ApplicationDbContext dbContext;

        public KhoaController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Khoa
        public ActionResult Index()
        {
            var model = dbContext.Khoas.ToList();
            return View(model);
        }

        // GET: Khoa/Details/5
        public ActionResult Details(int id)
        {
            var khoaMon = dbContext.KhoaMons
                .Include(c => c.Khoa)
                .Include(c=>c.MonHoc)
                .Where(c => c.KhoaId == id).ToList();

            var khoa = dbContext.Khoas.Where(c => c.Id == id).ToList();

            ViewBag.Khoa = khoa[0].TenKhoa;
            return View("DanhSachMonHocCuaKhoa", khoaMon);
        }

        // GET: Khoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Khoa/Create
        [HttpPost]
        public ActionResult Create(Khoa khoa)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            dbContext.Khoas.Add(khoa);

            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Khoa/Edit/5
        public ActionResult Edit(int id)
        {
            var khoa = dbContext.Khoas.Where(c => c.Id == id).FirstOrDefault();
            return View(khoa);
        }

        // POST: Khoa/Edit/5
        [HttpPost]
        public ActionResult Edit(Khoa k)
        {
            try
            {
                Khoa khoa = dbContext.Khoas.Where(c => c.Id == k.Id).FirstOrDefault();
                khoa.TenKhoa = k.TenKhoa;
                dbContext.Khoas.Add(khoa);
                dbContext.Entry(khoa).State = EntityState.Modified;
                // TODO: Add update logic here
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            var khoa = dbContext.Khoas.Where(c => c.Id == id).FirstOrDefault();
            
            return View(khoa);
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(Khoa k)
        {
            try
            {
                dbContext.Khoas.Add(k);
                dbContext.Entry(k).State = EntityState.Deleted;

                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult ThemMonHocChoKhoa()
        {
            try
            {
                var model = new KhoaMonViewModel
                {
                    Khoas = dbContext.Khoas.ToList(),
                    MonHocs = dbContext.MonHocs.ToList()
                };

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult ThemMonHocChoKhoa(KhoaMonViewModel model)
        {
            try
            {
                var khoaMon = new KhoaMon
                {
                    KhoaId = model.Khoa,
                    MonHocId = model.MonHoc,
                    TinChi = model.TinChi,
                    TongSoTietHoc = model.TongSoTietHoc
                    
                };

                dbContext.KhoaMons.Add(khoaMon);
                dbContext.SaveChanges();

                return RedirectToAction("ThemMonHocChoKhoa");
            }
            catch
            {

                return View();
            }
        }
    }
}
