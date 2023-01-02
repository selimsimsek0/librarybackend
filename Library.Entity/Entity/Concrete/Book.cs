using Library.Entity.Entity.Abstract;
using System.Text;

namespace Library.Entity.Entity.Concrete
{
    public class Book : BaseEntity
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime PublishDate { get; set; }
        public int Category { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append("ISBN: ");
            stringBuilder.Append(ISBN);
            stringBuilder.AppendLine();
            stringBuilder.Append("Name: ");
            stringBuilder.Append(Name);
            stringBuilder.AppendLine();
            stringBuilder.Append("Description: ");
            stringBuilder.Append(Description);
            stringBuilder.AppendLine();
            stringBuilder.Append("Language: ");
            stringBuilder.Append(Language);
            stringBuilder.AppendLine();
            stringBuilder.Append("Publish Date: ");
            stringBuilder.Append(PublishDate);
            stringBuilder.AppendLine();
            return base.ToString() + stringBuilder.ToString();
        }
    }
}