using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArPdf
{
    public int IdPdfAr { get; set; }

    public DateTime FecCarga { get; set; }

    public string FileName { get; set; }

    public int Estatus { get; set; }

    public int IdCarga { get; set; }
}
