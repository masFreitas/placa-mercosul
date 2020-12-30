using System;

namespace PlacaMercosul
{
    class Program
    {
        static void Main(string[] args)
        {
            //O Detran alterou recentemente as placas dos carros para o modelo Mercosul (https://seminovos.localiza.com/novas-placas-padrao-mercosul). Com isso foi solicitado a você, fazer um programa que leia a marca, modelo, o ano de fabricação e placa antiga (ABC-1234) de um carro, e escreva a marca, o modelo e ano de fabricação e converta a placa para o padrão novo (ABC-1C34).

            char[] normal = new char[10] {'0','1', '2', '3', '4', '5','6','7','8', '9'};
            char[] mercosul = new char[10] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            string marca, modelo, placasAntiga, placaNova;
            int ano, i; 

            Console.Write("Marca: ");
            marca = Console.ReadLine();
            Console.Write("Modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Placa antiga: (com '-'. ex: AAA-0000): ");
            placasAntiga = Console.ReadLine();

            char [] troca = placasAntiga.ToCharArray();

            for (i = 0; i < 10; i++)
            {
                if (troca[5] == normal[i])
                {
                    troca[5] = mercosul[i];
                }
            }
              
            placaNova = new string (troca);
               
            Console.WriteLine("O carro {0}/{1} ano {2} com nova placa {3}", marca, modelo, ano, placaNova);
        }
    }
}