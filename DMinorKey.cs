using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class DMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "D Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 1;
        public string Scale { get; set; } = "D, E, F, G, A, Bb, C, D";
        public string OneChord { get; set; } = "i = D minor (D-F-A)";
        public string TwoChord { get; set; } = "ii* = E diminished (E-G-Bb)";
        public string ThreeChord { get; set; } = "III = F Major (F-A-C)";
        public string FourChord { get; set; } = "iv = G minor (G-Bb-D)";
        public string FiveChord { get; set; } = "v = A minor (A-C-E)";
        public string SixChord { get; set; } = "VI = Bb Major (Bb-D-F)";
        public string SevenChord { get; set; } = "VII = C Major (C-E-G)";
        public string RelativeKey { get; set; } = "F Major";
        public string ParallelKey { get; set; } = "D Major";
    }
}
