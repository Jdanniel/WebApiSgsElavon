using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CservicesFailuresSendSuccessfulEmail
{
    public int Id { get; set; }

    public int? ServiceId { get; set; }

    public int? Failure { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserId { get; set; }
}
