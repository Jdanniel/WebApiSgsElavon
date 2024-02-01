using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArArchivosCompress
{
    public int IdArArchivoCompress { get; set; }

    public int? IdArArchivoVarios { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecCompress { get; set; }

    public int? IsCompress { get; set; }
}
