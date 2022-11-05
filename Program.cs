namespace Addressbook_DAY23_UC1
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
        //intialize contact to list
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
                Console.WriteLine("Contact No:{0}" ,i);
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
        
    }
    class prog
    {
        public static void Main(String[] args)
        {
            Create_Contact AddressBook = new Create_Contact();
            AddressBook.AddDetails();
            AddressBook.Display();
            Console.ReadLine();
        }
    }




}



