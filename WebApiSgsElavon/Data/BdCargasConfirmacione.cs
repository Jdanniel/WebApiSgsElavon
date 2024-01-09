using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCargasConfirmacione
{
    public int IdCargaConfirmaciones { get; set; }

    public string NombreCargaConfirmaciones { get; set; }

    public int IdStatusCargaConfirmaciones { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdArchivosConfirmacione> BdArchivosConfirmaciones { get; set; } = new List<BdArchivosConfirmacione>();

    public virtual ICollection<BdConfirmacione> BdConfirmaciones { get; set; } = new List<BdConfirmacione>();

    public virtual ICollection<BdConfirmacionesIntermedium> BdConfirmacionesIntermedia { get; set; } = new List<BdConfirmacionesIntermedium>();
}
