using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOGIN_USERS")]
    public partial class BdLoginUsers
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Username { get; set; }
        [StringLength(250)]
        public string Password { get; set; }
        [StringLength(50)]
        public string IpAddress { get; set; }
        [StringLength(250)]
        public string UserAgent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(255)]
        public string IpMachine { get; set; }
    }
}
