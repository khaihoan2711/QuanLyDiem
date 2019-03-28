using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDiem.Models
{
    public class Khoa
    {
        //Mã  khoa giảng dạy
        [Key]        
        public int Id { get; set; }
        //Tên khoa giảng dạy
        public string TenKhoa { get; set; }        
    }
}