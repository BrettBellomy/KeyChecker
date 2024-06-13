using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class GSharpMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "G# Minor";
        public int KeySignatureSharps { get; set; } = 5;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "G#, A#, B, C#, D#, E, F#, G#";
        public string OneChord { get; set; } = "i = G# minor (G#-B-D#)";
        public string TwoChord { get; set; } = "ii* = A# diminished (A#-C#-E)";
        public string ThreeChord { get; set; } = "III = B Major (B-D#-F#)";
        public string FourChord { get; set; } = "iv = C# minor (C#-E-G#)";
        public string FiveChord { get; set; } = "v = D# minor (D#-F#-A)";
        public string SixChord { get; set; } = "VI = E Major (E-G#-B)";
        public string SevenChord { get; set; } = "VII = F# Major (F#-A#-C#)";
        public string RelativeKey { get; set; } = "B Major";
        public string ParallelKey { get; set; } = "G# Major";
    }
}
