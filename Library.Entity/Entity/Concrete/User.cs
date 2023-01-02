using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}