using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSolicitudViaticosConceptosPaso
{
    public int? UsuarioSolicitante { get; set; }

    public int? Cliente { get; set; }

    public int? Motivo { get; set; }

    public string NoAr { get; set; }

    public string Destino { get; set; }

    public string Pasaje { get; set; }

    public string Hospedaje { get; set; }

    public string Alimentos { get; set; }

    public string Taxi { get; set; }

    public string Papeleria { get; set; }

    public string Casetas { get; set; }

    public string Capacitacion { get; set; }

    public string Paqueteria { get; set; }

    public string CompraDeMateriales { get; set; }

    public string Estacionamiento { get; set; }

    public string Telefono { get; set; }

    public string Gasolina { get; set; }

    public string Aviones { get; set; }

    public string Taxilotesa { get; set; }

    public string Cerrajeros { get; set; }

    public string MantenimientoAutomovil { get; set; }

    public string MantenimientoMotocicletas { get; set; }

    public string TaxiUber { get; set; }

    public string KilometrosPasaje { get; set; }

    public string KilometrosTaxi { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaLiberacion { get; set; }
}
