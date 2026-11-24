using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("cK_DurationDaysConstraints", "DurationDays Between 1 And 365");
            });
        }
    }
}
