using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdWorkload
{
    public int IdWorkload { get; set; }

    public string SpidUno { get; set; }

    public string Status { get; set; }

    public string Login { get; set; }

    public string HostName { get; set; }

    public string BlkBy { get; set; }

    public string Dbname { get; set; }

    public string Command { get; set; }

    public string Cputime { get; set; }

    public string DiskIo { get; set; }

    public string LastBatch { get; set; }

    public string ProgramName { get; set; }

    public string Spid { get; set; }

    public string Requestid { get; set; }

    public DateTime? FecAlta { get; set; }
}
