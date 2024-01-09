using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdLegalRepresentativeOnBase
{
    public int LegalRepresentativeOnBaseId { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Rfc { get; set; }

    public string Buc { get; set; }

    public string Email { get; set; }

    public string IdentifierDocumentNumber { get; set; }

    public long? Birthdate { get; set; }

    public string Street { get; set; }

    public string Number { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string RefPoint1 { get; set; }

    public string RefPoint2 { get; set; }

    public int? PhoneId { get; set; }

    public DateTime? CreateDate { get; set; }
}
