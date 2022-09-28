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
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AdressSpace).IsRequired().HasColumnType("ntext").HasMaxLength(250);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Neighbourhood).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PostalCode).IsRequired().HasMaxLength(10);

           builder.HasOne(t => t.AppIdentityUser).WithMany(t => t.Addresses).HasForeignKey(t => t.AppIdentityUserId);
            builder.HasMany(x => x.Orders).WithOne(x => x.Address).HasForeignKey(x => x.AddressId);
        }
    }
}
