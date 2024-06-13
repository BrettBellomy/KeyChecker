using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public static class UserInterface
    {
        public static void KeyInformation(IKeyChecker key)
        {
            string userResponseLower;

            Console.WriteLine($"What would you like to know about the key of {key.KeyName}?");
            do
            { 
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine();
                Console.WriteLine("1: Key Signature");
                Console.WriteLine("2: Scale");
                Console.WriteLine("3: Chords");
                Console.WriteLine("4: Related Keys");
                Console.WriteLine();
                Console.WriteLine("Or type 'Exit' to exit application");
                var userResponse = Console.ReadLine();
                userResponseLower = userResponse.ToLower();

                switch (userResponseLower)
                {
                    case "1":
                    case "1 key signature":
                    case "key signature":
                    case "1: key signature":
                        if (key.KeySignatureFlats == 1 && key.KeySignatureSharps == 0)
                        {
                            Console.WriteLine($"The key signature of {key.KeyName} has {key.KeySignatureFlats} flat");
                            Console.WriteLine();
                        }
                        if (key.KeySignatureSharps == 1 && key.KeySignatureFlats == 0)
                        {
                            Console.WriteLine($"The key signature of {key.KeyName} has {key.KeySignatureSharps} sharp");
                            Console.WriteLine();
                        }
                        else if (key.KeySignatureFlats == 0)
                        {
                            Console.WriteLine($"The key signature of {key.KeyName} has {key.KeySignatureSharps} sharps");
                            Console.WriteLine();
                        }
                        else if (key.KeySignatureSharps == 0)
                        {
                            Console.WriteLine($"The key signature of {key.KeyName} has {key.KeySignatureFlats} flats");
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                    case "2 scale":
                    case "scale":
                    case "2: scale":
                        Console.WriteLine($"The scale of {key.KeyName} is {key.Scale}");
                        Console.WriteLine();
                        break;

                    case "3":
                    case "3 chords":
                    case "chords":
                    case "3: chords":
                        Console.WriteLine($"The chords in the key of {key.KeyName} are:");
                        Console.WriteLine(key.OneChord);
                        Console.WriteLine(key.TwoChord);
                        Console.WriteLine(key.ThreeChord);
                        Console.WriteLine(key.FourChord);
                        Console.WriteLine(key.FiveChord);
                        Console.WriteLine(key.SixChord);
                        Console.WriteLine(key.SevenChord);
                        Console.WriteLine();
                        break;

                    case "4":
                    case "4 related keys":
                    case "related keys":
                    case "4: related keys":
                        Console.WriteLine($"The relative key for {key.KeyName} is {key.RelativeKey} and the parallel key is {key.ParallelKey}");
                        Console.WriteLine();
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for using our application!");
                        break;
                    default:
                        Console.WriteLine($"I'm sorry, '{userResponseLower}' is not a valid input. Please check your spelling and try again.");
                        Console.WriteLine();
                        break;
                }
            } while (userResponseLower != "exit");
        }
    }
}
