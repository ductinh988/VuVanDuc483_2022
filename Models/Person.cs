using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using VuVanDuc2022483.Models;

namespace VuVanDuc2022483.Models
{
    public class Person
    {
        [Key]
        [DataType("varchar"), MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Mã")]
        [Required]
        public string PersonId { get; set; }
        [DataType("nvarchar"), MaxLength(50)]
        [Display(Name = "Tên")]
        [Required]
        public string PersonName { get; set; }
    }
}