using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargasConfirmaciones
    {
        public BdCargasConfirmaciones()
        {
            BdArchivosConfirmaciones = new HashSet<BdArchivosConfirmaciones>();
            BdConfirmaciones = new HashSet<BdConfirmaciones>();
            BdConfirmacionesIntermedia = new HashSet<BdConfirmacionesIntermedia>();
        }

        public int IdCargaConfirmaciones { get; set; }
        public string NombreCargaConfirmaciones { get; set; }
        public int IdStatusCargaConfirmaciones { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdArchivosConfirmaciones> BdArchivosConfirmaciones { get; set; }
        public virtual ICollection<BdConfirmaciones> BdConfirmaciones { get; set; }
        public virtual ICollection<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
    }
}
