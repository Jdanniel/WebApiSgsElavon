using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CdosysmailFailure
{
    public DateTime? DateOfFailure { get; set; }

    public int? Spid { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }

    public int? IMsg { get; set; }

    public int? Hr { get; set; }

    public string SourceOfFailure { get; set; }

    public string DescriptionOfFailure { get; set; }

    public string OutputFromFailure { get; set; }

    public string CommentAboutFailure { get; set; }
}
