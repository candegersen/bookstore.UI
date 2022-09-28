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
    public class ShipperConfig : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShipperName).IsRequired();

            builder.HasMany(x => x.Orders).WithOne(x => x.Shipper).HasForeignKey(x => x.Id);
        }
    }
}
