using HRIS.Application.IInterface;
using HRIS.Infrastructure.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Infrastructure.MiddleWare
{
    public static class ServiceInjection
    {
        public static void InjectService(this IServiceCollection services)
        {
            services.AddScoped<JwtConfig>();
            services.AddScoped<IAuth, AuthService>();
            services.AddScoped<IUserProfile, UserProfileService>();
        }
    }
}
