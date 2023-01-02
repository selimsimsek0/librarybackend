using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class UserBookSKU : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid BookSKUId { get; set; }
        public string LibarianNote { get; set; }
        public DateTime CheckedOut { get; set; }
        public int Delay { get; set; }
        public double Fine { get; set; }
        public string HealtState { get; set; }
    }
}