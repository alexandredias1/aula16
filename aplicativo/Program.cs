Console.Write("Escolha a forma que deseja viajar: \n1 - Uber\n2 - Taxi\n3 - UberMoto ");
int escolha = Convert.ToInt32(Console.ReadLine());


switch (escolha)
{
    case 1:
    Console.WriteLine("A forma escolhida foi Uber");
        break;
    case 2:
        Console.WriteLine("A forma escolhida foi Taxi");
        break;
    case 3:
        Console.WriteLine("A forma escolhida foi UberMoto");
        break;
    default:
        Console.WriteLine("Opção invalida.");
        break;
}


Console.ReadKey();