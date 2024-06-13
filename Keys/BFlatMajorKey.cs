using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class BFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Bb Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 2;
        public string Scale { get; set; } = "Bb, C, D, Eb, F, G, A, Bb";
        public string OneChord { get; set; } = "I = Bb Major (Bb-D-F)";
        public string TwoChord { get; set; } = "ii = C minor (C-Eb-G)";
        public string ThreeChord { get; set; } = "iii = D minor (D-F-A)";
        public string FourChord { get; set; } = "IV = Eb Major (E-G-Bb)";
        public string FiveChord { get; set; } = "V = F Major (F-A-C)";
        public string SixChord { get; set; } = "vi = G minor (G-Bb-D)";
        public string SevenChord { get; set; } = "vii* = A diminished (A-C-Eb)";
        public string RelativeKey { get; set; } = "G minor";
        public string ParallelKey { get; set; } = "Bb Minor";
    }
}
