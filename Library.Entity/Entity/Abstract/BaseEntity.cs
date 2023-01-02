using System.Text;

namespace Library.Entity.Entity.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append("Id: ");
            stringBuilder.Append(Id);
            stringBuilder.AppendLine();
            stringBuilder.Append("Creation Date: ");
            stringBuilder.Append(CreationDate);
            stringBuilder.AppendLine();
            stringBuilder.Append("Modify Date: ");
            stringBuilder.Append(ModifyDate);
            stringBuilder.AppendLine();
            stringBuilder.Append("Active: ");
            stringBuilder.Append(IsActive);
            stringBuilder.AppendLine();
            stringBuilder.Append("Deleted: ");
            stringBuilder.Append(IsDeleted);
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
