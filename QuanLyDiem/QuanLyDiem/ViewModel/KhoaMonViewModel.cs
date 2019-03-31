using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLyDiem.Models;

namespace QuanLyDiem.ViewModel
{
    public class KhoaMonViewModel
    {
        [Key]
        [Column(Order = 0)]
        public int Khoa { get; set; }
        public IEnumerable<Khoa> Khoas { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MonHoc { get; set; }
        public IEnumerable<MonHoc> MonHocs { get; set; }

        public int TinChi { get; set; }
        public int TongSoTietHoc { get; set; }
    }
}