namespace Library.Entity.Entity.Abstract
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ModifyDate { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
    }
}
