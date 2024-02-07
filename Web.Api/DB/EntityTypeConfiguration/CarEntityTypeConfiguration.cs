// Copyright (c) IUA. All rights reserved.

namespace Web.Api.DB.EntityTypeConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Api.Model;

/// <summary>
/// Car entity type configuration.
/// </summary>
public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
