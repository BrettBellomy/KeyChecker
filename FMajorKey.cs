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
    }
}
