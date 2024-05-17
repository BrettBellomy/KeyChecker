using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class DMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "D Major";
        public int KeySignatureSharps { get; set; } = 2;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "D, E, F#, G, A, B, C#";
        public string OneChord { get; set; } = "I = D Major (D-F#-A)";
        public string TwoChord { get; set; } = "ii = E minor (E-G-B)";
        public string ThreeChord { get; set; } = "iii = F# minor (F#-A-C#)";
        public string FourChord { get; set; } = "IV = G Major (G-B-D)";
        public string FiveChord { get; set; } = "V = A Major (A-C#-E)";
        public string SixChord { get; set; } = "vi = B minor (B-D-F#)";
        public string SevenChord { get; set; } = "vii* = C# diminished (C#-E-G#)";
        public string RelativeKey { get; set; } = "B Minor";
        public string ParallelKey { get; set; } = "D Minor";
    }
}
