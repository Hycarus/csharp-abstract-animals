using System;
namespace csharp_abstract_animals
{
	public abstract class Animale
	{
		public static void Dormi()
		{
			Console.WriteLine("Zzz");
		}
		public abstract void Verso();
		public abstract void Mangia();
	}

	public class Cane : Animale
	{
        public override void Mangia()
        {
			Console.WriteLine("Mangime per cani");
        }
        public override void Verso()
        {
			Console.WriteLine("Bau, bau");
        }
    }

	public class Passerotto : Animale, IVolante
	{
        public override void Mangia()
        {
            Console.WriteLine("Cip, cip");
        }
        public override void Verso()
        {
            Console.WriteLine("Vermi");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando!!");
        }
    }

    public class Aquila : Animale, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("*Inserire qui cosa mangia l'aquila*");
        }
        public override void Verso()
        {
            Console.WriteLine("*Inserire qui il verso dell'aquila*");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando!!");
        }
    }

    public class Delfino : Animale, INuotante
    {
        public override void Mangia()
        {
            Console.WriteLine("*Inserire qui cosa mangia il delfino*");
        }
        public override void Verso()
        {
            Console.WriteLine("*Inserire qui il verso del delfino*");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!");
        }
    }
}

