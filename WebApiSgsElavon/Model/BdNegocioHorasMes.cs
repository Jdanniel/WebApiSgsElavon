using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_NEGOCIO_HORAS_MES")]
    public partial class BdNegocioHorasMes
    {
        [Column("ID_NEGOCIO_HORAS_MES")]
        public int IdNegocioHorasMes { get; set; }
        [Column("ID_NEGOCIO")]
        public int IdNegocio { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_HORARIO")]
        public int IdHorario { get; set; }
        [Column("MES")]
        public int Mes { get; set; }
        [Column("ANIO")]
        public int Anio { get; set; }
        [Column("HORAS_MES")]
        public int HorasMes { get; set; }
        [Column("IS_CONTRACT")]
        public int? IsContract { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdNegocioHorasMes")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdNegocio")]
        [InverseProperty("BdNegocioHorasMes")]
        public virtual BdNegocios IdNegocioNavigation { get; set; }
    }
}
