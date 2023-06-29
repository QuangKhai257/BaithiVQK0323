using System.ComponentModel.DataAnnotations;
namespace BaithiVQK0323.Models;
public class VQKcau3 
{
    [Key]
    [Display(Name ="Họ tên")]
    public string hoten {get;set;}

    [Display(Name ="Giới tính")]
    public string gioitinh {get; set;}

    [Display(Name ="Địa chỉ")]
    public string diachi {get; set;}

}