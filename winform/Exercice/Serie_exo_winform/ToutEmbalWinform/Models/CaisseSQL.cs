using System;
using System.Collections.Generic;

namespace ToutEmbalWinform.Models;

public partial class CaisseSQL
{
    public int CaisseId { get; set; }

    public string CaisseNom { get; set; } = null!;

    public bool CaisseValid { get; set; }

    public int CaisseVitesseHeure { get; set; }

    public int ProdId { get; set; }

    public virtual ProductionSQL Prod { get; set; } = null!;
}
