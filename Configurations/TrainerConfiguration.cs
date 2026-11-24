using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class TrainerConfiguration :GymUserConfiguration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new  void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(T=>T.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
