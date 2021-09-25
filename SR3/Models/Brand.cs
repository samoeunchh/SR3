using System;
using System.ComponentModel.DataAnnotations;

namespace SR3.Models
{
    public class Brand
    {
        [Key]
        public Guid BrandId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="Brand Name field is required")]
        [Display(Name ="Brand Name")]
        public string BrandName { get; set; }
        public string Description { get; set; }
    }
}
