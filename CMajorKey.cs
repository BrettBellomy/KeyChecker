using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    internal class CMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "C Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "C, D, E, F, G, A, B, C";
        public string OneChord { get; set; } = "I = C Major (C-E-G)";
        public string TwoChord { get; set; } = "ii = D minor (D-F-A)";
        public string ThreeChord { get; set; } = "iii = E minor (E-G-B)";
        public string FourChord { get; set; } = "IV = F Major (F-A-C)";
        public string FiveChord { get; set; } = "V = G Major (G-B-D)";
        public string SixChord { get; set; } = "vi = A minor (A-C-E)";
        public string SevenChord { get; set; } = "vii* = B diminished (B-D-F)";
        public string RelativeKey { get; set; } = "A Minor";
        public string ParallelKey { get; set; } = "C Minor";
    }
}
