using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class FMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "F Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 4;
        public string Scale { get; set; } = "F, G, Ab, Bb, C, Db, Eb, F";
        public string OneChord { get; set; } = "i = F minor (F-Ab-C)";
        public string TwoChord { get; set; } = "ii* = G diminished (G-Bb-Db)";
        public string ThreeChord { get; set; } = "III = Ab Major (Ab-C-Eb)";
        public string FourChord { get; set; } = "iv = Bb minor (Bb-Db-F)";
        public string FiveChord { get; set; } = "v = C minor (C-Eb-Gb)";
        public string SixChord { get; set; } = "VI = Db Major (Db-F-Ab)";
        public string SevenChord { get; set; } = "VII = Eb Major (Eb-G-Bb)";
        public string RelativeKey { get; set; } = "Ab Major";
        public string ParallelKey { get; set; } = "F Major";
    }
}
