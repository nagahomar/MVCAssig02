using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssig02.Entities
{
    public class MemberShip:BaseEntity<int>
    {
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public String Status => StartDate > DateTime.Now ? "Upcoming"
                              : EndDate > DateTime.Now ? "Active"
                              : "Expired";

    }
}
