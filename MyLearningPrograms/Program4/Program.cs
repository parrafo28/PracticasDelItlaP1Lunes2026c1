

using Program4;

DisplayHeader();

List<int> ids = new List<int>();
//List<string> names = new List<string>();
//List<string> emails = new List<string>();
//List<string> lastNames = new List<string>();
//List<int> ages = new List<int>();
//List<string> address = new List<string>();
//List<bool> favorites = new List<bool>();

Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, string> lastNames = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, string> address = new Dictionary<int, string>();
Dictionary<int, bool> favorites = new Dictionary<int, bool>();


var myClass = new Class1();
  
bool running = true;


while (running)
{
    Console.WriteLine("Please select an option (just the number): 1. Add contact, 2. Edit 3. Show contacts, 4. Search 5. Delete 6. Exit");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            {
                AddNewContact(ids, names, emails, lastNames, ages, address, favorites);
            }
            break;
        case 2:
            {
                EditCotnact(ids, names, emails, lastNames, ages, address, favorites);
            }
            break;
        case 3:
            {
                ShowAllContacts(ids, names, emails, lastNames, ages, address, favorites);
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

int GenerateId()
{
    return ids.Count + 1;
}

void AddNewContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails,
    Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address,
    Dictionary<int, bool> favorites)
{
    var id = GenerateId();
    ids.Add(id);

    Console.WriteLine("Please insert the name of the contact");
    var name = Console.ReadLine();
    names.Add(id, name);

    Console.WriteLine("Please insert the last name of the contact");
    lastNames.Add(id, Console.ReadLine());

    Console.WriteLine("Please insert the email of the contact");
    emails.Add(id, Console.ReadLine());

    Console.WriteLine("Please insert the age of the contact");
    ages.Add(id, Convert.ToInt32(Console.ReadLine()));

    Console.WriteLine("Please insert the address of the contact");
    address.Add(id, Console.ReadLine());

    Console.WriteLine("Is this contact a favorite? 1. yes /2. no (please type only the number)");
    //string favorite = Console.ReadLine();
    //var isFavorite = (favorite == "1") ? true : false;
    //var isFavorite = favorite == "1";
    //favorites.Add(isFavorite);
    favorites.Add(id,Console.ReadLine() == "1");
    //if (favorite == 1)
    //{
    //    favorites.Add(true);
    //}
    //else
    //{
    //    favorites.Add(false);
    //}
    Console.WriteLine("Contact added successfully");
}

static void EditCotnact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites)
{
    Console.WriteLine("Please insert the id of the contact you want to edit");
    int idToEdit = Convert.ToInt32(Console.ReadLine());

    //var index = idToEdit - 1; //ids.IndexOf(idToEdit);
    var idInList = ids.First(p => p == idToEdit);
    if (idInList != null)
    {
        var index = idInList - 1;
        Console.WriteLine($"Please insert the new name of the contact: {names[index]}");
        names[idInList - 1] = Console.ReadLine();

        Console.WriteLine("Please insert the new last name of the contact");
        lastNames[index] = Console.ReadLine();

        Console.WriteLine("Please insert the new email of the contact");
        emails[index] = Console.ReadLine();

        Console.WriteLine("Please insert the new age of the contact");
        ages[index] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please insert the new address of the contact");
        address[index] = Console.ReadLine();

        Console.WriteLine("Is this contact a favorite? 1. yes /2. no (please type only the number)");
        favorites[index] = Console.ReadLine() == "1";

        Console.WriteLine("Contact edited successfully");
    }
    else
    {
        Console.WriteLine("Contact not found");
    }
}

static void ShowContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites, int i)
{
    Console.WriteLine($"Id: {ids[i]}, Name: {names[i]}, Last Name: {lastNames[i]}, Email: {emails[i]}, Age: {ages[i]}, Address: {address[i]}, Favorite: {(favorites[i] ? "Yes" : "No")}");
}

static void ShowAllContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> emails, Dictionary<int, string> lastNames, Dictionary<int, int> ages, Dictionary<int, string> address, Dictionary<int, bool> favorites)
{
    Console.WriteLine("Contacts:");
    if (ids.Count == 0)
    {
        Console.WriteLine("No contacts found");
    }
    else
    {
        for (int i = 0; i < ids.Count; i++)
        {
            ShowContact(ids, names, emails, lastNames, ages, address, favorites, i);
        }
    }
}

var a = 5;
var b = 5;

var result = AddByValue(a, b);
var result2 = AddByValue(a, b);
var result3 = AddByValue(a, b);
var result4 = AddByValue(a, b);

var result5 = AddByRef(ref a, ref b);
var result6 = AddByRef(ref a, ref b);
var result7 = AddByRef(ref a, ref b);

static int AddByValue(int a, int b)
{
    a = a + 1;
    return a + b;
}

static int AddByRef(ref int a, ref int b)
{
    a = a + 1;
    return a + b;
}