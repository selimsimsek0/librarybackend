using Library.Entity.Entity.Abstract;

namespace Library.Entity.Entity.Concrete
{
    public class BookStokKeepingUnit : BaseEntity
    {
        public Guid BookId { get; set; }
        public Guid PublisherId { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string VolumeType { get; set; }
        public string PaperType { get; set; }
        public string Size { get; set; }
        public double BuyingPrice { get; set; }
        public int CurrencyTypeId { get; set; }
        public DateTime PublishDate { get; set; }
        public double DelayFactor { get; set; }
        public double DamageFactor { get; set; }
        public string HealtState { get; set; }
    }
}