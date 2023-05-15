namespace TF_NetCore_Carwash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("1-ABC-123");
            Voiture voiture2 = new Voiture("1-DEF-456");

            Carwash carwash = new Carwash();
            carwash.Traiter(voiture);
            carwash.Traiter(voiture2);
        }
    }
}