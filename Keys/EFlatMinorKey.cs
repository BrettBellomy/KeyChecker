using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class EFlatMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Eb Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 6;
        public string Scale { get; set; } = "Eb, F, Gb, Ab, Bb, Cb, Db, Eb";
        public string OneChord { get; set; } = "i = Eb minor (Eb-Gb-Bb)";
        public string TwoChord { get; set; } = "ii* = F diminished (F-Ab-Cb)";
        public string ThreeChord { get; set; } = "III = Gb Major (Gb-Bb-Db)";
        public string FourChord { get; set; } = "iv = Ab minor (Ab-Cb-Eb)";
        public string FiveChord { get; set; } = "v = Bb minor (Bb-Db-F)";
        public string SixChord { get; set; } = "VI = Cb Major (Cb-Eb-Gb)";
        public string SevenChord { get; set; } = "VII = Db Major (Db-F-Ab)";
        public string RelativeKey { get; set; } = "Gb Major";
        public string ParallelKey { get; set; } = "Eb Major";
    }
}
