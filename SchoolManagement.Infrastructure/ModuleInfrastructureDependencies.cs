using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Infrastructure.Abstraction;
using SchoolManagement.Infrastructure.InfrastructureBases;
using SchoolManagement.Infrastructure.Repo;

namespace SchoolManagement.Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient<IStudentRepository, StudentRepository>();
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        return services;
    }
}

