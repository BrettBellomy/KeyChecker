using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class AFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Ab Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 4;
        public string Scale { get; set; } = "Ab, Bb, C, Db, Eb, F, G, Ab";
        public string OneChord { get; set; } = "I = Ab Major (Ab-C-Eb)";
        public string TwoChord { get; set; } = "ii = Bb minor (Bb-Db-F)";
        public string ThreeChord { get; set; } = "iii = C minor (C-Eb-G)";
        public string FourChord { get; set; } = "IV = Db Major (Db-F-Ab)";
        public string FiveChord { get; set; } = "V = Eb Major (Eb-G-Bb)";
        public string SixChord { get; set; } = "vi = F minor (F-Ab-C)";
        public string SevenChord { get; set; } = "vii* = G diminished (G-Bb-Db)";
        public string RelativeKey { get; set; } = "F Minor";
        public string ParallelKey { get; set; } = "Ab Major";
    }
}
