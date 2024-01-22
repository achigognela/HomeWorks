// See https://aka.ms/new-console-template for more information

//task 1 

Console.WriteLine("Enter the size of the array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] inputArray = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    inputArray[i] = i + 1;
}


int[] evenArray = new int[arraySize];
int evenCount = 0;

int[] oddArray = new int[arraySize];
int oddCount = 0;

for (int i = 0; i < arraySize; i++)
{
    if (inputArray[i] % 2 == 0)
    {
        evenArray[evenCount] = inputArray[i];
        evenCount++;
    }
    else
    {
        oddArray[oddCount] = inputArray[i];
        oddCount++;
    }
}

Console.WriteLine("Array 1: ");
for (int i = 0; i < evenCount; i++)
{
    Console.WriteLine($"{evenArray[i]} ");
}


Console.WriteLine("Array 2: ");
for (int i = 0; i < oddCount; i++)
{
    Console.WriteLine($"{oddArray[i]} ");
}

Console.WriteLine();


//task 2
var contacts = new Dictionary<string, string>();

Console.WriteLine("Contacts Menu:");
Console.WriteLine("1. Add a contact");
Console.WriteLine("2. Delete a contact");
Console.WriteLine("3. Update a contact");
Console.WriteLine("4. Display all contacts");
Console.WriteLine("Enter your choice (Please use only number): ");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.Write("Enter the name: ");
        var name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists!");
        }
        else
        {
            Console.Write("Enter the phone number: ");
            var phoneNumber = Console.ReadLine();

            contacts.Add(name, phoneNumber);
            Console.WriteLine("Contact added successfully!");
        }
        break;
    case "2":
        Console.Write("Enter the name to delete: ");
        var deleteName = Console.ReadLine();

        if (contacts.ContainsKey(deleteName))
        {
            contacts.Remove(deleteName);
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
        break;
    case "3":
        Console.Write("Enter the name to update: ");
        var updateName = Console.ReadLine();

        if (contacts.ContainsKey(updateName))
        {
            Console.Write("Enter the new phone number: ");
            var newPhoneNumber = Console.ReadLine();

            contacts[updateName] = newPhoneNumber;
            Console.WriteLine("Contact updated successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
        break;
    case "4":
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
        }
        else
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter a valid option.");
        break;
}





//task 3, დაწერეთ პროგრამა რომელიც მასივში დათვლის თითოეული ელემენტის რაოდენობას და გამოიტანს მათ ჯამს.









//taks 4 (დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ n მონაწილის შედეგს)

Console.WriteLine("Enter the number of top participants to display: ");
int x = Convert.ToInt32(Console.ReadLine());

var scores = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

var topScore = (
    from score in scores
    orderby score descending
    select score
).Take(x);

Console.WriteLine($"Top {x} participants: ");

foreach (var score in topScore)
{
    Console.WriteLine($"{score} ");
}


