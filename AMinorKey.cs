using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class AMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "A Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "A, B, C, D, E, F, G, A";
        public string OneChord { get; set; } = "i = A minor (A-C-E)";
        public string TwoChord { get; set; } = "ii* = B diminished (B-D-F)";
        public string ThreeChord { get; set; } = "III = C Major (C-E-G)";
        public string FourChord { get; set; } = "iv = D minor (D-F-A)";
        public string FiveChord { get; set; } = "v = E minor (E-G-B)";
        public string SixChord { get; set; } = "VI = F Major (F-A-C)";
        public string SevenChord { get; set; } = "VII = G Major (G-B-D)";
        public string RelativeKey { get; set; } = "C Major";
        public string ParallelKey { get; set; } = "A Major";
    }
}
