using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CinterfaceUser
{
    public int InterfaceUserId { get; set; }

    public string UserName { get; set; }

    public int? UserIdRegistered { get; set; }

    public string PasswordHash { get; set; }

    public string Salt { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public int? AccessFailedCount { get; set; }

    public string Status { get; set; }
}
