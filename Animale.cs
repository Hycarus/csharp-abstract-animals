using System;
namespace csharp_abstract_animals
{
	public abstract class Animale
	{
		public static void Dormi()
		{
			Console.WriteLine("Zzz");
		}
		public abstract string Verso();
		public abstract string Mangia();
	}

	public class Cane : Animale
	{
        public override string Mangia()
        {
			return "ogni tipo di carne";
        }
        public override string Verso()
        {
			return "Bau, bau";
        }
    }

	public class Passerotto : Animale, IVolante
	{
        public override string Mangia()
        {
            return "fiocchi d'avena, noci e nocciole, uvette e frutta";
        }
        public override string Verso()
        {
            return "Cip, cip";
        }
        public string Vola()
        {
            return "Sto volando!!";
        }
    }

    public class Aquila : Animale, IVolante
    {
        public override string Mangia()
        {
            return "volpi, lepri, marmotte, conigli selvatici e faine";
        }
        public override string Verso()
        {
            return "Screech";
        }
        public string Vola()
        {
            return "Sto volando!!";
        }
    }

    public class Delfino : Animale, INuotante
    {
        public override string Mangia()
        {
            return "pesci";
        }
        public override string Verso()
        {
            return "Ride";
        }
        public string Nuota()
        {
            return "Sto nuotando!!";
        }
    }
}

