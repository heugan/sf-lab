using System.ComponentModel.DataAnnotations;

namespace SUT_MVC.Models
{
    public class ViewCalculator
    {
        [Display(Name = "Term 1")]
        public int Term1 { get; set; }
        [Display(Name = "Term 2")]
        public int Term2 { get; set; }
        public int Sum { get; set; }
    }
}