using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Winstanley.DesignsOrganiser.Data.Models.Base;

namespace Winstanley.DesignsOrganiser.Data.Models;

public record Design : AuditEntity<int>
{
    [Required]
    [StringLength(256)]
    public string Name { get; set; }

    public string Description { get; set; }

    public string FileName { get; set; }

    public int CategoryId { get; set; }

    [Required]
    public int FolderId { get; set; }

    // Foreign Keys
    [ForeignKey(nameof(CategoryId))] public Category Category { get; set; }
    [ForeignKey(nameof(FolderId))] public Folder Folder { get; set; }
}
