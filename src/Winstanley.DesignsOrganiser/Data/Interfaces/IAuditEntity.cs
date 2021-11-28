using System;

namespace Winstanley.DesignsOrganiser.Data.Interfaces;

public interface IAuditEntity<TKey> : IAuditEntity, IEntityBase<TKey>
{
}

public interface IAuditEntity
{
    DateTime CreatedAt { get; set; }
    string CreatedBy { get; set; }
    DateTime? UpdatedAt { get; set; }
    string UpdatedBy { get; set; }
}