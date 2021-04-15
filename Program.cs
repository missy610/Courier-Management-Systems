using System;
namespace CourierMangementSystem
{

    class Assignment
    {
        public static void Main() 
        {
           Console.WriteLine("Dream HB's Customer lists ");
           
           string firstName = "Missy Janelle";
           string lastName = "Tolosa";
           string contact = "09510655662";
           string customerAddress = "529.J.Basa St. Brgy. San Antonio , Binan, Laguna";
           string birthdate = "June 10,2001";
           string country = "Philippines";
           string state = "Manila";
           
           
           Console.Write("Enter Firstname: ");
           string firstNameInput = Console.ReadLine();
           
           
           if(firstNameInput == firstName)
           {
           	Console.WriteLine("Personal Information");
           	Console.WriteLine("First Name: " + firstName);
           	Console.WriteLine("Last Name: " + lastName);
           	Console.WriteLine("Contact No.: " + contact);
           	Console.WriteLine("Address: " + customerAddress);
           	Console.WriteLine("Birthdate: " + birthdate);
           	Console.WriteLine("Country: " + country);
           	Console.WriteLine("State: " + state);
           }else
           {
           	Console.WriteLine("Invalid Password.");
           }
        }     
    }
}
