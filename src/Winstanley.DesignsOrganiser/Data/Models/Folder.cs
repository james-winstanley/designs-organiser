
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Winstanley.DesignsOrganiser.Data.Models.Base;

namespace Winstanley.DesignsOrganiser.Data.Models
{
    public record Folder : AuditEntity<int>
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        [Required]
        public int ParentFolderId { get; set; }

        // Foreign Keys
        [ForeignKey(nameof(ParentFolderId))] public Folder ParentFolder { get; set; }
    }
}
