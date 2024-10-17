class Gra
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int wybor_pc = rnd.Next(3);
       
        Console.WriteLine("Witaj w grze Kamien,papier,nozyce! Z mierz sie z naszym komputerem");
        Console.WriteLine("wybierz: kamien (k), papier(p), nozyce(n)");
        string wybor_gracz = Console.ReadLine();


        int wybor_gracz_int;
        switch (wybor_gracz)
        {
            case "k":
                {
                    wybor_gracz_int = 0;
                    break;
                }
            case "p":
                {
                    wybor_gracz_int = 1;
                    break;
                }
            case "n":
                {
                    wybor_gracz_int = 2;
                    break;
                }
            default:
                Console.WriteLine("zły wybór");
                break;
        }
    }
}