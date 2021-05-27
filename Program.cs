using System;
using Humanizer;
using Figgle;

namespace nomeAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando textos em ASCII art");
            string nome;
            Console.Write("Digite alguma frase ou palavra: ");
            nome=Convert.ToString(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(FiggleFonts.Standard.Render(nome));
            Console.ResetColor();
        }
    }
}
