using DockerDemoApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemoApi.Infrastructure.EntityConfigurations
{
    public class ProductEntityTypeConfiguration
          : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id).ValueGeneratedOnAdd();
            builder.Property(ci => ci.Price).HasColumnType($"decimal(5,2)");

        }
    }
}
