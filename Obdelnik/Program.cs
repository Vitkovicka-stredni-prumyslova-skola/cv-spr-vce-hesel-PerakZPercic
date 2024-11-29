using System;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            Knihovna.AddBook(new Kniha("Pekna kniha", "Andrej Maly", 2009));
            Knihovna.AddBook(new EKniha("Prvni ekniha", "Jaroslav Velky", 2001, 850.3d, "pdf"));

            Kniha[] books = Knihovna.GetBooks();
            foreach (Kniha k in books)
                k.PrintData();
        }
    }
}
