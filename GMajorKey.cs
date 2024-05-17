using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class GMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "G Major";
        public int KeySignatureSharps { get; set; } = 1;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "G, A, B, C, D, E, F#, G";
        public string OneChord { get; set; } = "I = G Major (G-B-D)";
        public string TwoChord { get; set; } = "ii = A minor (A-C-E)";
        public string ThreeChord { get; set; } = "iii = B minor (B-D-F#)";
        public string FourChord { get; set; } = "IV = C Major (C-E-G)";
        public string FiveChord { get; set; } = "V = D Major (D-F#-A)";
        public string SixChord { get; set; } = "vi = E minor (E-G-B)";
        public string SevenChord { get; set; } = "vii* = F# diminished (F#-A-C)";
        public string RelativeKey { get; set; } = "E Minor";
        public string ParallelKey { get; set; } = "G Minor";
    }
}
