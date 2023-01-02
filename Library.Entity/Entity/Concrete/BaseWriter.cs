using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class BaseWriter : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Biography { get; set; }
    }
}