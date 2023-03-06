using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ImportBdd.Models;

[Table("production_lines")]
[Index("LineId", Name = "UQ__producti__F5AE5F638B6EFC8F", IsUnique = true)]
public partial class ProductionLine
{
    [Key]
    [Column("line_id")]
    [StringLength(3)]
    [Unicode(false)]
    public string LineId { get; set; } = null!;

    [Column("line_label")]
    [StringLength(50)]
    [Unicode(false)]
    public string LineLabel { get; set; } = null!;

    [Column("product_id")]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductionLines")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("Line")]
    public virtual ICollection<ProductionDone> ProductionDones { get; } = new List<ProductionDone>();
}
