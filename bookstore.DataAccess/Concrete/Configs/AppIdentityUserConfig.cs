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
    public class AppIdentityUserConfig : IEntityTypeConfiguration<AppIdentityUser>
    {
        public void Configure(EntityTypeBuilder<AppIdentityUser> builder)
        {
            builder.Property(x => x.UserName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).IsRequired();

            builder.HasMany(x => x.Orders).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).OnDelete(deleteBehavior: DeleteBehavior.NoAction);
            
        }
    }
}
