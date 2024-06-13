using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class GFlatMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Gb Major";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 6;
        public string Scale { get; set; } = "Gb, Ab, Bb, Cb, Db, Eb, F, Gb";
        public string OneChord { get; set; } = "I = Gb Major (Gb-Bb-Db)";
        public string TwoChord { get; set; } = "ii = Ab minor (Ab-Cb-Eb)";
        public string ThreeChord { get; set; } = "iii = Bb minor (Bb-Db-F)";
        public string FourChord { get; set; } = "IV = Cb Major (Cb-Eb-Gb)";
        public string FiveChord { get; set; } = "V = Db Major (Db-F-Ab)";
        public string SixChord { get; set; } = "vi = Eb minor (Eb-Gb-Bb)";
        public string SevenChord { get; set; } = "vii* = F diminished (F-Ab-Cb)";
        public string RelativeKey { get; set; } = "Eb Minor";
        public string ParallelKey { get; set; } = "Gb Minor";
    }
}
