namespace App.Data
{
    public class Book : BaseEntity
    {
        public long AuthorId { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public virtual Author Author { get; set; }
    }
}