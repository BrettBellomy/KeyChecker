using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class EFlatMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Eb Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 6;
        public string Scale { get; set; } = "Eb, F, Gb, Ab, Bb, Cb, Db, Eb";
        public string OneChord { get; set; } = "i = Eb minor (Eb-Gb-Bb)";
        public string TwoChord { get; set; } = "ii* = F diminished (F-Ab-Cb)";
        public string ThreeChord { get; set; } = "III = Gb Major (Gb-Bb-Db)";
        public string FourChord { get; set; } = "iv = Ab minor (Ab-Cb-Eb)";
        public string FiveChord { get; set; } = "v = Bb minor (Bb-Db-F)";
        public string SixChord { get; set; } = "VI = Cb Major (Cb-Eb-Gb)";
        public string SevenChord { get; set; } = "VII = Db Major (Db-F-Ab)";
        public string RelativeKey { get; set; } = "Gb Major";
        public string ParallelKey { get; set; } = "Eb Major";

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
