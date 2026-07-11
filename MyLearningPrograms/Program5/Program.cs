


using Program5.Models;
using Program5;

DisplayHeader();

List<Contact> contacts = new List<Contact>();
//List<int> ids = new List<int>();

//Dictionary<int, string> names = new Dictionary<int, string>();
//Dictionary<int, string> emails = new Dictionary<int, string>();
//Dictionary<int, string> lastNames = new Dictionary<int, string>();
//Dictionary<int, int> ages = new Dictionary<int, int>();
//Dictionary<int, string> address = new Dictionary<int, string>();
//Dictionary<int, bool> favorites = new Dictionary<int, bool>();

////var contact1 = new Program5.Contact();
//var contact1 = new Contact(1, "John", "Doe", "john.doe@example.com", 30, "123 Main St", true);
//var contact2 = new Contact(id: 1, name: "John", "Doe", "john.doe@example.com", 30, "123 Main St", true);

//var myClass = new Program4.ClasePrueba();

//var mywhateverclass = new ClaseWhatEver();
//myClass.MyProperty = 5;


////Console.WriteLine(contact1.GetId());
//contact1.Id = 1;
//Console.WriteLine(contact1.Id);
//contact1.Name = "John";
//contact1.LastName = "Doe";

//Console.WriteLine(contact1.Name);

//Console.WriteLine(contact1.GetFullName());

bool running = true;


while (running)
{
    Console.WriteLine("Please select an option (just the number): 1. Add contact, 2. Edit 3. Show contacts, 4. Search 5. Delete 6. Exit");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            {
                //AddNewContact(ids, names, emails, lastNames, ages, address, favorites);
                Contact.AddNewContact(contacts);
            }
            break;
        case 2:
            {
               // EditCotnact(contacts);
            }
            break;
        case 3:
            {
              //  ShowAllContacts(contacts);
            }
            break;
        case 4:
            {
                //search
            }
            break;
        case 5:
            {
                //delete
            }
            break;
        case 6:
            {
                running = false;
            }
            break;
    }

}


Console.WriteLine("Goodbye!");
Console.ReadKey();


void DisplayHeader()
{
    Console.WriteLine("Welcome to the Agenda");
    Console.WriteLine("---------------------");
}


// void AddNewContact//(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails,
////    Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address,
////    Dictionary<int, bool> favorites)
//(List<Contact> contacts)
//{
//    var id = GenerateId();

//    var contact1 = new Contact();

//    Console.WriteLine("Please insert the name of the contact");
//    var name = Console.ReadLine();
//    //names.Add(id, name);
//    contact1.Name = Console.ReadLine();

//    Console.WriteLine("Please insert the last name of the contact");
//    //lastNames.Add(id, Console.ReadLine());
//    var lastName = Console.ReadLine();

//    Console.WriteLine("Please insert the email of the contact");
//    //emails.Add(id, Console.ReadLine());
//    var email = Console.ReadLine();

//    Console.WriteLine("Please insert the age of the contact");
//    //ages.Add(id, Convert.ToInt32(Console.ReadLine()));
//    var age = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Please insert the address of the contact");
//    //address.Add(id, Console.ReadLine());
//    var address = Console.ReadLine();

//    Console.WriteLine("Is this contact a favorite? 1. yes /2. no (please type only the number)");
//    var isFavorite = Console.ReadLine() == "1";

//    //favorites.Add(id, Console.ReadLine() == "1");
   
//    contact1.Id = id;
//    contact1.Address = address;

//    var contact = new Contact
//    {
//        Id = id,
//        Name = name,
//        LastName = lastName,
//        Email = email,
//        Age = age,
//        Address = address,
//        IsFavorite = isFavorite
//    };
//    Console.WriteLine("Contact added successfully");
//}

//static void EditCotnact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites)
//{
//    Console.WriteLine("Please insert the id of the contact you want to edit");
//    int idToEdit = Convert.ToInt32(Console.ReadLine());

//    var idInList = ids.First(p => p == idToEdit);
//    if (idInList != null)
//    {
//        var index = idInList - 1;
//        Console.WriteLine($"Please insert the new name of the contact: {names[index]}");
//        names[idInList - 1] = Console.ReadLine();

//        Console.WriteLine("Please insert the new last name of the contact");
//        lastNames[index] = Console.ReadLine();

//        Console.WriteLine("Please insert the new email of the contact");
//        emails[index] = Console.ReadLine();

//        Console.WriteLine("Please insert the new age of the contact");
//        ages[index] = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Please insert the new address of the contact");
//        address[index] = Console.ReadLine();

//        Console.WriteLine("Is this contact a favorite? 1. yes /2. no (please type only the number)");
//        favorites[index] = Console.ReadLine() == "1";

//        Console.WriteLine("Contact edited successfully");
//    }
//    else
//    {
//        Console.WriteLine("Contact not found");
//    }
//}

//static void ShowContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites, int i)
//{
//    Console.WriteLine($"Id: {ids[i]}, Name: {names[i]}, Last Name: {lastNames[i]}, Email: {emails[i]}, Age: {ages[i]}, Address: {address[i]}, Favorite: {(favorites[i] ? "Yes" : "No")}");
//}

//static void ShowAllContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites)
//{
//    Console.WriteLine("Contacts:");
//    if (ids.Count == 0)
//    {
//        Console.WriteLine("No contacts found");
//    }
//    else
//    {
//        for (int i = 0; i < ids.Count; i++)
//        {
//            ShowContact(ids, names, emails, lastNames, ages, address, favorites, i);
//        }
//    }
//}



