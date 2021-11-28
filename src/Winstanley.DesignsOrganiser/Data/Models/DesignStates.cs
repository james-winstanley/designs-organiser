using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Winstanley.DesignsOrganiser.Data.Models;

public record DesignStates
{
    [Key]
    [Required]
    public int DesignId { get; set; }

    public bool IsSent { get; set; }
    public DateTime? SentAt { get; set; }

    public bool IsSold { get; set; }
    public DateTime? SoldAt { get; set; }

    public bool IsInvoiced { get; set; }
    public DateTime? InvoicedAt { get; set; }

    public bool IsPaid { get; set; }
    public DateTime? PaidAt { get; set; }

    // Foreign Keys
    [ForeignKey(nameof(DesignId))] public Design Design { get; set; }
}
