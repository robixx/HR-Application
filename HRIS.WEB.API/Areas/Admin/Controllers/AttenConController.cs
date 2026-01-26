using HRIS.Application.IInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.WEB.API.Areas.Admin.Controllers
{
    [Area("Accounts")]
    [Route("api/[Area]/[controller]")]
    [ApiController]
    public class AttenConController : ControllerBase
    {
        private readonly IUserProfile _userprofile;

        public AttenConController(IUserProfile userprofile)
        {
            _userprofile = userprofile;
        }


        [HttpGet("get_Attendace")]
        public async Task<IActionResult> Get(string startdate, string enddate)
        {


            var Results = await _userprofile.getAttendance(startdate, enddate);
            var jsonData = new
            {
                code = "200",
                status = true,
                data = Results,
            };
            return Ok(jsonData);
        }
    }
}
