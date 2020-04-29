using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIOS")]
    public partial class BdEnvios
    {
        public BdEnvios()
        {
            BdEnvioInsumos = new HashSet<BdEnvioInsumos>();
            BdEnvioUnidad = new HashSet<BdEnvioUnidad>();
        }

        [Key]
        [Column("ID_ENVIO")]
        public int IdEnvio { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int? IdServicioMensajeria { get; set; }
        [Column("NO_GUIA")]
        [StringLength(50)]
        public string NoGuia { get; set; }
        [Column("ID_CHOFER")]
        public int? IdChofer { get; set; }
        [Column("HORA_ENTREGA", TypeName = "smalldatetime")]
        public DateTime? HoraEntrega { get; set; }
        [Column("PESO", TypeName = "numeric(18, 4)")]
        public decimal? Peso { get; set; }
        [Column("PAQUETES")]
        public int? Paquetes { get; set; }
        [Column("ID_PRODUCTO_DHL")]
        public int? IdProductoDhl { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("ID_URGENCIA_ENVIO")]
        public int? IdUrgenciaEnvio { get; set; }
        [Column("FEC_ENVIO", TypeName = "smalldatetime")]
        public DateTime? FecEnvio { get; set; }
        [Column("FEC_RECEPCION", TypeName = "smalldatetime")]
        public DateTime? FecRecepcion { get; set; }
        [Column("IS_STOCK")]
        public int? IsStock { get; set; }
        [Column("ID_STATUS_ENVIO")]
        public int? IdStatusEnvio { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_DIRECCION_DESTINO")]
        public int? IdDireccionDestino { get; set; }
        [Column("OTRA_DIRECCION_DESTINO")]
        [StringLength(255)]
        public string OtraDireccionDestino { get; set; }
        [Column("ID_CLIENTE_NUEVO")]
        public int? IdClienteNuevo { get; set; }
        [Column("IS_ALTA_MASIVA_SIM_ESPECIAL")]
        public int? IsAltaMasivaSimEspecial { get; set; }
        [Column("ID_SERVICIO_MENSAJERIAS_PRECIO")]
        public int? IdServicioMensajeriasPrecio { get; set; }

        [ForeignKey("IdChofer")]
        [InverseProperty("BdEnvios")]
        public virtual CUsuarios IdChoferNavigation { get; set; }
        [ForeignKey("IdDireccionDestino")]
        [InverseProperty("BdEnvios")]
        public virtual BdDirecciones IdDireccionDestinoNavigation { get; set; }
        [ForeignKey("IdServicioMensajeria")]
        [InverseProperty("BdEnvios")]
        public virtual CServicioMensajeria IdServicioMensajeriaNavigation { get; set; }
        [ForeignKey("IdStatusEnvio")]
        [InverseProperty("BdEnvios")]
        public virtual CStatusEnvio IdStatusEnvioNavigation { get; set; }
        [ForeignKey("IdTipoResponsableDestino")]
        [InverseProperty("BdEnviosIdTipoResponsableDestinoNavigation")]
        public virtual CTipoResponsable IdTipoResponsableDestinoNavigation { get; set; }
        [ForeignKey("IdTipoResponsableOrigen")]
        [InverseProperty("BdEnviosIdTipoResponsableOrigenNavigation")]
        public virtual CTipoResponsable IdTipoResponsableOrigenNavigation { get; set; }
        [ForeignKey("IdUrgenciaEnvio")]
        [InverseProperty("BdEnvios")]
        public virtual CUrgenciaEnvio IdUrgenciaEnvioNavigation { get; set; }
        [InverseProperty("IdEnvioNavigation")]
        public virtual ICollection<BdEnvioInsumos> BdEnvioInsumos { get; set; }
        [InverseProperty("IdEnvioNavigation")]
        public virtual ICollection<BdEnvioUnidad> BdEnvioUnidad { get; set; }
    }
}
