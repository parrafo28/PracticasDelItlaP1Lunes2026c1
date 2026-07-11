


using Program5;
using Program6;

DisplayHeader();

var context = new DataContext();
List<Contact> contacts = new List<Contact>();
contacts = context.Contacts.Where(p => p.IsFavorite).ToList();

bool running = true;


while (running)
{
    Console.WriteLine("Please select an option (just the number): 1. Add contact, 2. Edit 3. Show contacts, 4. Search 5. Delete 6. Exit");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            {
                Contact.AddNewContact(contacts);
                contacts = context.Contacts.ToList();
                ShowallContacts(context); 
            }
            break;
        case 2:
            {
            }
            break;
        case 3:
            {
                ShowallContacts(context);
            }
            break;
        case 4:
            {
            }
            break;
        case 5:
            {
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

static void ShowallContacts(DataContext context)
{
    context.Contacts.ToList().ForEach(contact =>
    {
        Console.WriteLine($"Id: {contact.Id}, Name: {contact.GetFullName()}, Email: {contact.Email}, Age: {contact.Age}, Address: {contact.Address}, IsFavorite: {contact.IsFavoriteString()}");
    });
}