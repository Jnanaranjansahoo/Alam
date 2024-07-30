using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Stock.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        public double Quantity { get; set; }
        [ValidateNever]
        public double AddValue { get; set; }
        [ValidateNever]
        public double SubValue { get; set; }
        public double TotalQ { get; set; }
    }
}
