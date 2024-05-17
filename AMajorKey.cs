using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class AMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "A Major";
        public int KeySignatureSharps { get; set; } = 3;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "A, B, C#, D, E, F#, G#, A";
        public string OneChord { get; set; } = "I = A Major (A-C#-E)";
        public string TwoChord { get; set; } = "ii = B minor (B-D-F#)";
        public string ThreeChord { get; set; } = "iii = C# minor (C#-E-G#)";
        public string FourChord { get; set; } = "IV = D Major (D-F#-A)";
        public string FiveChord { get; set; } = "V = E Major (E-G#-B)";
        public string SixChord { get; set; } = "vi = F# minor (F#-A-C#)";
        public string SevenChord { get; set; } = "vii* = G# diminished (G#-B-D)";
        public string RelativeKey { get; set; } = "F# Minor";
        public string ParallelKey { get; set; } = "A Minor";
    }
}
