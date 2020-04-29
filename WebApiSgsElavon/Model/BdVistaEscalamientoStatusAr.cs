﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_VISTA_ESCALAMIENTO_STATUS_AR")]
    public partial class BdVistaEscalamientoStatusAr
    {
        [Column("ID_VISTA_ESCALAMIENTO_STATUS_AR")]
        public int IdVistaEscalamientoStatusAr { get; set; }
        [Column("ID_VISTA_ESCALAMIENTO")]
        public int? IdVistaEscalamiento { get; set; }
        [Column("ID_STATUS_AR")]
        public int? IdStatusAr { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdVistaEscalamiento")]
        [InverseProperty("BdVistaEscalamientoStatusAr")]
        public virtual CVistasEscalamiento IdVistaEscalamientoNavigation { get; set; }
    }
}
