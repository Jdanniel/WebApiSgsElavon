using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CALL_CENTER_Q1")]
    public partial class BdCallCenterQ1
    {
        [Key]
        [Column("ID_CUESTIONARIO_1")]
        public int IdCuestionario1 { get; set; }
        [Column("ID_CALL_CENTER")]
        public int? IdCallCenter { get; set; }
        [Column("Pregunta_1", TypeName = "text")]
        public string Pregunta1 { get; set; }
        [Column("Respuesta_1")]
        [StringLength(30)]
        public string Respuesta1 { get; set; }
        [Column("Valida_1")]
        public int? Valida1 { get; set; }
        [Column("Pregunta_2", TypeName = "text")]
        public string Pregunta2 { get; set; }
        [Column("REspuesta_2")]
        [StringLength(30)]
        public string Respuesta2 { get; set; }
        [Column("Valida_2")]
        public int? Valida2 { get; set; }
        [Column("Pregunta_3", TypeName = "text")]
        public string Pregunta3 { get; set; }
        [Column("Respuesta_3")]
        [StringLength(30)]
        public string Respuesta3 { get; set; }
        [Column("Valida_3")]
        public int? Valida3 { get; set; }
        [Column("Pregunta_4", TypeName = "text")]
        public string Pregunta4 { get; set; }
        [Column("Respuesta_4")]
        [StringLength(30)]
        public string Respuesta4 { get; set; }
        [Column("Valida_4")]
        public int? Valida4 { get; set; }
        [Column("Pregunta_5", TypeName = "text")]
        public string Pregunta5 { get; set; }
        [Column("Respuesta_5")]
        [StringLength(30)]
        public string Respuesta5 { get; set; }
        [Column("Valida_5")]
        public int? Valida5 { get; set; }
        [Column("Pregunta_6", TypeName = "text")]
        public string Pregunta6 { get; set; }
        [Column("Respuesta_6")]
        [StringLength(30)]
        public string Respuesta6 { get; set; }
        [Column("Valida_6")]
        public int? Valida6 { get; set; }
        [Column("Pregunta_7", TypeName = "text")]
        public string Pregunta7 { get; set; }
        [Column("Respuesta_7")]
        [StringLength(30)]
        public string Respuesta7 { get; set; }
        [Column("Valida_7")]
        public int? Valida7 { get; set; }
        [Column("Pregunta_8", TypeName = "text")]
        public string Pregunta8 { get; set; }
        [Column("Respuesta_8")]
        [StringLength(30)]
        public string Respuesta8 { get; set; }
        [Column("Valida_8")]
        public int? Valida8 { get; set; }
    }
}
