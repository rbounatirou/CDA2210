using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ImportBdd.Models;

[Table("production_done")]
public partial class ProductionDone
{
    [Key]
    [Column("forge_id")]
    public int ForgeId { get; set; }

    [Column("forge_date", TypeName = "date")]
    public DateTime ForgeDate { get; set; }

    [Column("forge_quantity")]
    public int ForgeQuantity { get; set; }

    [Column("line_id")]
    [StringLength(3)]
    [Unicode(false)]
    public string LineId { get; set; } = null!;

    [Column("product_id")]
    public int ProductId { get; set; }

    [ForeignKey("LineId")]
    [InverseProperty("ProductionDones")]
    public virtual ProductionLine Line { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("ProductionDones")]
    public virtual Product Product { get; set; } = null!;
}
