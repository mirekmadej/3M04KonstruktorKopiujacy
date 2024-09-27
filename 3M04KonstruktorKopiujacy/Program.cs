namespace _3M04KonstruktorKopiujacy
{
    class Tablica
    {
        private int[] liczby;
        public Tablica(int a, int b, int c)
        {
            liczby = new int[3];
            liczby[0] = a;
            liczby[1] = b;
            liczby[2] = c;
        }
        //Tablica t2 = new Tablica(t1);
        public Tablica(Tablica t)
        {
            liczby = new int[3];
            liczby[0] = t.liczby[0];
            liczby[1] = t.liczby[1];
            liczby[2] = t.liczby[2];
        }
        public void ustawLiczby(int a, int b, int c)
        {
            liczby[0] = a;
            liczby[1] = b;
            liczby[2] = c;
        }
        public override string ToString()
        {
            return $"{liczby[0]}, {liczby[1]}, {liczby[2]}";
        }
    }
    class Osoba
    {
        private string imie;
        private int id;
        public Osoba(string imie, int id)
        {
            this.imie = imie;
            this.id = id;
        }
        public Osoba(Osoba o)
        {
            this.imie = o.imie;
            this.id = o.id;
        }
        public void ustawOsoba(string imie, int id)
        {
            this.imie = imie;
            this.id = id;
        }
        public override string ToString()
        {
            return $"{id}, {imie}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica t1 = new Tablica(1, 2, 3);
            Console.WriteLine(t1);
            Osoba o1 = new Osoba("Jasio", 1);
            Console.WriteLine($"o1: {o1}");

            Tablica t2 = new Tablica(t1);
            Console.WriteLine($"t2: {t2}");
            t2.ustawLiczby(4, 5, 6);
            Console.WriteLine($"t1: {t1}");
            Console.WriteLine($"t2: {t2}");

            Osoba o2 = new Osoba(o1);
            Console.WriteLine($"o2: {o2}");
            o2.ustawOsoba("Ala", 2);
            Console.WriteLine($"o1: {o1}");
            Console.WriteLine($"o2: {o2}");
        }
    }
}
