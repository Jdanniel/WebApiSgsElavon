using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArReasonInventoried
{
    public int Id { get; set; }

    public int? IdAr { get; set; }

    public int? IdReasonInventoried { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? TypeMov { get; set; }

    public int? Authorized { get; set; }
}
