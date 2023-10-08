using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestionnaireAnalyzer.Data.Context;

namespace QuestionnaireAnalyzer.Data;

public static class ServicesConfiguration
{
    public static void AddDataBase(this IServiceCollection services, string sqliteConnectionString)
    {
        services.AddDbContext<AnalyzerDbContext>(options =>
            options.UseSqlite(sqliteConnectionString, x =>
                x.MigrationsAssembly(typeof(ServicesConfiguration).Assembly.FullName)));
    }
}
