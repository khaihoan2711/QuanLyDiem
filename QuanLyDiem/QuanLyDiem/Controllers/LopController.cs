using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDiem.Models;
namespace QuanLyDiem.Controllers
{
    public class LopController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public LopController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Lop
        public ActionResult Lop()
        {
            var lp = _dbContext.Lops.ToList();
            return View(lp);

        }

        public ActionResult ThemLop()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemLop(Lop lp)
        {
            _dbContext.Lops.Add(lp);
            _dbContext.SaveChanges();
            return RedirectToAction("Lop");
        }

        // GET: Khoa/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var lop = _dbContext.Lops.Where(c => c.Id == id).FirstOrDefault();
            return View(lop);
        }
        [HttpPost]
        public ActionResult Edit(Lop k)
        {
            try
            {
                Lop lp = _dbContext.Lops.Where(c => c.Id == k.Id).FirstOrDefault();
                lp.Id = k.Id;
                lp.SiSo = k.SiSo;
                lp.KhoaID = k.KhoaID;
                _dbContext.Lops.Add(lp);
                _dbContext.Entry(lp).State = EntityState.Modified;
                // TODO: Add update logic here
                _dbContext.SaveChanges();
                return RedirectToAction("Lop");
            }
            catch
            {
                return View();
            }

        }

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            var lp = _dbContext.Lops.Where(c => c.Id == id).FirstOrDefault();

            return View(lp);
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(Lop lp)
        {
            try
            {
                _dbContext.Lops.Add(lp);
                _dbContext.Entry(lp).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return RedirectToAction("Lop");
            }
            catch
            {
                return View();
            }
        }

    }
}