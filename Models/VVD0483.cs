using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using VuVanDuc2022483.Models;

namespace VuVanDuc2022483.Models
{
    public class VVD0483 
    {
        [Key]
        [DataType("nvarchar"), MaxLength(20)]
        [Display(Name = "Mã")]
        [Required]
        public string VVDId { get; set; }
        [DataType("nvarchar"), MaxLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string VVDName { get; set; }
        [Display(Name = "VU Van Duc Gender")]
        [Required]
         public string VVDGender { get; set; }
    }
}