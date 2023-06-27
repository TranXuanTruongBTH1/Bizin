using System.ComponentModel.DataAnnotations;
namespace Bingit.Models
{
    
    public class TXTSINHVIEN
    {
        [Key]
        [MaxLength(20)]
        [Display(Name ="Mã sinh viên")]
        public int? MASV {get;set;}
        [MaxLength(50)]
        [Display(Name ="Họ và tên")]
        public string? NAME {get;set;}
        [MaxLength(20)]
        [Display(Name ="Mã lớp")]
        public int? MALOP {get;set;}
    }
}