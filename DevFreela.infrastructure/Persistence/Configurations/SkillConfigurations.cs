using System;
using DevFreela.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.infrastructure.Persistence.Configurations;

public class SkillConfigurations : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder
            .HasKey(s => s.Id);
    }
}
