using Addressbook_DAY23_UC4;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Addressbook_DAY23_UC4
{
    class Create_Contact
    {//create a contact
        class Contact
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string permanentaddress { get; set; }
            public string state { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string zipCode { get; set; }
        }
        //add contact to list
        List<Contact> book = new List<Contact>();
        public void AddDetails()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter the First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the permanentaddress");
            contact.permanentaddress = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter the Zip Code");
            contact.zipCode = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            contact.email = Console.ReadLine();
            book.Add(contact);//add data of contact in list
        }
        public void Display()      //contact data display
        {
            foreach (var data in book)
            {
                int i = 1;
                Console.WriteLine("Contact No:{0}", i);
                if (book.Contains(data))
                    Console.WriteLine("*************Contact Details****************");
                Console.WriteLine($"Name of person : {data.firstName} {data.lastName}");
                Console.WriteLine($"Address of person is : {data.permanentaddress}");
                Console.WriteLine($"State : {data.state}");
                Console.WriteLine($"Zip : {data.zipCode}");
                Console.WriteLine($"Email of person : {data.email}");
                Console.WriteLine($"Phone Number of person : {data.phoneNumber}");
                i++;
            }


        }


        public void Edit()
        {
            Console.WriteLine("Enter the name of contact do you want to edit : ");
            string nameinput = Convert.ToString(Console.ReadLine());
            foreach (var data in book)
            {
                if (data.firstName == nameinput || data.lastName == nameinput)
                {
                    Console.WriteLine("choose the option to change the data : \n1) firstName\n2)lastName\n3)address\n4)City\n5)State\n6)Zip\n7)Email\n8)Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first name : ");
                            string FirstName = Convert.ToString(Console.ReadLine());
                            data.firstName = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the last name : ");
                            string LastName = Convert.ToString(Console.ReadLine());
                            data.lastName = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Address : ");
                            string Address = Convert.ToString(Console.ReadLine());
                            data.permanentaddress = Address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter the state : ");
                            string State = Convert.ToString(Console.ReadLine());
                            data.state = State;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the zip Code : ");
                            string ZipCode = Convert.ToString(Console.ReadLine());
                            data.zipCode = ZipCode;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the email : ");
                            string Email = Convert.ToString(Console.ReadLine());
                            data.email = Email;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Convert.ToString(Console.ReadLine());
                            data.phoneNumber = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("please choose from above options :");
                            break;
                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine($"Contact not found{nameinput}");
                }

            }




        }
        public void RemoveDetails()
        {
            Console.Write("Enter The Name Of Contact You Have To Delete:");
            string nameinput = Console.ReadLine();
            foreach (var data in book)
            {
                if (data.firstName == nameinput)
                {
                    book.Remove(data);
                    Console.WriteLine("Contact Deleted SuccessFully");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }
            
        }

    }
    class prog
    {
        public static void Main(String[] args)
        {
            Create_Contact AddressBook = new Create_Contact();
            AddressBook.AddDetails();
            AddressBook.Display();
            AddressBook.RemoveDetails();
            AddressBook.Display();



        }

    }

}





