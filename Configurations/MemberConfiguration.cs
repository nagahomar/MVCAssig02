using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class MemberConfiguration : GymUserConfiguration<Member>, IEntityTypeConfiguration<Member>
    {
        public new  void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(M=>M.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
