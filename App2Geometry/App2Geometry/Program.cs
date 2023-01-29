// See https://aka.ms/new-console-template for more information

using App2Geometry;

Console.WriteLine("Scegli la forma: Q = quadrato, R = rettangolo, C = cerchio, T= triangolo");
ConsoleKeyInfo key = Console.ReadKey();

MethodIf(key);

Console.ReadLine();

static void MethodIf(ConsoleKeyInfo key)
{
    if (key.KeyChar == 'Q')
    {
        Square s = new Square();
        Console.WriteLine("Inserisci il lato: ");
        string text = Console.ReadLine() ?? "0";
        int l = Convert.ToInt32(text);

        s.Side = l;
        Console.WriteLine($"Area del quadrato: {s.Area}");
    }
    else if (key.KeyChar == 'R')
    {
        Rectangle r = new Rectangle();

        Console.WriteLine();
        Console.WriteLine("Inserisci la base: ");
        string text = Console.ReadLine() ?? "0";
        int w = Convert.ToInt32(text);

        r.Width = w;

        Console.WriteLine();
        Console.WriteLine("Inserisci l'altezza: ");
        text = Console.ReadLine() ?? "0";
        int h = Convert.ToInt32(text);

        r.Height = h;

        Console.WriteLine($"Area del rettangolo: {r.Area}");
    }
    else if (key.KeyChar == 'C')
    {
        Circle c = new Circle();
        Console.WriteLine();
        Console.WriteLine("Inserici il raggio: ");
        string text = Console.ReadLine() ?? "0";
        int r = Convert.ToInt32(text);
        c.Radius = r;

        Console.WriteLine($"Area del cerchio: {c.Area}");
    }
    else if (key.KeyChar == 'T')
    {
        Triangle t = new Triangle();
        Console.WriteLine();
        Console.WriteLine("Inserici la base: ");
        string text = Console.ReadLine() ?? "0";
        int w = Convert.ToInt32(text);

        t.Width= w;

        Console.WriteLine();
        Console.WriteLine("Inserisci l'altezza: ");
        text = Console.ReadLine() ?? "0";
        int h = Convert.ToInt32(text);

        t.Height= h;

        Console.WriteLine($"Area del triangolo: {t.Area}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Hai sbagliato tasto!");
    }
}