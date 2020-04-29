using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INFORMACION_UNIDAD_AR")]
    public partial class BdInformacionUnidadAr
    {
        [Key]
        [Column("ID_INFORMACION_UNIDAD_AR")]
        public int IdInformacionUnidadAr { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("INSTALACION_LLAVES")]
        public string InstalacionLlaves { get; set; }
        [Column("STATUS_INSTALACION_LLAVES")]
        public string StatusInstalacionLlaves { get; set; }
        [Column("NOMBRE_PERSONA_LLAVES_A")]
        public string NombrePersonaLlavesA { get; set; }
        [Column("NOMBRE_PERSONA_LLAVES_B")]
        public string NombrePersonaLlavesB { get; set; }
        [Column("TIPO_PW")]
        public string TipoPw { get; set; }
        [Column("TIPO_TECLADO")]
        public string TipoTeclado { get; set; }
        [Column("VERSION_TECLADO_EPP")]
        public string VersionTecladoEpp { get; set; }
        [Column("PROCESADOR")]
        public string Procesador { get; set; }
        [Column("VELOCIDAD_PROCESADOR")]
        public string VelocidadProcesador { get; set; }
        [Column("MEMORIA")]
        public string Memoria { get; set; }
        [Column("CAPACIDAD_DISCO_DURO")]
        public string CapacidadDiscoDuro { get; set; }
        [Column("MONITOR")]
        public string Monitor { get; set; }
        [Column("LECTOR_TARJETA")]
        public string LectorTarjeta { get; set; }
        [Column("TIPO_LLAVE")]
        public string TipoLlave { get; set; }
        [Column("APLICACION")]
        public string Aplicacion { get; set; }
        [Column("VERSION")]
        public string Version { get; set; }
    }
}
