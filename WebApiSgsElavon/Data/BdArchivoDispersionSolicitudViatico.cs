using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArchivoDispersionSolicitudViatico
{
    public int IdArchivoDispersionSolicitudViaticos { get; set; }

    public int IdArchivoDispersion { get; set; }

    public int IdSolicitudViaticos { get; set; }

    public string Status { get; set; }

    public virtual BdArchivosDispersion IdArchivoDispersionNavigation { get; set; }

    public virtual BdSolicitudesViatico IdSolicitudViaticosNavigation { get; set; }
}
