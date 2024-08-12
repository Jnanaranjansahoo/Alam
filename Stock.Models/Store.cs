using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Models
{
    public class Store
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        
        [Required]
        public string Company { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Defect { get; set; }
        public int Total { get; set; }
        public string Transport { get; set; }
    }
}
