using System;
using System.Collections.Generic;

namespace EF.Models;

public partial class Livre
{
    public int IdLivre { get; set; }

    public string TitreLivre { get; set; } = null!;

    public string ResumerLivre { get; set; } = null!;

    public int IdAuteur { get; set; }

    public virtual Auteur IdAuteurNavigation { get; set; } = null!;
}
