using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public partial class Definitions : ModelBase
{

    public string Title { get; set; } = null!;
    [ForeignKey(nameof(Parent))]
    public Guid? ParentId { get; set; }

    public bool IsDeleted { get; set; } = false;

    public Definitions Parent { get; set; }

    [InverseProperty(nameof(Parent))]
    public ICollection<Definitions> Children { get; set; }
    public virtual ICollection<Entity> Entities { get; set; }

}
