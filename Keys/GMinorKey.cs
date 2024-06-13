using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class GMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "G Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 2;
        public string Scale { get; set; } = "G, A, Bb, C, D, Eb, F, G";
        public string OneChord { get; set; } = "i = G minor (G-Bb-D)";
        public string TwoChord { get; set; } = "ii* = A diminished (A-C-Eb)";
        public string ThreeChord { get; set; } = "III = Bb Major (Bb-D-F)";
        public string FourChord { get; set; } = "iv = C minor (C-Eb-G)";
        public string FiveChord { get; set; } = "v = D minor (D-F-Ab)";
        public string SixChord { get; set; } = "VI = Eb Major (Eb-G-Bb)";
        public string SevenChord { get; set; } = "VII = F Major (F-A-C)";
        public string RelativeKey { get; set; } = "Bb Major";
        public string ParallelKey { get; set; } = "G Major";
    }
}
