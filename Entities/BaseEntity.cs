namespace MVCAssig02.Entities
{
    public class BaseEntity<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
