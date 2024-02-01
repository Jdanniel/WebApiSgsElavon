using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSellerOnBase
{
    public int SellerOnBaseId { get; set; }

    public string Name { get; set; }

    public string ReceiptName { get; set; }

    public string Amcc { get; set; }

    public string Mcc { get; set; }

    public string AccountNumber { get; set; }

    public string Currency { get; set; }

    public long? TotalMonthlyIncome { get; set; }

    public long? MonthlyIncomeDigitalPayment { get; set; }

    public long? AverageTicket { get; set; }

    public string Street { get; set; }

    public string Number { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string RefPoint1 { get; set; }

    public string RefPoint2 { get; set; }

    public string OpenHour { get; set; }

    public string CloseHour { get; set; }

    public int? PhoneId { get; set; }

    public DateTime? CreateDate { get; set; }
}
