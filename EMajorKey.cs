using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class EMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "E Major";
        public int KeySignatureSharps { get; set; } = 4;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "E, F#, G#, A, B, C#, D#, E";
        public string OneChord { get; set; } = "I = E Major (E-G#-B)";
        public string TwoChord { get; set; } = "ii = F# minor (F#-A-C#)";
        public string ThreeChord { get; set; } = "iii = G# minor (G#-B-D#)";
        public string FourChord { get; set; } = "IV = A Major (A-C#-E)";
        public string FiveChord { get; set; } = "V = B Major (B-D#-F#)";
        public string SixChord { get; set; } = "vi = C# minor (C#-E-G#)";
        public string SevenChord { get; set; } = "vii* = D# diminished (D#-F#-A)";
        public string RelativeKey { get; set; } = "C# Minor";
        public string ParallelKey { get; set; } = "E Minor";
    }
}
