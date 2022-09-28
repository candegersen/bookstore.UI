using bookstore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Concrete.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Author).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)").IsRequired();


            //builder.HasMany(x => o).WithOne(x => x.product).HasForeignKey(x => x.Id);
        }
    }
}
