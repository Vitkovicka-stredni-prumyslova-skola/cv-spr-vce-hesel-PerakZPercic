using System;
using System.Linq;
using System.Collections.Generic;

namespace Program {
    public static class Knihovna {
        private static Dictionary<string, Kniha> m_Books = new Dictionary<string, Kniha>();

        private static string GetBookUID(string name, string author) {
            return $"{name.ToLower()}-{author.ToLower()}";
        }

        public static void AddBook(Kniha k) {
            string uid = GetBookUID(k.Name, k.Author);

            if (m_Books.ContainsKey(uid))
                return;

            m_Books.Add(uid, k);
        }
        public static Kniha? GetBook(string name, string author) {
            string uid = GetBookUID(name, author);
            if (m_Books.TryGetValue(uid, out Kniha? k))
                return k;

            return null;
        }
        public static Kniha[] GetBooks() {
            return m_Books.Values.ToArray();
        }

        public static int GetBookCount() {
            return m_Books.Keys.Count;
        }
    }
}