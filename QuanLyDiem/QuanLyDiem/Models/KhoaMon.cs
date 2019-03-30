using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDiem.Models
{
    public class KhoaMon
    {
        [Key]
        [Column(Order = 0)]
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MonHocId { get; set; }
        public MonHoc MonHoc { get; set; }

        public int TinChi { get; set; }
        public int TongSoTietHoc { get; set; }
    }
}