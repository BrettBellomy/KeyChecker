using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class AFlatMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Ab Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 7;
        public string Scale { get; set; } = "Ab, Bb, Cb, Db, Eb, Fb, Gb, Ab";
        public string OneChord { get; set; } = "i = Ab minor (Ab-Cb-Eb)";
        public string TwoChord { get; set; } = "ii* = Bb diminished (Bb-Db-Fb)";
        public string ThreeChord { get; set; } = "III = Cb Major (Cb-Eb-Gb)";
        public string FourChord { get; set; } = "iv = Db minor (Db-Fb-Ab)";
        public string FiveChord { get; set; } = "v = Eb minor (Eb-Gb-Bb)";
        public string SixChord { get; set; } = "VI = Fb Major (Fb-Ab-Cb)";
        public string SevenChord { get; set; } = "VII = Gb Major (Gb-Bb-Db)";
        public string RelativeKey { get; set; } = "Cb Major";
        public string ParallelKey { get; set; } = "Ab Major";

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
