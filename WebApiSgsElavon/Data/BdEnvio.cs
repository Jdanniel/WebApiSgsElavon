using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEnvio
{
    public int IdEnvio { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdServicioMensajeria { get; set; }

    public string NoGuia { get; set; }

    public int? IdChofer { get; set; }

    public DateTime? HoraEntrega { get; set; }

    public decimal? Peso { get; set; }

    public int? Paquetes { get; set; }

    public int? IdProductoDhl { get; set; }

    public decimal? Costo { get; set; }

    public int? IdUrgenciaEnvio { get; set; }

    public DateTime? FecEnvio { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public int? IsStock { get; set; }

    public int? IdStatusEnvio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public int? IdDireccionDestino { get; set; }

    public string OtraDireccionDestino { get; set; }

    public int? IdClienteNuevo { get; set; }

    public int? IsAltaMasivaSimEspecial { get; set; }

    public int? IdServicioMensajeriasPrecio { get; set; }

    public virtual ICollection<BdEnvioInsumo> BdEnvioInsumos { get; set; } = new List<BdEnvioInsumo>();

    public virtual ICollection<BdEnvioUnidad> BdEnvioUnidads { get; set; } = new List<BdEnvioUnidad>();

    public virtual CUsuario IdChoferNavigation { get; set; }

    public virtual BdDireccione IdDireccionDestinoNavigation { get; set; }

    public virtual CServicioMensajerium IdServicioMensajeriaNavigation { get; set; }

    public virtual CStatusEnvio IdStatusEnvioNavigation { get; set; }

    public virtual CTipoResponsable IdTipoResponsableDestinoNavigation { get; set; }

    public virtual CTipoResponsable IdTipoResponsableOrigenNavigation { get; set; }

    public virtual CUrgenciaEnvio IdUrgenciaEnvioNavigation { get; set; }
}
