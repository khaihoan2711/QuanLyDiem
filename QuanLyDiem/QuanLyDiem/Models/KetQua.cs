using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyDiem.Models
{
    public class KetQua
    {
        [Key]
        [Column(Order = 0)]
        public int SinhVienId { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MonHocId { get; set; }
        public virtual MonHoc MonHoc { get; set; }

        [Key]
        [Column(Order = 2)]
        public int LanThi { get; set; }

        public int DiemThi { get; set; }
    }
}