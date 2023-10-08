using Microsoft.EntityFrameworkCore;
using QuestionnaireAnalyzer.Data.Entities;

namespace QuestionnaireAnalyzer.Data.Context;

public class AnalyzerDbContext : DbContext
{
    public DbSet<TempEntity> Temps { get; set; }


    public AnalyzerDbContext(DbContextOptions<AnalyzerDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(AnalyzerDbContext).Assembly);
    }
}
