using CustomerDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Doe",
            MiddleName = "A.",
            BirthDate = new DateTime(1985, 4, 12),
            Email = "john.doe@example.com",
            PhoneNumbers = new System.Collections.Generic.List<PhoneNumber>
            {
                new PhoneNumber { PhoneNumberId = 1, Number = "123-456-7890" },
                new PhoneNumber { PhoneNumberId = 2, Number = "987-654-3210" }
            },
            Addresses = new System.Collections.Generic.List<CustomerAddress>
            {
                new CustomerAddress
                {
                    Address = new Address { AddressId = 1, FullAddress = "1234 Main St, Anytown, USA" }
                }
            },
            Likes = new System.Collections.Generic.List<CustomerLike>
            {
                new CustomerLike
                {
                    Like = new Like { LikeId = 1, Description = "Reading" }
                }
            }
        };
        DisplayCustomerData(customer);
    }

    static void DisplayCustomerData(Customer customer)
    {
        Console.WriteLine("Customer ID: " + customer.CustomerId);
        Console.WriteLine("Name: " + customer.FirstName + " " + (customer.MiddleName ?? "") + " " + customer.LastName);
        Console.WriteLine("Birth Date: " + customer.BirthDate.ToShortDateString());
        Console.WriteLine("Email: " + customer.Email);
        Console.WriteLine("Phone Numbers:");
        foreach (var phone in customer.PhoneNumbers)
        {
            Console.WriteLine(" - " + phone.Number);
        }
        Console.WriteLine("Addresses:");
        foreach (var address in customer.Addresses)
        {
            Console.WriteLine(" - " + address.Address.FullAddress);
        }
        Console.WriteLine("Likes:");
        foreach (var like in customer.Likes)
        {
            Console.WriteLine(" - " + like.Like.Description);
        }
    }
}