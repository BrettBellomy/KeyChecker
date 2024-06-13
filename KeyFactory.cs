using KeyChecker.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker
{
    public static class KeyFactory
    {
        public static IKeyChecker GetKey(string key)
        {
            switch (key)
            {
                case "abmajor":
                case "aflatmajor":
                case "ab":
                case "aflat":
                    return new AFlatMajorKey();

                case "abminor":
                case "aflatminor":
                case "abm":
                case "aflatm":
                    return new AFlatMinorKey();

                case "amajor":
                case "a":
                    return new AMajorKey();

                case "aminor":
                case "am":
                    return new AMinorKey();

                case "a#minor":
                case "asharpminor":
                case "a#m":
                case "asharpm":
                    return new ASharpMinorKey();

                case "bbmajor":
                case "bflatmajor":
                case "bb":
                case "bflat":
                    return new BFlatMajorKey();

                case "bbminor":
                case "bflatminor":
                case "bbm":
                case "bflatm":
                    return new BFlatMinorKey();

                case "bmajor":
                case "b":
                    return new BMajorKey();

                case "bminor":
                case "bm":
                    return new BMinorKey();

                case "cmajor":
                case "c":
                    return new CMajorKey();

                case "cminor":
                case "cm":
                    return new CMinorKey();

                case "c#major":
                case "csharpmajor":
                case "c#":
                case "csharp":
                    return new CSharpMajorKey();

                case "c#minor":
                case "csharpminor":
                case "c#m":
                case "csharpm":
                    return new CSharpMinorKey();

                case "dbmajor":
                case "dflatmajor":
                case "db":
                case "dflat":
                    return new DFlatMajorKey();

                case "dmajor":
                case "d":
                    return new DMajorKey();

                case "dminor":
                case "dm":
                    return new DMinorKey();

                case "d#minor":
                case "dsharpminor":
                case "d#m":
                case "dsharpm":
                    return new DSharpMinorKey();

                case "ebmajor":
                case "eflatmajor":
                case "eb":
                case "eflat":
                    return new EFlatMajorKey();

                case "ebminor":
                case "eflatminor":
                case "ebm":
                case "eflatm":
                    return new EFlatMinorKey();

                case "emajor":
                case "e":
                    return new EMajorKey();

                case "eminor":
                case "em":
                    return new EMinorKey();

                case "fmajor":
                case "f":
                    return new FMajorKey();

                case "fminor":
                case "fm":
                    return new FMinorKey();

                case "f#major":
                case "fsharpmajor":
                case "f#":
                case "fsharp":
                    return new FSharpMajorKey();

                case "f#minor":
                case "fsharpminor":
                case "f#m":
                case "fsharpm":
                    return new FSharpMinorKey();

                case "gbmajor":
                case "gflatmajor":
                case "gb":
                case "gflat":
                    return new GFlatMajorKey();

                case "gmajor":
                case "g":

                    return new GMajorKey();

                case "gminor":
                case "gm":

                    return new GMinorKey();

                case "g#major":
                case "gsharpminor":
                case "g#m":
                case "gsharpm":
                    return new GSharpMinorKey();

                default:
                    Console.WriteLine($"I'm sorry, '{key}' is not a valid key name.");
                    return new IncorrectInput();
            }
        }
    }
}
