using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}