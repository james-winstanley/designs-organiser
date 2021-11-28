using System;
using System.ComponentModel.DataAnnotations;
using Winstanley.DesignsOrganiser.Data.Interfaces;

namespace Winstanley.DesignsOrganiser.Data.Models.Base;

public abstract record AuditEntity : IAuditEntity
{
    [Required]
    [StringLength(36)]
    public string CreatedBy { get; set; }
        
    public DateTime CreatedAt { get; set; }

    [StringLength(36)]
    public string UpdatedBy { get; set; }
        
    public DateTime? UpdatedAt { get; set; }
}

public abstract record AuditEntity<TKey> : EntityBase<TKey>, IAuditEntity<TKey>
{
    [Required] [StringLength(36)] public string CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    [StringLength(36)] public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }
}