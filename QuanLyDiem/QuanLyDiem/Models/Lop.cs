using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDiem.Models
{
    public class Lop
    {
        //Mã lớp học
        [Key]        
        public int Id { get; set; }
        //Tên lớp
        public string TenLop { get; set; }
        //Sĩ sô
        public int SiSo { get; set; }
        //Mã Khoa đào tạo
        public int KhoaID { get; set; }
        public virtual Khoa Khoa { get; set; }
    }
}