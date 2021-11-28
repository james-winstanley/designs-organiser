using System.ComponentModel.DataAnnotations;
using Winstanley.DesignsOrganiser.Data.Models.Base;

namespace Winstanley.DesignsOrganiser.Data.Models;

public record Tag : EntityBase<int>
{
    [Required]
    [StringLength(256)]
    public string Text { get; set; }
}
