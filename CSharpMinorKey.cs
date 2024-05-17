using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class CSharpMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "C# Minor";
        public int KeySignatureSharps { get; set; } = 4;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "C#, D#, E, F#, G#, A, B#, B";
        public string OneChord { get; set; } = "i = C# minor (C#-E-G#)";
        public string TwoChord { get; set; } = "ii* = D# diminished (D#-F#-A)";
        public string ThreeChord { get; set; } = "III = E Major (E-G#-B)";
        public string FourChord { get; set; } = "iv = F# minor (F#-A-C#)";
        public string FiveChord { get; set; } = "v = G# minor (G#-B-D#)";
        public string SixChord { get; set; } = "VI = A Major (A-C#-E)";
        public string SevenChord { get; set; } = "VII = B Major (B-D#-F#)";
        public string RelativeKey { get; set; } = "E Major";
        public string ParallelKey { get; set; } = "C# Major";
    }
}
