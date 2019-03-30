using QuanLyDiem.Models;
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
            return View();
        }

        // POST: Khoa/Edit/5
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

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Khoa/Delete/5
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
