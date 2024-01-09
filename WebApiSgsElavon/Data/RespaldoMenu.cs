using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RespaldoMenu
{
    public int IdMenu { get; set; }

    public int? Nivel { get; set; }

    public int? IdParent { get; set; }

    public string DesMenu { get; set; }

    public string DesName { get; set; }

    public string Status { get; set; }

    public string Target { get; set; }

    public string Image { get; set; }

    public string Href { get; set; }

    public int? Orden { get; set; }

    public int? IsV2 { get; set; }

    public int? IsV3 { get; set; }

    public int? NivelV3 { get; set; }

    public int? IdParentV3 { get; set; }

    public string TargetV3 { get; set; }

    public string HrefV3 { get; set; }

    public int? OrdenV3 { get; set; }
}
