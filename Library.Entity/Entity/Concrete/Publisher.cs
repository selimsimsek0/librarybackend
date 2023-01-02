using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }
        public string GLN { get; set; }
        public string PhoneNumber { get; set; }
    }
}