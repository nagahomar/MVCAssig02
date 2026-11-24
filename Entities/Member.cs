using MVCAssig02.Entities.Enums;
namespace MVCAssig02.Entities
{
    public class Member : GymUser
    {
       //CreatedAt------>JoinDate
       
        public string? Photo { get; set; }


        public ICollection<MemberShip> Plans { get; set; }
    }
}
