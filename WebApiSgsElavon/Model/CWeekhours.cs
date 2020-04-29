using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_WEEKHOURS")]
    public partial class CWeekhours
    {
        public CWeekhours()
        {
            BdHorarioWeekhour = new HashSet<BdHorarioWeekhour>();
        }

        [Key]
        [Column("ID_WEEKHOUR")]
        public int IdWeekhour { get; set; }
        [Column("DESC_WEEKHOUR")]
        [StringLength(50)]
        public string DescWeekhour { get; set; }
        [Column("WEEKDAY")]
        public int? Weekday { get; set; }
        [Column("START_TIME")]
        [StringLength(10)]
        public string StartTime { get; set; }
        [Column("END_TIME")]
        [StringLength(50)]
        public string EndTime { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdWeekhourNavigation")]
        public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
    }
}
