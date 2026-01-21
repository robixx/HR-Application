using HRIS.Application.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Application.IInterface
{
    public interface IAuth
    {
        Task<WebUserResponse> LoginWebUser(AuthenticationRequest request);
    }
}
