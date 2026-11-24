using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCAssig02.Entities;

namespace MVCAssig02.Configurations
{
    public class GymUserConfiguration<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(U => U.Name).HasColumnType("varchar(50)");
            builder.Property(U => U.Email).HasColumnType("varchar(100)");
            builder.Property(U => U.Phone).HasColumnType("varchar(11)");
            builder.ComplexProperty(U => U.Address);
            //Same As Above---> builder.OwnsOne(U=>U.Address);
            builder.HasIndex(U=>U.Phone).IsUnique();
            builder.HasIndex(U => U.Email).IsUnique();
            builder.ToTable(X =>
            {
                X.HasCheckConstraint("cK_EmailConstraint","Email Like '_%@_%._%'");
                X.HasCheckConstraint("cK_PhoneConstraint", "Len(Phone)=11 And (Phone Like '010%' or Phone Like '012%'or Phone Like '011%'or Phone Like '015%')");
            });

        }
    }
}
