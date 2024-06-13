using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class FSharpMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "F# Minor";
        public int KeySignatureSharps { get; set; } = 3;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "F#, G#, A, B, C#, D, E, F#";
        public string OneChord { get; set; } = "i = F# minor (F#-A-C#)";
        public string TwoChord { get; set; } = "ii* = G# diminished (G#-B-D)";
        public string ThreeChord { get; set; } = "III = A Major (A-C#-E)";
        public string FourChord { get; set; } = "iv = B minor (B-D-F#)";
        public string FiveChord { get; set; } = "v = C# minor (C#-E-G)";
        public string SixChord { get; set; } = "VI = D Major (D-F#-A)";
        public string SevenChord { get; set; } = "VII = E Major (E-G#-B)";
        public string RelativeKey { get; set; } = "A Major";
        public string ParallelKey { get; set; } = "F# Major";
    }
}
