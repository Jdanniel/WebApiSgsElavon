﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArReasignacionLog
{
    public int IdCarga { get; set; }

    public int IdCliente { get; set; }

    public string NoAr { get; set; }

    public string Concepto { get; set; }

    public string DescCorta { get; set; }

    public string Sintoma { get; set; }

    public string Bitacora { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string DescNegocio { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string NotasRemedy { get; set; }

    public string Equipo { get; set; }

    public string DescEquipo { get; set; }

    public int? Segmento { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime FecConvenio { get; set; }

    public int TipoServicio { get; set; }

    public int TipoFalla { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? HorasGarantia { get; set; }

    public decimal? PrecioExito { get; set; }

    public string Precio { get; set; }

    public int? IdNegocio { get; set; }

    public int? IdEstado { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdTipoPlaza { get; set; }

    public int? IdPlaza { get; set; }

    public int? IdTecnico { get; set; }

    public int? IsTecnicoForaneo { get; set; }

    public int? IsDuplicada { get; set; }

    public int? IsIngresoManual { get; set; }

    public int? IsActualizacion { get; set; }

    public int? IsInstalacion { get; set; }

    public int? IsSustitucion { get; set; }

    public int? IsRetiro { get; set; }

    public DateTime FecAlta { get; set; }

    public int? FecCierre { get; set; }

    public int? MinsDowntime { get; set; }

    public int? IsExito { get; set; }

    public int? IdProducto { get; set; }

    public int? IdTipoServicio { get; set; }

    public int? IdTipoPrecio { get; set; }

    public int? IdMoneda { get; set; }

    public int? IdTipoCobro { get; set; }

    public int? IsCobrable { get; set; }

    public int IdStatusAr { get; set; }

    public DateTime FecStatusAr { get; set; }

    public int? IsFollowDispatch { get; set; }

    public int? NoReincidencias { get; set; }

    public int? IsProgramado { get; set; }

    public int? NoDiasLiberacion { get; set; }

    public string Responsable { get; set; }

    public string Status { get; set; }

    public int? VoltajeTierraNeutro { get; set; }

    public int? IdTipoEquipo { get; set; }

    public string CorreoEjecutivo { get; set; }

    public string TelefonoComercio { get; set; }

    public string PersonaAtenderaComercio { get; set; }

    public string ProveedorAtenderaComercio { get; set; }

    public TimeOnly? HoraAtencionIni { get; set; }

    public TimeOnly? HoraAtencionFin { get; set; }

    public int TerminalAmex { get; set; }

    public int? AgregarDiasAtencion { get; set; }

    public string DireccionAlternaComercio { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdProyecto { get; set; }

    public int? Insumos { get; set; }

    public long? FolioTelecarga { get; set; }

    public string Caja { get; set; }

    public int? IdModeloReq { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdEquipoCliente { get; set; }

    public int? Rs { get; set; }

    public int? IdArOriginal { get; set; }
}
