using AutoMapper;
using Iranpl.ApplicationCore.Profiles;
using Iranpl.ApplicationCore.Services.Implementations;
using Iranpl.ApplicationCore.Services.Intefaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Iranpl.Ioc
{
    public static class DependencyContainers
    {
        public static void RegisterServices(this IServiceCollection service, IConfiguration configuration)
        {
            #region DI
            service.AddScoped<ILoginService, LoginService>();
            //service.AddScoped<IHttpService, HttpService>();
            #endregion

            #region AutoMapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
            #endregion
        }
    }
}
