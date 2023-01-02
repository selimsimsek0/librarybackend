using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class CurrencyType : BaseEntity
    {
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
    }
}