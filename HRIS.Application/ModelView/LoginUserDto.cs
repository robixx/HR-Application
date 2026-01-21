using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.ModelView
{
    public class LoginUserDto
    {
        public long employeeId { get; set; }
        public string? fullname { get; set; }
        public string? designation { get; set; }
        public string? department { get; set; }
        public int roleId { get; set; }
    }
}
