using QuestionnaireAnalyzer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QuestionnaireAnalyzer.Data.Configurations;

public class TempEntityConfiguration : IEntityTypeConfiguration<TempEntity>
{
    public void Configure(EntityTypeBuilder<TempEntity> builder)
    {
        builder.ToTable("temps")
            .HasKey(agency => agency.Id);
    }
}
