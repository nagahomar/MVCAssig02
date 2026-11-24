using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(M => M.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
