Console.WriteLine("What is your favorite flavor of ice cream?");
string? favorite = Console.ReadLine();
if(favorite == null)
{
    favorite = "Vanilla";
}
if(favorite == "vanilla");
{
    Console.WriteLine("Your basic");
}
else
{
    Console.WriteLine("Thats fruity")

}
Console.WriteLine($"Your favorite flavor is {favorite}.")
