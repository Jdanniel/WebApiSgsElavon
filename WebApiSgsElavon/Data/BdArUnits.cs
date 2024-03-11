using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Data
{
    public partial class BdArUnits
    {
        public int? ArId { get; set; }
        public int ArUnitId { get; set; }
        public string NoSerie { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
    }
}
