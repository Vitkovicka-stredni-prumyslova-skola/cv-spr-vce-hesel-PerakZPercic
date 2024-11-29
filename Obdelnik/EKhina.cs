using System;

namespace Program {
    public sealed class EKniha : Kniha {
        public double FileSize {get; private set;} = 0d; // Nevím proč se uvádí velikost jako double, možná myšleno jako $"{FileSize}Kb"?
        public string Format {get; private set;} = string.Empty;

        public EKniha(string name, string author, ushort year, double filesize, string fmt) : base(name, author, year) {
            FileSize = filesize;
            Format = fmt;
        }

        public override void PrintData() {
            base.PrintData();
            Console.WriteLine($"File size: {FileSize}Kb\nFormat: {Format}");
        }
    }
}