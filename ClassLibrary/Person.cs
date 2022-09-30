using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
namespace ClassLibrary;

public class Person : IComparable
{
    public string? FirstName { get; init; }   
    public string? LastName { get; set; }
    public string? Address { get; set; }


    public Person(string? firstName, string? lastName, string? address)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public Person()
    {

    }

    public string ToCSV()
    {
        return " | " + $"First Name: {FirstName}" + " | " +
               $"Last Name: {LastName}  " + " | " +
               $"Address: {Address}" +  " | ";
    }

    public int CompareTo(object? obj)
    {
        Person compPerson = (Person)obj;
        return string.Compare(this.LastName, compPerson.LastName);
  
    }
}
