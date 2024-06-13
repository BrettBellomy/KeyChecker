using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class AFlatMinorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "Ab Minor";
        public int KeySignatureSharps { get; set; } = 0;
        public int KeySignatureFlats { get; set; } = 7;
        public string Scale { get; set; } = "Ab, Bb, Cb, Db, Eb, Fb, Gb, Ab";
        public string OneChord { get; set; } = "i = Ab minor (Ab-Cb-Eb)";
        public string TwoChord { get; set; } = "ii* = Bb diminished (Bb-Db-Fb)";
        public string ThreeChord { get; set; } = "III = Cb Major (Cb-Eb-Gb)";
        public string FourChord { get; set; } = "iv = Db minor (Db-Fb-Ab)";
        public string FiveChord { get; set; } = "v = Eb minor (Eb-Gb-Bb)";
        public string SixChord { get; set; } = "VI = Fb Major (Fb-Ab-Cb)";
        public string SevenChord { get; set; } = "VII = Gb Major (Gb-Bb-Db)";
        public string RelativeKey { get; set; } = "Cb Major";
        public string ParallelKey { get; set; } = "Ab Major";
    }
}
