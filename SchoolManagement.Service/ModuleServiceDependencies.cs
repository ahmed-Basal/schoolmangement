using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Service.Abstract;
using SchoolManagement.Service.implement;

namespace SchoolManagement.Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {

        services.AddTransient<IStudentServices, StudentServices>();
        return services;
    }
}
