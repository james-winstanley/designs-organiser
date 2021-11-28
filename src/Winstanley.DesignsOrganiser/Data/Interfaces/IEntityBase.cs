namespace Winstanley.DesignsOrganiser.Data.Interfaces;

public interface IEntityBase<TKey>
{
    TKey Id { get; set; }
}