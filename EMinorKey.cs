using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class EMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "E Minor";
        public int KeySignatureSharps { get; set; } = 1;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "E, F#, G, A, B, C, D, E";
        public string OneChord { get; set; } = "i = E minor (E-G-B)";
        public string TwoChord { get; set; } = "ii* = F# diminished (F#-A-C)";
        public string ThreeChord { get; set; } = "III = G Major (G-B-D)";
        public string FourChord { get; set; } = "iv = A minor (A-C-E)";
        public string FiveChord { get; set; } = "v = B minor (B-D-F#)";
        public string SixChord { get; set; } = "VI = C Major (C-E-G)";
        public string SevenChord { get; set; } = "VII = D Major (D-F#-A)";
        public string RelativeKey { get; set; } = "G Major";
        public string ParallelKey { get; set; } = "E Major";
    }
}
