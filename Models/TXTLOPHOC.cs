using System.ComponentModel.DataAnnotations;
namespace Bingit.Models
{
    
    public class TXTLOPHOC
    {
        [Key]
        [MaxLength(20)]
        [Display(Name ="Mã lớp học")]
        public string? MALOPHOC{get;set;}
        [MaxLength(50)]
        [Display(Name ="Tên lớp học")]
        public string? TENLOPHOC{get;set;}
    }
}