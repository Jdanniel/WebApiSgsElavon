using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArLogWsSalesforce
{
    public int IdArLogWsSalesforce { get; set; }

    public string NoAr { get; set; }

    public string Estatus { get; set; }

    public string Error { get; set; }

    public DateTime? FecAlta { get; set; }
}
