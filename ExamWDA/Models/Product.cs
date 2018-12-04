using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamWDA.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Exam Subject")]
        public string Subject { get; set; }
        [Display(Name = "Exam Time")]
        public DateTime StarTime { get; set; }
        [Display(Name = "Exam Date")]
        [Required(ErrorMessage ="Không bỏ trống phần này.")]
        [DataType(DataType.Time)]
        public DateTime ExamDate { get; set; }
        [Display(Name = "Exam Duration ")]
        [Required(ErrorMessage = "Không bỏ trống phần này.")]
        public int Duration { get; set; }
        [Display(Name = "Exam ClassRoom ")]
        [Required(ErrorMessage = "Không bỏ trống phần này.")]
        public string ClassRoom { get; set; }
        [Display(Name = "Exam Faculty ")]
        [Required(ErrorMessage = "Không bỏ trống phần này.")]
        public string Faculty { get; set; }
        
    }
}