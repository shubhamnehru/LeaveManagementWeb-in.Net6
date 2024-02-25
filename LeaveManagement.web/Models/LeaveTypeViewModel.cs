using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "No. of Default Days")]
        [Required]
        [Range(1, 25,ErrorMessage = "Max only 25 characters")]
        public int DefaultDays { get; set; }
    }
}
