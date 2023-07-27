namespace CalculadoraDeIMC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~OS COMANDOS ABAIXO SÃO SOMENTE PARA BASE DE ESTUDOS~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();
        Console.WriteLine("Pressione Enter para continuar");
        Console.ReadKey();

        bool loop = true;

        while (loop == true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.Write("Informe o peso (Kg):");
            double peso = Double.Parse(Console.ReadLine());
            Console.Write("Insira a altura (cm): ");
            double altura = Double.Parse(Console.ReadLine());

            altura = (altura * altura) / 10000;
            double imc = peso / altura;

            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine("O IMC é: " + imc.ToString("N1"));


            bool encerrarPrograma = true;

            while (encerrarPrograma = true)

            {
                Console.Write("Deseja continuar (y/n)?");
                string continuar = Console.ReadLine().ToUpper();

                if (continuar.Contains("Y"))
                {
                    Console.WriteLine("Continuar.");
                    Console.WriteLine("");
                    encerrarPrograma = false;
                    loop = true;
                    break;
                }

                else if (continuar.Contains("N"))
                {
                    Console.WriteLine("Encerrando....");
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    loop = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Resposta Inválida, tente novamente.");
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    encerrarPrograma = true;
                }

            }

        }

    }
}
