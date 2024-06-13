using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class BMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "B Minor";
        public int KeySignatureSharps { get; set; } = 2;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "B, C#, D, E, F#, G, A, B";
        public string OneChord { get; set; } = "i = B minor (B-D-F#)";
        public string TwoChord { get; set; } = "ii* = C# diminished (C#-E-G)";
        public string ThreeChord { get; set; } = "III = D Major (D-F#-A)";
        public string FourChord { get; set; } = "iv = E minor (E-G-B)";
        public string FiveChord { get; set; } = "v = F# minor (F#-A-C#)";
        public string SixChord { get; set; } = "VI = G Major (G-B-D)";
        public string SevenChord { get; set; } = "VII = A Major (A-C#-E)";
        public string RelativeKey { get; set; } = "D Major";
        public string ParallelKey { get; set; } = "B Major";
    }
}
