using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public  class DFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Db Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 5;
        public string Scale { get; set; } = "Db, Eb, F, Gb, Ab, Bb, C";
        public string OneChord { get; set; } = "I = Db Major (Db-F-Ab)";
        public string TwoChord { get; set; } = "ii = Eb minor (Eb-G-Bb)";
        public string ThreeChord { get; set; } = "iii = F minor (F-Ab-C)";
        public string FourChord { get; set; } = "IV = Gb Major (Gb-Bb-Db)";
        public string FiveChord { get; set; } = "V = Ab Major (Ab-C-Eb)";
        public string SixChord { get; set; } = "vi = Bb minor (Bb-Db-F)";
        public string SevenChord { get; set; } = "vii* = C diminished (C-Eb-Gb)";
        public string RelativeKey { get; set; } = "Ab Minor";
        public string ParallelKey { get; set; } = "Db Minor";

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
