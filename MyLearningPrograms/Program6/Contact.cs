using Program6;
using System.Net.NetworkInformation;

namespace Program5
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool IsFavorite { get; set; }

         
        public void SetName(string name)
        {
            this.Name = name;
        }
           public string GetFullName() => $"{Name} {LastName}";
        public string IsFavoriteString()
        { 
            return IsFavorite ? "Yes" : "No";
        }
        

        public static void AddNewContact(List<Contact> contacts)
        {
            var context = new DataContext();
            string name; string lastName; string email; int age; string address; bool isFavorite;

            Console.WriteLine("Please insert the name of the contact");
            name = Console.ReadLine();

            Console.WriteLine("Please insert the last name of the contact");
            lastName = Console.ReadLine();

            Console.WriteLine("Please insert the email of the contact");
            email = Console.ReadLine();

            Console.WriteLine("Please insert the age of the contact");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert the address of the contact");
            address = Console.ReadLine();

            Console.WriteLine("Is this contact a favorite? 1. yes /2. no (please type only the number)");
            isFavorite = Console.ReadLine() == "1";

            
            var contact = CreateContact(  name, lastName, email, age, address, isFavorite);
           
            context.Contacts.Add(contact);
             context.SaveChanges();
        }
         
       
        public static Contact CreateContact(  string name, string lastName, string email, int age, string address, bool isFavorite)
        {
            return new Contact
            {
                Id = 0,
                Name = name,
                LastName = lastName,
                Email = email,
                Age = age,
                Address = address,
                IsFavorite = isFavorite
            };
        }
        public static Contact CreateContact(int id, string name, string lastName, string email, int age, string address, string isFavorite)
        {
            return new Contact
            {
                Id = id,
                Name = name,
                LastName = lastName,
                Email = email,
                Age = age,
                Address = address,
                IsFavorite = isFavorite == "1"? true : false
            };
        }
        public static int GenerateId(List<Contact> contacts)
        {
            return contacts.Count + 1;
        }

        public static List<Contact> GetContactsByParameter(List<Contact> contacts, string searchCriteria)
        {
                     return contacts.Where(c => c.Name == searchCriteria || c.LastName.ToLower().Contains(searchCriteria.ToLower()) || c.Email.Contains(searchCriteria)).ToList();
        }

    }
}
