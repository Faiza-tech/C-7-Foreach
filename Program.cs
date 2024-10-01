// Implement the foreach statement

//Looping through an array using foreach
//The foreach statement provides a simple, clean way to iterate through the elements of an array. The foreach statement processes array elements in increasing index order, starting with index 0 and ending with index Length - 1.

string[] namOfPersons = ["Hani", "Gohr", "Soniya"];
foreach (string person in namOfPersons)
{
    Console.WriteLine(person);
}


Console.WriteLine("*************************");Console.WriteLine("");


string[] names = ["Sara", "Zoha", "Rania", "Dua", "Sania", "Zara"];
foreach (string name in names)
{
    if (name.StartsWith("S"))
    {
        Console.WriteLine("Name start with S is:" + name);
    }
}


Console.WriteLine("*************************");Console.WriteLine("");
//Create and initialize an array of int
int[] inventory = { 200, 450, 700, 175, 250 };
foreach (int Item in inventory)
{
    Console.WriteLine(Item);
}


Console.WriteLine("*************************");Console.WriteLine("");
//Add a variable to sum the value of each element in the array of inventory
/*int[] inventorys = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int Items in inventorys){
    Console.WriteLine($"items in inventory:{Items}");
    sum += Items;
}
Console.WriteLine($"We have {sum} items in inventory.");*/


Console.WriteLine("*************************");Console.WriteLine("");
//Create a variable to hold the current bin number and display the running total


int[] invent = { 200, 450, 700, 175, 250 };// Create an array to hold inventory amounts
int sums = 0; // Variable to hold the running total of items
int bin = 0;  // Variable to hold the current bin number

// Iterate over each item in the inventory
foreach (int items in invent)
{
    sums += items; // Add current items to the running total
    bin++; // Increment the bin number
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sums})");
}

// Display the final total of items in inventory
Console.WriteLine($"We have {sums} items in inventory.");



Console.WriteLine("*************************"); Console.WriteLine("");
//challenge activity for nested iteration and selection statements

string[] FraudIDs = ["B123", "C234", "A345", "C15","B177","G3003","C235","B179"];

foreach(string numberOfFraud in FraudIDs){
    if( numberOfFraud.StartsWith("B")){
        Console.WriteLine($"Id start with \"B\" are: {numberOfFraud}");
    }
}







