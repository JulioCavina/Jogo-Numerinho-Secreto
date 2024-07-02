// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;


Console.WriteLine(@"
███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░██╗███╗░░██╗██╗░░██╗░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██║████╗░██║██║░░██║██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║██╔██╗██║███████║██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║██║╚████║██╔══██║██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║██║██║░╚███║██║░░██║╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░

░██████╗███████╗░█████╗░██████╗░███████╗████████╗░█████╗░
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗
╚█████╗░█████╗░░██║░░╚═╝██████╔╝█████╗░░░░░██║░░░██║░░██║
░╚═══██╗██╔══╝░░██║░░██╗██╔══██╗██╔══╝░░░░░██║░░░██║░░██║
██████╔╝███████╗╚█████╔╝██║░░██║███████╗░░░██║░░░╚█████╔╝
╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░░╚════╝░");
Console.WriteLine("\nTente adivinhar qual é o número entre 0 à 1000");
float numerinho = RandomNumberGenerator(0, 1001);
string palpiteJogador = "";
int intPalpiteJogador = 0;
//Console.WriteLine(numerinho);
IniciarJogo(numerinho);

void IniciarJogo(float numerinho)
{

    int contadorPalpites = 0;
    do
    {
        Console.Write("\nQual é o seu palpite: ");
        palpiteJogador = Console.ReadLine()!;
        intPalpiteJogador = int.Parse(palpiteJogador);
        contadorPalpites++;
        if (intPalpiteJogador == numerinho)
        {
            Console.WriteLine("\nEstá correto!!! O número era " + intPalpiteJogador);
            Console.WriteLine("TCHAAAU :)");

        }
        else if(intPalpiteJogador>numerinho)
        {
            Console.WriteLine("O número é MENOR do que " + intPalpiteJogador);

        }
        else
        {
            Console.WriteLine("O número é MAIOR do que " +intPalpiteJogador);
        
        }
        
    } while (intPalpiteJogador != numerinho);
}

float RandomNumberGenerator(int v1, int v2)
{
    Random random = new Random();
    return (float)random.Next(v1, v2);
}
