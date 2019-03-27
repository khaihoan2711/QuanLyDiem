using System.ComponentModel.DataAnnotations;

namespace QuanLyDiem.Models
{
    public class MonHoc
    {
        [Key]
        public int Id { get; set; }
        public string TenMonHoc { get; set; }
    }
}