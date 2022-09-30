namespace ClassLibrary;

public class Address
{
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }

    public Address()
    {

    }

    public Address(string? streetAddress, string city, string state, string zipCode)
    {
       StreetAddress = streetAddress;
       City = city;
       State = state;
       ZipCode = zipCode;

    }
}
