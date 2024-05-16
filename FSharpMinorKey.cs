using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class FSharpMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "F# Minor";
        public int KeySignatureSharps { get; set; } = 3;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "F#, G#, A, B, C#, D, E, F#";
        public string OneChord { get; set; } = "i = F# minor (F#-A-C#)";
        public string TwoChord { get; set; } = "ii* = G# diminished (G#-B-D)";
        public string ThreeChord { get; set; } = "III = A Major (A-C#-E)";
        public string FourChord { get; set; } = "iv = B minor (B-D-F#)";
        public string FiveChord { get; set; } = "v = C# minor (C#-E-G)";
        public string SixChord { get; set; } = "VI = D Major (D-F#-A)";
        public string SevenChord { get; set; } = "VII = E Major (E-G#-B)";
        public string RelativeKey { get; set; } = "A Major";
        public string ParallelKey { get; set; } = "F# Major";

        public void GetUsersNeeds()
        {
            Console.WriteLine($"What would you like to know about the key of {KeyName}?");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine();
            Console.WriteLine("1: Key Signature");
            Console.WriteLine("2: Scale");
            Console.WriteLine("3: Chords");
            Console.WriteLine("4: Related Keys");
            var userResponse = Console.ReadLine();
            var userResponseLower = userResponse.ToLower();

            switch (userResponseLower)
            {
                case "1":
                case "1 key signature":
                case "key signature":
                case "1: key signature":
                    Console.WriteLine($"The key signature of {KeyName} is {KeySignatureFlats} flats");
                    break;
                case "2":
                case "2 scale":
                case "scale":
                case "2: scale":
                    Console.WriteLine($"The scale of {KeyName} is {Scale}");
                    break;
                case "3":
                case "3 chords":
                case "chords":
                case "3: chords":
                    Console.WriteLine($"The chords in the key of {KeyName} are:");
                    Console.WriteLine(OneChord);
                    Console.WriteLine(TwoChord);
                    Console.WriteLine(ThreeChord);
                    Console.WriteLine(FourChord);
                    Console.WriteLine(FiveChord);
                    Console.WriteLine(SixChord);
                    Console.WriteLine(SevenChord);
                    break;
                case "4":
                case "4 related keys":
                case "related keys":
                case "4: related keys":
                    Console.WriteLine($"The relative key for {KeyName} is {RelativeKey} and the parallel key is {ParallelKey}");
                    break;
            }
        }
    }
}
