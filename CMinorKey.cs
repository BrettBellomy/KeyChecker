using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class CMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "C Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 3;
        public string Scale { get; set; } = "C, D, Eb, F, G, Ab, Bb, C";
        public string OneChord { get; set; } = "i = C minor (C-Eb-G)";
        public string TwoChord { get; set; } = "ii* = D diminished (D-F-Ab)";
        public string ThreeChord { get; set; } = "III = Eb Major (Eb-G-Bb)";
        public string FourChord { get; set; } = "iv = F minor (F-Ab-C)";
        public string FiveChord { get; set; } = "v = G minor (G-Bb-D)";
        public string SixChord { get; set; } = "VI = Ab Major (Ab-C-Eb)";
        public string SevenChord { get; set; } = "VII = Bb Major (Bb-D-F)";
        public string RelativeKey { get; set; } = "Eb Major";
        public string ParallelKey { get; set; } = "C Major";
    }
}
