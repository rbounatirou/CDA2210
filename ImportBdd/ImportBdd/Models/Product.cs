using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ImportBdd.Models;

[Table("products")]
[Index("ProductName", Name = "UQ__products__2B5A6A5F85237E0F", IsUnique = true)]
public partial class Product
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Column("product_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    [Column("product_value")]
    public int? ProductValue { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<ProductionDone> ProductionDones { get; } = new List<ProductionDone>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductionLine> ProductionLines { get; } = new List<ProductionLine>();
}
