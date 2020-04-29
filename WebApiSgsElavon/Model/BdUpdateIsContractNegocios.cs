using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UPDATE_IS_CONTRACT_NEGOCIOS")]
    public partial class BdUpdateIsContractNegocios
    {
        [Key]
        [Column("ID_UPDATE_IS_CONTRACT_NEGOCIOS")]
        public int IdUpdateIsContractNegocios { get; set; }
        [Column("ID_NEGOCIO")]
        public int? IdNegocio { get; set; }
    }
}
