using LeaveManagement.web.Data;
using LeaveManagement.web.GenericRepoistory;
using LeaveManagement.web.Repoistory.Interfaces;

namespace LeaveManagement.web.Repoistory
{
    public class LeaveTypeRepoistory : GenericRepoistory<LeaveType> , ILeaveTypeRepoistory
    {
        public LeaveTypeRepoistory(ApplicationDbContext context) :  base(context) { }
    }
}
