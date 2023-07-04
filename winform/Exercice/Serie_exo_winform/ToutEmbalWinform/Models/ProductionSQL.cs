using System;
using System.Collections.Generic;

namespace ToutEmbalWinform.Models;

public partial class ProductionSQL
{
    public int ProdId { get; set; }

    public string ProdNom { get; set; } = null!;

    public decimal ProductionCaisseTauxDefaut { get; set; }

    public int ProdObjectif { get; set; }

    public virtual ICollection<CaisseSQL> Caisses { get; set; } = new List<CaisseSQL>();
}
