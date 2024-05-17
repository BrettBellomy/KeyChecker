using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public class BFlatMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Bb Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 5;
        public string Scale { get; set; } = "Bb, C, Db, Eb, F, Gb, Ab, Bb";
        public string OneChord { get; set; } = "i = Bb minor (Bb-Db-F)";
        public string TwoChord { get; set; } = "ii* = C diminished (C-Eb-Gb)";
        public string ThreeChord { get; set; } = "III = Db Major (Db-F-Ab)";
        public string FourChord { get; set; } = "iv = Eb minor (Eb-Gb-Bb)";
        public string FiveChord { get; set; } = "v = F minor (F-Ab-C)";
        public string SixChord { get; set; } = "VI = Gb Major (Gb-Bb-Db)";
        public string SevenChord { get; set; } = "VII = Ab Major (Ab-C-Eb)";
        public string RelativeKey { get; set; } = "Db Major";
        public string ParallelKey { get; set; } = "Bb Major";
    }
}
