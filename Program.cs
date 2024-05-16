using KeyChecker;
using System.Drawing;

Console.WriteLine("Hello! Please input the name of key you would like to learn about below:");

var userInput = Console.ReadLine();
var userInputLower = userInput.ToLower();
var userInputFormatted = userInputLower.Replace(" ", string.Empty);

IKeyChecker userKey = KeyFactory.GetKey(userInputFormatted);

userKey.GetUsersNeeds();
