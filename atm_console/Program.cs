using System;

namespace atm_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"|----------------------------------------------------------------------------|");
            Console.WriteLine($"|-----------------------<                ATM               >-----------------|");
            Console.WriteLine($"|----------------------------------------------------------------------------|\n");
            
            
            Console.Write($"|Informe o valor que Deseja Sacar: ");int saque = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int valor = saque; int cedulas = 100; int tlcedulas = 0; int vlsacado = 0;
            Console.WriteLine($"|-----------------------< Total de Cédulas e Nota Entregue >-----------------|\n");
            while (true)
            {
                if (valor >= cedulas) { valor -= cedulas; tlcedulas += 1; }

                else
                {
                    if (tlcedulas > 0)
                    {
                        
                        
                        Console.WriteLine($"|Total de {tlcedulas} Cédulas de {cedulas}"); vlsacado = tlcedulas * cedulas;
                    }
                    if (cedulas == 100) { cedulas = 50; }
                    else if (cedulas == 50) { cedulas = 20; }
                    else if (cedulas == 20) { cedulas = 10; }
                    else if (cedulas == 50) { cedulas = 20; }
                    else if (cedulas == 20) { cedulas = 10; }
                    else if (cedulas == 10) { cedulas = 5; }
                    else if (cedulas == 5) { cedulas = 2; }
                    tlcedulas = 0;
                    if (valor == 0) { break; }
                }


            }

            Console.WriteLine($"|-----------------------< Valor Entregue X Saldo Pendente  >-----------------|\n");
            Console.WriteLine($"Valor Solicitado: {saque.ToString("C0")} Valor Disponivel {vlsacado.ToString("C2")}  Saldo Devolvido: {saque - vlsacado} \n");
            Console.WriteLine($"|-----------------------<                FIM               >-----------------|");



        }
    }
}
