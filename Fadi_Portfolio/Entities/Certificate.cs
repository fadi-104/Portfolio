namespace Fadi_Portfolio.Entities
{
    public class Certificate : BaseEntity
    {
        public string Name { get; set; }
        public string From { get; set; }
        public DateOnly Date { get; set; }
        public string Level { get; set; }
    }
}
