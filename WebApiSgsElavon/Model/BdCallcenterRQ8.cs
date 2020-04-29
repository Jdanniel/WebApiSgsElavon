using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CALLCENTER_R_Q8")]
    public partial class BdCallcenterRQ8
    {
        [Key]
        [Column("ID_RESPUESTA_Q8")]
        public int IdRespuestaQ8 { get; set; }
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
        [Column("RESPUESTA_24")]
        [StringLength(22)]
        public string Respuesta24 { get; set; }
        [Column("NOTA_24", TypeName = "text")]
        public string Nota24 { get; set; }
        [Column("COD_RECHAZO_24")]
        public int? CodRechazo24 { get; set; }
        [Column("RESPUESTA_25")]
        [StringLength(22)]
        public string Respuesta25 { get; set; }
        [Column("NOTA_25", TypeName = "text")]
        public string Nota25 { get; set; }
        [Column("COD_RECHAZO_25")]
        public int? CodRechazo25 { get; set; }
        [Column("RESPUESTA_26")]
        [StringLength(22)]
        public string Respuesta26 { get; set; }
        [Column("NOTA_26", TypeName = "text")]
        public string Nota26 { get; set; }
        [Column("COD_RECHAZO_26")]
        public int? CodRechazo26 { get; set; }
        [Column("RESPUESTA_27")]
        [StringLength(22)]
        public string Respuesta27 { get; set; }
        [Column("NOTA_27", TypeName = "text")]
        public string Nota27 { get; set; }
        [Column("COD_RECHAZO_27")]
        public int? CodRechazo27 { get; set; }
        [Column("RESPUESTA_28")]
        [StringLength(22)]
        public string Respuesta28 { get; set; }
        [Column("NOTA_28", TypeName = "text")]
        public string Nota28 { get; set; }
        [Column("COD_RECHAZO_28")]
        public int? CodRechazo28 { get; set; }
        [Column("RESPUESTA_29")]
        [StringLength(22)]
        public string Respuesta29 { get; set; }
        [Column("NOTA_29", TypeName = "text")]
        public string Nota29 { get; set; }
        [Column("COD_RECHAZO_29")]
        public int? CodRechazo29 { get; set; }
        [Column("RESPUESTA_30")]
        [StringLength(22)]
        public string Respuesta30 { get; set; }
        [Column("NOTA_30", TypeName = "text")]
        public string Nota30 { get; set; }
        [Column("COD_RECHAZO_30")]
        public int? CodRechazo30 { get; set; }
        [Column("RESPUESTA_31")]
        [StringLength(22)]
        public string Respuesta31 { get; set; }
        [Column("NOTA_31", TypeName = "text")]
        public string Nota31 { get; set; }
        [Column("COD_RECHAZO_31")]
        public int? CodRechazo31 { get; set; }
        [Column("RESPUESTA_32")]
        [StringLength(22)]
        public string Respuesta32 { get; set; }
        [Column("NOTA_32", TypeName = "text")]
        public string Nota32 { get; set; }
        [Column("COD_RECHAZO_32")]
        public int? CodRechazo32 { get; set; }
        [Column("RESPUESTA_33")]
        [StringLength(22)]
        public string Respuesta33 { get; set; }
        [Column("NOTA_33", TypeName = "text")]
        public string Nota33 { get; set; }
        [Column("COD_RECHAZO_33")]
        public int? CodRechazo33 { get; set; }
        [Column("RESPUESTA_34")]
        [StringLength(22)]
        public string Respuesta34 { get; set; }
        [Column("NOTA_34", TypeName = "text")]
        public string Nota34 { get; set; }
        [Column("COD_RECHAZO_34")]
        public int? CodRechazo34 { get; set; }
        [Column("RESPUESTA_35")]
        [StringLength(22)]
        public string Respuesta35 { get; set; }
        [Column("NOTA_35", TypeName = "text")]
        public string Nota35 { get; set; }
        [Column("COD_RECHAZO_35")]
        public int? CodRechazo35 { get; set; }
        [Column("RESPUESTA_36")]
        [StringLength(22)]
        public string Respuesta36 { get; set; }
        [Column("NOTA_36", TypeName = "text")]
        public string Nota36 { get; set; }
        [Column("COD_RECHAZO_36")]
        public int? CodRechazo36 { get; set; }
        [Column("RESPUESTA_37")]
        [StringLength(22)]
        public string Respuesta37 { get; set; }
        [Column("NOTA_37", TypeName = "text")]
        public string Nota37 { get; set; }
        [Column("COD_RECHAZO_37")]
        public int? CodRechazo37 { get; set; }
        [Column("RESPUESTA_38")]
        [StringLength(22)]
        public string Respuesta38 { get; set; }
        [Column("NOTA_38", TypeName = "text")]
        public string Nota38 { get; set; }
        [Column("COD_RECHAZO_38")]
        public int? CodRechazo38 { get; set; }
        [Column("RESPUESTA_39")]
        [StringLength(22)]
        public string Respuesta39 { get; set; }
        [Column("NOTA_39", TypeName = "text")]
        public string Nota39 { get; set; }
        [Column("COD_RECHAZO_39")]
        public int? CodRechazo39 { get; set; }
        [Column("RESPUESTA_40")]
        [StringLength(22)]
        public string Respuesta40 { get; set; }
        [Column("NOTA_40", TypeName = "text")]
        public string Nota40 { get; set; }
        [Column("COD_RECHAZO_40")]
        public int? CodRechazo40 { get; set; }
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
        [Column("RESPUESTA_41")]
        [StringLength(22)]
        public string Respuesta41 { get; set; }
        [Column("NOTA_41", TypeName = "text")]
        public string Nota41 { get; set; }
        [Column("RESPUESTA_42")]
        [StringLength(22)]
        public string Respuesta42 { get; set; }
        [Column("NOTA_42", TypeName = "text")]
        public string Nota42 { get; set; }
        [Column("RESPUESTA_43")]
        [StringLength(22)]
        public string Respuesta43 { get; set; }
        [Column("NOTA_43", TypeName = "text")]
        public string Nota43 { get; set; }
        [Column("RESPUESTA_44")]
        [StringLength(22)]
        public string Respuesta44 { get; set; }
        [Column("NOTA_44", TypeName = "text")]
        public string Nota44 { get; set; }
        [Column("RESPUESTA_45")]
        [StringLength(22)]
        public string Respuesta45 { get; set; }
        [Column("NOTA_45", TypeName = "text")]
        public string Nota45 { get; set; }
    }
}
