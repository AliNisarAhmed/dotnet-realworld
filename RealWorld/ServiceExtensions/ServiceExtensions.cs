using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using Contracts;

namespace RealWorld.ServiceExtensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureCors(this IServiceCollection services) =>
				services.AddCors(options =>
				{
					options.AddPolicy("CorsPolicy", builder =>
									builder.AllowAnyOrigin()
											.AllowAnyMethod()
											.AllowAnyHeader());

				});

		public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
				=> services.AddDbContext<RepositoryContext>(opts =>
						opts.UseNpgsql(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("RealWorld"))
				);

		public static void ConfigureRepositoryManager(this IServiceCollection services) =>
			services.AddScoped<IRepositoryManager, RepositoryManager>();
	}
}