using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winstanley.DesignsOrganiser.Data.Models;

public record DesignTag
{
    [Key][Required]
    public int DesignId { get; set; }
    [Key][Required]
    public int TagId { get; set; }

    // Foreign Keys
    [ForeignKey(nameof(DesignId))] public Design Design { get; set; }
    [ForeignKey(nameof(TagId))] public Tag Tag { get; set; }
}
