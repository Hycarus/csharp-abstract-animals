namespace csharp_abstract_animals;

class Program
{
    static void Main(string[] args)
    {
        Cane cane = new();
        Passerotto passerotto = new();
        Aquila aquila = new();
        Delfino delfino = new();

        List<Animale> animali = new()
        {
            cane, delfino, aquila, passerotto
        };

        foreach(Animale animale in animali)
        {
            Console.WriteLine($"Ecco il verso di {animale.GetType().Name}: '{animale.Verso()}' ed ecco cosa mangia: {animale.Mangia()}");
        }

        Console.WriteLine($"Ecco cosa fa il delfino: {FaiNuotare(delfino)}");
        Console.WriteLine($"Ecco cosa fa l'aquila: {FaiVolare(aquila)}");
        
    }

    public static string FaiVolare(IVolante animale)
    {
        return animale.Vola();
    }

    public static string FaiNuotare(INuotante animale)
    {
        return animale.Nuota();
    }


}

