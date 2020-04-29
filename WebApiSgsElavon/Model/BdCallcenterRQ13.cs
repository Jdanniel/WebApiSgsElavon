using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CALLCENTER_R_Q13")]
    public partial class BdCallcenterRQ13
    {
        [Key]
        [Column("ID_RESPUESTA_Q13")]
        public int IdRespuestaQ13 { get; set; }
        [Column("ID_CALL_CENTER_SEGUIMIENTO")]
        public int? IdCallCenterSeguimiento { get; set; }
        [Column("ATIENDE_LLAMADA")]
        [StringLength(100)]
        public string AtiendeLlamada { get; set; }
        [Column("RESPUESTA_1")]
        [StringLength(2)]
        public string Respuesta1 { get; set; }
        [Column("NOTA_1", TypeName = "text")]
        public string Nota1 { get; set; }
        [Column("COD_RECHAZO_1")]
        public int? CodRechazo1 { get; set; }
        [Column("RESPUESTA_2")]
        [StringLength(2)]
        public string Respuesta2 { get; set; }
        [Column("NOTA_2", TypeName = "text")]
        public string Nota2 { get; set; }
        [Column("COD_RECHAZO_2")]
        public int? CodRechazo2 { get; set; }
        [Column("RESPUESTA_3")]
        [StringLength(2)]
        public string Respuesta3 { get; set; }
        [Column("NOTA_3", TypeName = "text")]
        public string Nota3 { get; set; }
        [Column("COD_RECHAZO_3")]
        public int? CodRechazo3 { get; set; }
        [Column("RESPUESTA_4")]
        [StringLength(2)]
        public string Respuesta4 { get; set; }
        [Column("NOTA_4", TypeName = "text")]
        public string Nota4 { get; set; }
        [Column("COD_RECHAZO_4")]
        public int? CodRechazo4 { get; set; }
        [Column("RESPUESTA_5")]
        [StringLength(22)]
        public string Respuesta5 { get; set; }
        [Column("NOTA_5", TypeName = "text")]
        public string Nota5 { get; set; }
        [Column("COD_RECHAZO_5")]
        public int? CodRechazo5 { get; set; }
        [Column("RESPUESTA_6")]
        [StringLength(10)]
        public string Respuesta6 { get; set; }
        [Column("NOTA_6", TypeName = "text")]
        public string Nota6 { get; set; }
        [Column("RESPUESTA_7")]
        [StringLength(2)]
        public string Respuesta7 { get; set; }
        [Column("HORARIO_CITA", TypeName = "datetime")]
        public DateTime? HorarioCita { get; set; }
        [Column("NOTA_7", TypeName = "text")]
        public string Nota7 { get; set; }
        [Column("COD_RECHAZO_7")]
        public int? CodRechazo7 { get; set; }
        [Column("RESPUESTA_8")]
        [StringLength(2)]
        public string Respuesta8 { get; set; }
        [Column("NOTA_8", TypeName = "text")]
        public string Nota8 { get; set; }
        [Column("RESPUESTA_9")]
        [StringLength(22)]
        public string Respuesta9 { get; set; }
        [Column("NOTA_9", TypeName = "text")]
        public string Nota9 { get; set; }
        [Column("COD_RECHAZO_9")]
        public int? CodRechazo9 { get; set; }
        [Column("RESPUESTA_10")]
        [StringLength(22)]
        public string Respuesta10 { get; set; }
        [Column("NOTA_10", TypeName = "text")]
        public string Nota10 { get; set; }
        [Column("COD_RECHAZO_10")]
        public int? CodRechazo10 { get; set; }
        [Column("RESPUESTA_11")]
        [StringLength(22)]
        public string Respuesta11 { get; set; }
        [Column("NOTA_11", TypeName = "text")]
        public string Nota11 { get; set; }
        [Column("COD_RECHAZO_11")]
        public int? CodRechazo11 { get; set; }
        [Column("RESPUESTA_12")]
        [StringLength(22)]
        public string Respuesta12 { get; set; }
        [Column("NOTA_12", TypeName = "text")]
        public string Nota12 { get; set; }
        [Column("RESPUESTA_13")]
        [StringLength(22)]
        public string Respuesta13 { get; set; }
        [Column("NOTA_13", TypeName = "text")]
        public string Nota13 { get; set; }
        [Column("COD_RECHAZO_13")]
        public int? CodRechazo13 { get; set; }
        [Column("RESPUESTA_14")]
        [StringLength(22)]
        public string Respuesta14 { get; set; }
        [Column("NOTA_14", TypeName = "text")]
        public string Nota14 { get; set; }
        [Column("COD_RECHAZO_14")]
        public int? CodRechazo14 { get; set; }
        [Column("RESPUESTA_15")]
        [StringLength(22)]
        public string Respuesta15 { get; set; }
        [Column("NOTA_15", TypeName = "text")]
        public string Nota15 { get; set; }
        [Column("COD_RECHAZO_15")]
        public int? CodRechazo15 { get; set; }
        [Column("RESPUESTA_16")]
        [StringLength(22)]
        public string Respuesta16 { get; set; }
        [Column("NOTA_16", TypeName = "text")]
        public string Nota16 { get; set; }
        [Column("COD_RECHAZO_16")]
        public int? CodRechazo16 { get; set; }
        [Column("RESPUESTA_17")]
        [StringLength(22)]
        public string Respuesta17 { get; set; }
        [Column("NOTA_17", TypeName = "text")]
        public string Nota17 { get; set; }
        [Column("COD_RECHAZO_17")]
        public int? CodRechazo17 { get; set; }
        [Column("RESPUESTA_18")]
        [StringLength(22)]
        public string Respuesta18 { get; set; }
        [Column("NOTA_18", TypeName = "text")]
        public string Nota18 { get; set; }
        [Column("COD_RECHAZO_18")]
        public int? CodRechazo18 { get; set; }
        [Column("RESPUESTA_19")]
        [StringLength(22)]
        public string Respuesta19 { get; set; }
        [Column("NOTA_19", TypeName = "text")]
        public string Nota19 { get; set; }
        [Column("COD_RECHAZO_19")]
        public int? CodRechazo19 { get; set; }
        [Column("RESPUESTA_20")]
        [StringLength(22)]
        public string Respuesta20 { get; set; }
        [Column("NOTA_20", TypeName = "text")]
        public string Nota20 { get; set; }
        [Column("COD_RECHAZO_20")]
        public int? CodRechazo20 { get; set; }
        [Column("RESPUESTA_21")]
        [StringLength(22)]
        public string Respuesta21 { get; set; }
        [Column("NOTA_21", TypeName = "text")]
        public string Nota21 { get; set; }
        [Column("COD_RECHAZO_21")]
        public int? CodRechazo21 { get; set; }
        [Column("RESPUESTA_22")]
        [StringLength(22)]
        public string Respuesta22 { get; set; }
        [Column("NOTA_22", TypeName = "text")]
        public string Nota22 { get; set; }
        [Column("COD_RECHAZO_22")]
        public int? CodRechazo22 { get; set; }
        [Column("RESPUESTA_23")]
        [StringLength(22)]
        public string Respuesta23 { get; set; }
        [Column("NOTA_23", TypeName = "text")]
        public string Nota23 { get; set; }
        [Column("COD_RECHAZO_23")]
        public int? CodRechazo23 { get; set; }
        [Column("ID_LLAMADA_CONTACTO")]
        [StringLength(100)]
        public string IdLlamadaContacto { get; set; }
        [Column("ID_LLAMADA_ELAVON")]
        [StringLength(100)]
        public string IdLlamadaElavon { get; set; }
        [Column("NOMBRE_ATENDERA_SERVICIO")]
        [StringLength(100)]
        public string NombreAtenderaServicio { get; set; }
        [Column("TELEFONO_ATENDERA_SERVICIO")]
        [StringLength(10)]
        public string TelefonoAtenderaServicio { get; set; }
        [Column("FEC_CREACION", TypeName = "datetime")]
        public DateTime? FecCreacion { get; set; }
    }
}
