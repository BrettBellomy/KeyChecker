using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class FMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "F Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 1;
        public string Scale { get; set; } = "F, G, A, Bb, C, D, E, F";
        public string OneChord { get; set; } = "I = F Major (F-A-C)";
        public string TwoChord { get; set; } = "ii = G minor (G-Bb-D)";
        public string ThreeChord { get; set; } = "iii = A minor (A-C-E)";
        public string FourChord { get; set; } = "IV = Bb Major (Bb-D-F)";
        public string FiveChord { get; set; } = "V = C Major (C-E-G)";
        public string SixChord { get; set; } = "vi = D minor (D-F-A)";
        public string SevenChord { get; set; } = "vii* = E diminished (E-G-Bb)";
        public string RelativeKey { get; set; } = "D Minor";
        public string ParallelKey { get; set; } = "F Minor";

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
