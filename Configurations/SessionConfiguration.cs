using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("cK_CapacityConstraint", "Capacity Between 1 And 25");
                X.HasCheckConstraint("cK_StratEndDateConstraint", "EndDate > StartDate ");
            });

            builder.HasOne(S => S.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
