using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDiem.Models
{
    public class MonHoc
    {
        [Key]        
        public int Id { get; set; }
        public string TenMonHoc { get; set; }
    }
}