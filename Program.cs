namespace csharp_abstract_animals;

class Program
{
    static void Main(string[] args)
    {
        Cane cane = new();
        Passerotto passerotto = new();
        Aquila aquila = new();
        Delfino delfino = new();

        Console.Write("Ecco il verso del cane: ");
        cane.Verso();
        Console.Write("Ecco cosa mangia il cane: ");
        cane.Mangia();

        Console.Write("Ecco il verso del passerotto: ");
        passerotto.Verso();
        Console.Write("Ecco cosa mangia il passerotto: ");
        passerotto.Mangia();

        Console.Write("Ecco il verso dell'aquila: ");
        aquila.Verso();
        Console.Write("Ecco cosa mangia l'aquila: ");
        aquila.Mangia();

        Console.Write("Ecco il verso del delfino: ");
        delfino.Verso();
        Console.Write("Ecco cosa mangia il delfino: ");
        delfino.Mangia();

        Console.Write("Ecco cosa fa il delfino: ");
        FaiNuotare(delfino);

        Console.Write("Ecco cosa fa l'aquila: ");
        FaiVolare(aquila);
    }

    public static void FaiVolare(IVolante animale)
    {
        animale.Vola();
    }

    public static void FaiNuotare(INuotante animale)
    {
        animale.Nuota();
    }


}

