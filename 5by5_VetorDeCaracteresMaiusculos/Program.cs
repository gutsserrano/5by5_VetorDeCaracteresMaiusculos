/*Faça um programa que leia um vetor de caracteres de 10 posições e converta as vogais de
    minúsculo para maiúsculo (informe tudo minúsuclo)
 */

char[] letras = new char[10];

int option = 0;

do
{
    Console.WriteLine("Digite 10 caracteres:");
    for (int i = 0; i < 10; i++)
    {
        letras[i] = char.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 10; i++)
    {
        switch (letras[i])
        {
            case 'a':
                letras[i] = 'A';
                break;
            case 'e':
                letras[i] = 'E';
                break;
            case 'i':
                letras[i] = 'I';
                break;
            case 'o':
                letras[i] = 'O';
                break;
            case 'u':
                letras[i] = 'U';
                break;
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Console.Write(letras[i]);
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);