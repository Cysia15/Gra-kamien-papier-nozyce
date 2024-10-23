class Gra
{
    static void Main(string[] args)
    {
        int pktgracz = 0;
        int pktpc = 0;
        Console.WriteLine("Witaj w grze Kamien,papier,nozyce! Z mierz sie z naszym komputerem");

        Console.WriteLine("Wybierz ile rund chcesz zagrac");
        int wymaganpkt = int.Parse(Console.ReadLine());

        Console.WriteLine("wybrales " + wymaganpkt + "rund");


        while ((pktgracz < wymaganpkt)|| (pktpc < wymaganpkt))
        {
Powrot:
            Random rnd = new Random();
            int wybor_pc = rnd.Next(3);


            Console.WriteLine("wybierz: kamien (k), papier(p), nozyce(n)");
            string wybor_gracz = Console.ReadLine();


            int wybor_gracz_int = 4;
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
                    goto Powrot;
                    break;
            }
            if (wybor_gracz_int == wybor_pc)
            {
                Console.WriteLine("remisik");
                
                goto Powrot;
               
                
            }
            else if ((wybor_gracz_int == 0 && wybor_pc == 1) || (wybor_gracz_int == 2 && wybor_pc == 0))
            {
                Console.WriteLine("komputerix wygrywa ");
                pktpc++;
                Console.WriteLine("Gracz: " + pktgracz + " ------" + " komputer: " + pktpc);
                goto Powrot;
            }
            else if ((wybor_gracz_int == 0 && wybor_pc == 2) || (wybor_gracz_int == 1 && wybor_pc == 0))
            {
                Console.WriteLine("ZIOOOM ALE WINEK");
                pktgracz++;
                Console.WriteLine($"Gracz: {pktgracz}   ------  komputer: {pktpc}");
                goto Powrot;
            }
        }
        if
    }
}