using System;

namespace Program {
    public class Kniha {
        public string Name {get; protected set;} = string.Empty;
        public string Author {get; protected set;} = string.Empty;
        public ushort YearOfRelease {get; protected set;} = 0;

        public Kniha(string name, string author, ushort year) {
            Name = name;
            Author = author;
            YearOfRelease = year;
        }

        public virtual void PrintData() {
            Console.WriteLine($"Name: {Name}\nAuthor: {Author}\nYear: {YearOfRelease}");
        }
    }
}