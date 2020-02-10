using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CriptografiaCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string crypt = "", decrypt = "";
            int numCar = 0, num = 0, escolha;
            Console.WriteLine("Tecle 1 para criptografar!");
            Console.WriteLine("Tecle 2 para descriptografar!");
            Console.WriteLine("Tecle 3 para encerrar a aplicação!");
            escolha = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hello World!");
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite o texto p/ criptografar!");
                    crypt = Console.ReadLine();
                    numCar = crypt.Length;
                    for (int i = 0; i < numCar; i++)
                    {
                        num = Convert.ToInt16(crypt[i]) + 3;
                        decrypt += Convert.ToChar(num);

                    }
                    Console.WriteLine("{0}", decrypt);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Digite o texto p/ descriptografar!");
                    crypt = Console.ReadLine();
                    numCar = crypt.Length;
                    for (int i = 0; i < numCar; i++)
                    {
                        num = Convert.ToInt16(crypt[i]) - 3;
                        decrypt += Convert.ToChar(num);

                    }
                    Console.WriteLine("{0}", decrypt);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Pressione ENTER p/ sair do sistema.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
