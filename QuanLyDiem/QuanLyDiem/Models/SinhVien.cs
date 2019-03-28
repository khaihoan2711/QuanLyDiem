using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDiem.Models
{
    public class SinhVien
    {
        [Key]        
        public int Id { get; set; }        
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }        
        public string DiaChi { get; set; }        
        public string DienThoai{ get; set; }
        public int GioiTinh { get; set; }
        public DateTime NienKhoa { get; set; }
        public int LopId { get; set; }
        public Lop Lop { get; set; }
    }
}