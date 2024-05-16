using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public interface IKeyChecker
    {
        public string KeyName { get; set; }
        public int KeySignatureSharps { get; set; }
        public int KeySignatureFlats { get; set; }
        public string Scale { get; set; }
        public string OneChord { get; set; }
        public string TwoChord { get; set; }
        public string ThreeChord { get; set; }
        public string FourChord { get; set; }
        public string FiveChord { get; set; }
        public string SixChord { get; set; }
        public string SevenChord { get; set; }
        public string RelativeKey { get; set; }
        public string ParallelKey { get; set; }

        public void GetUsersNeeds();
    }
}
