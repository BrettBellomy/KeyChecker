using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class EFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Eb Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 3;
        public string Scale { get; set; } = "Eb, F, G, Ab, Bb, C, D, Eb";
        public string OneChord { get; set; } = "I = Eb Major (Eb-G-Bb)";
        public string TwoChord { get; set; } = "ii = F minor (F-Ab-C)";
        public string ThreeChord { get; set; } = "iii = G minor (G-Bb-D)";
        public string FourChord { get; set; } = "IV = Ab Major (Ab-C-Eb)";
        public string FiveChord { get; set; } = "V = Bb Major (Bb-D-F)";
        public string SixChord { get; set; } = "vi = C minor (C-Eb-G)";
        public string SevenChord { get; set; } = "vii* = D diminished (D-F-Ab)";
        public string RelativeKey { get; set; } = "C Minor";
        public string ParallelKey { get; set; } = "Eb Minor";
    }
}
