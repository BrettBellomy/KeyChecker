using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class FSharpMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "F# Major";
        public int KeySignatureSharps { get; set; } = 6;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "F#, G#, A#, B, C#, D#, E#, F#";
        public string OneChord { get; set; } = "I = F# Major (F#-A#-C#)";
        public string TwoChord { get; set; } = "ii = G# minor (G#-B-D#)";
        public string ThreeChord { get; set; } = "iii = A# minor (A#-C#-E#)";
        public string FourChord { get; set; } = "IV = B Major (B-D#-F#)";
        public string FiveChord { get; set; } = "V = C# Major (C#-E#-G#)";
        public string SixChord { get; set; } = "vi = D# minor (D#-F#-A#)";
        public string SevenChord { get; set; } = "vii* = E# diminished (E#-G#-B)";
        public string RelativeKey { get; set; } = "D# Minor";
        public string ParallelKey { get; set; } = "F# Minor";
    }
}
