using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_MOV_INVENTARIOS_LOG")]
    public partial class BdIngresoMovInventariosLog
    {
        [Column("ID_INGRESO_MOV_INVENTARIOS_LOG")]
        public int IdIngresoMovInventariosLog { get; set; }
        [Column("ODT")]
        public string Odt { get; set; }
        [Column("INSTALACION_NO_SERIE")]
        public string InstalacionNoSerie { get; set; }
        [Column("INSTALACION_MODELO")]
        public string InstalacionModelo { get; set; }
        [Column("CONECTIVIDAD_ENTRADA")]
        public string ConectividadEntrada { get; set; }
        [Column("APLICATIVO_ENTRADA")]
        public string AplicativoEntrada { get; set; }
        [Column("RETIRO_NO_SERIE")]
        public string RetiroNoSerie { get; set; }
        [Column("RETIRO_MODELO")]
        public string RetiroModelo { get; set; }
        [Column("CONECTIVIDAD_SALIDA")]
        public string ConectividadSalida { get; set; }
        [Column("APLICATIVO_SALIDA")]
        public string AplicativoSalida { get; set; }
        [Column("MARCA_MANTTO")]
        public string MarcaMantto { get; set; }
        [Column("MODELO_MANTTO")]
        public string ModeloMantto { get; set; }
        [Column("TECNOLOGIA_MANTTO")]
        public string TecnologiaMantto { get; set; }
        [Column("NO_SERIE_MANTTO")]
        public string NoSerieMantto { get; set; }
        [Column("BATERIA")]
        public string Bateria { get; set; }
        [Column("ELIMINADOR")]
        public string Eliminador { get; set; }
        [Column("BASE")]
        public string Base { get; set; }
        [Column("TAPA")]
        public string Tapa { get; set; }
        [Column("CABLE_AC")]
        public string CableAc { get; set; }
        [Column("ID_AR")]
        public string IdAr { get; set; }
        [Column("RETIRO_ID_UNIDAD")]
        public string RetiroIdUnidad { get; set; }
        [Column("INSTALACION_ID_UNIDAD")]
        public string InstalacionIdUnidad { get; set; }
        [Column("ID_INSTALACION_MODELO")]
        public string IdInstalacionModelo { get; set; }
        [Column("ID_RETIRO_MODELO")]
        public string IdRetiroModelo { get; set; }
        [Column("ID_CONECTIVIDAD_ENTRADA")]
        public string IdConectividadEntrada { get; set; }
        [Column("ID_CONECTIVIDAD_SALIDA")]
        public string IdConectividadSalida { get; set; }
        [Column("ID_APLICATIVO_ENTRADA")]
        public string IdAplicativoEntrada { get; set; }
        [Column("ID_APLICATIVO_SALIDA")]
        public string IdAplicativoSalida { get; set; }
        [Column("ID_BD_INGRESO_MOV_INVENTARIOS")]
        public int? IdBdIngresoMovInventarios { get; set; }
        [Column("idArchivo")]
        public int? IdArchivo { get; set; }
    }
}
