﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class EFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Eb Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 3;
        public string Scale { get; set; } = "Eb, F, G, Ab, Bb, C, D, Eb";
        public string OneChord { get; set; } = "I = Eb Major (Eb-G-Bb)";
        public string TwoChord { get; set; } = "ii = F minor (F-Ab-C)";
        public string ThreeChord { get; set; } = "iii = G minor (G-Bb-D)";
        public string FourChord { get; set; } = "IV = Ab Major (Ab-C-Eb)";
        public string FiveChord { get; set; } = "V = Bb Major (Bb-D-F)";
        public string SixChord { get; set; } = "vi = C minor (C-Eb-G)";
        public string SevenChord { get; set; } = "vii* = D diminished (D-F-Ab)";
        public string RelativeKey { get; set; } = "C Minor";
        public string ParallelKey { get; set; } = "Eb Minor";

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
