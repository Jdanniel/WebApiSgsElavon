using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_WEEK_DAYS")]
    public partial class CWeekDays
    {
        [Key]
        [Column("ID_WEEK_DAYS")]
        public int IdWeekDays { get; set; }
        [Column("WEEK_DAY")]
        [StringLength(15)]
        public string WeekDay { get; set; }
    }
}
