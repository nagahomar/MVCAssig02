using MVCAssig02.Entities.Enums;

namespace MVCAssig02.Entities
{
    public class Trainer : GymUser
    {

        //CreatedAt------>HireDate

        public Speciality speciality { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
