using HRIS.Application.ModelView;
using HRIS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.IInterface
{
    public interface IUserProfile
    {
        Task<vw_employee_details> getuserProfile(long EmployeeId);
        Task<LoginUserDto> getloginUser(long EmployeeId);
        Task<List<AttendanceLogDto>> getIndividualAttendance(string startdate, string enddate, long EmployeeId);
    }
}
