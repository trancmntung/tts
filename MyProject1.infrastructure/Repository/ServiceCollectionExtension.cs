using MyProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MyProject.infrastructure.Repository;

namespace MyProject.infrastructure.Repository
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IQuocGiaRepository, QuocGiaRepository>();
            services.AddTransient<ITinhRepository, ITinhRepository>();
            services.AddTransient<IHuyenRepository, IHuyenRepository>();
            services.AddTransient<IXaRepository, IXaRepository>();
            services.AddTransient<IHoSoUngVienRepository, IHoSoUngVienRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
