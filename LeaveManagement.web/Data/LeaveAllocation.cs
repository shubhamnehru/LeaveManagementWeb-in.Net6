using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Data
{
    public class LeaveAllocation : BaseEnitity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")] //DataAnnotations
        public LeaveType LeaveType { get; set; }

        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
