using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public  class DFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Db Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 5;
        public string Scale { get; set; } = "Db, Eb, F, Gb, Ab, Bb, C";
        public string OneChord { get; set; } = "I = Db Major (Db-F-Ab)";
        public string TwoChord { get; set; } = "ii = Eb minor (Eb-G-Bb)";
        public string ThreeChord { get; set; } = "iii = F minor (F-Ab-C)";
        public string FourChord { get; set; } = "IV = Gb Major (Gb-Bb-Db)";
        public string FiveChord { get; set; } = "V = Ab Major (Ab-C-Eb)";
        public string SixChord { get; set; } = "vi = Bb minor (Bb-Db-F)";
        public string SevenChord { get; set; } = "vii* = C diminished (C-Eb-Gb)";
        public string RelativeKey { get; set; } = "Ab Minor";
        public string ParallelKey { get; set; } = "Db Minor";
    }
}
