using RPGame.src.Entities;

namespace RPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));
        }
    }
}