using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDiem.Models;

namespace QuanLyDiem.Controllers
{
    public class MonHocController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public MonHocController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Lop
        public ActionResult MonHoc()
        {
            var monhoc = _dbContext.MonHocs.ToList();
            return View(monhoc);

        }
        public ActionResult ThemMonHoc(MonHoc mh)
        {
            _dbContext.MonHocs.Add(mh);
            _dbContext.SaveChanges();
            return View(mh);
        }

        // GET: Khoa/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var monhoc = _dbContext.MonHocs.Where(c => c.Id == id).FirstOrDefault();
            return View(monhoc);
        }

        [HttpPost]
        public ActionResult Edit(MonHoc k)
        {
            try
            {
                MonHoc mh = _dbContext.MonHocs.Where(c => c.Id == k.Id).FirstOrDefault();
                mh.Id = k.Id;
                _dbContext.MonHocs.Add(mh);
                _dbContext.Entry(mh).State = EntityState.Modified;
                // TODO: Add update logic here
                _dbContext.SaveChanges();
                return RedirectToAction("MonHoc");
            }
            catch
            {
                return View();
            }

        }

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            var monhoc = _dbContext.MonHocs.Where(c => c.Id == id).FirstOrDefault();

            return View(monhoc);
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(MonHoc mh)
        {
            try
            {
                _dbContext.MonHocs.Add(mh);
                _dbContext.Entry(mh).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return RedirectToAction("MonHoc");
            }
            catch
            {
                return View();
            }
        }

    }
}
