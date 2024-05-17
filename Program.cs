using KeyChecker;
using System.Drawing;
using static System.Formats.Asn1.AsnWriter;

var inputIsNotCorrect = true;
IKeyChecker userKey;

Console.WriteLine("Hello!");
do
{
    Console.WriteLine("Please input the name of key you would like to learn about below:");

    var userInput = Console.ReadLine();
    var userInputLower = userInput.ToLower();
    var userInputFormatted = userInputLower.Replace(" ", string.Empty);

    userKey = KeyFactory.GetKey(userInputFormatted);

    if (userKey.KeyName != "incorrect")
    {
        inputIsNotCorrect = false;
    }

} while (inputIsNotCorrect);

UserInterface.KeyInformation(userKey);

