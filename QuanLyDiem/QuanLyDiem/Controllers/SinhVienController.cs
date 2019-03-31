using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDiem.Models;

namespace QuanLyDiem.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public SinhVienController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: SinhVien
        public ActionResult SinhVien()
        {
            var sv = _dbContext.SinhViens.ToList();
            return View(sv);
        }

        public ActionResult ThemSinhVien()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemSinhVien(SinhVien sinhVien)
        {
            _dbContext.SinhViens.Add(sinhVien);
            _dbContext.SaveChanges();
            return RedirectToAction("SinhVien");
        }

        // GET: Khoa/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var sinhvien = _dbContext.SinhViens.Where(c => c.Id == id).FirstOrDefault();
            return View(sinhvien);
        }
        [HttpPost]
        public ActionResult Edit(SinhVien k)
        {
            try
            {
                SinhVien sv = _dbContext.SinhViens.Where(c => c.Id == k.Id).FirstOrDefault();
                sv.Ho = k.Ho;
                sv.Ten = k.Ten;
                sv.NgaySinh = k.NgaySinh;
                sv.DiaChi = k.DiaChi;
                sv.DienThoai = k.DienThoai;
                sv.GioiTinh = k.GioiTinh;
                sv.NienKhoa = k.NienKhoa;
                sv.LopId = k.LopId;

                _dbContext.SinhViens.Add(sv);
                _dbContext.Entry(sv).State = EntityState.Modified;
                // TODO: Add update logic here
                _dbContext.SaveChanges();
                return RedirectToAction("SinhVien");
            }
            catch
            {
                return View();
            }

        }

       

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            var sinhvien = _dbContext.SinhViens.Where(c => c.Id == id).FirstOrDefault();

            return View(sinhvien);
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(SinhVien sv)
        {
            try
            {
                _dbContext.SinhViens.Add(sv);
                _dbContext.Entry(sv).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return RedirectToAction("SinhVien");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Details(int Id)
        {
            try
            {
                SinhVien sv =  _dbContext.SinhViens
                    .Include(c => c.Lop)
                    .Where(c => c.Id == Id).FirstOrDefault();
                return View(sv);
            }
            catch
            {
                return View();
            }
        }
    }
}