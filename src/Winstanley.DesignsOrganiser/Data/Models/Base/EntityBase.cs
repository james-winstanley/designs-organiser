using System.ComponentModel.DataAnnotations;
using Winstanley.DesignsOrganiser.Data.Interfaces;

namespace Winstanley.DesignsOrganiser.Data.Models.Base;

public abstract record EntityBase<TKey> : IEntityBase<TKey>
{
    [Key]
    [Required]
    public virtual TKey Id { get; set; }
}