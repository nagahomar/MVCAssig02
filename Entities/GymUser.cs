using MVCAssig02.Entities.Enums;

namespace MVCAssig02.Entities
{
    public class GymUser : BaseEntity<int>
    {
       
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirt { get; set; }

        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
