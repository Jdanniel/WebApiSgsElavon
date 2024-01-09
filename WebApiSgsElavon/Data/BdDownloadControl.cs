using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdDownloadControl
{
    public int Id { get; set; }

    public string DownloadDesc { get; set; }

    public string ParametersJson { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    public DateTime? SendDate { get; set; }
}
