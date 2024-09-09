Console.WriteLine("Podrão!");

Console.Write("Digite o seu nome: ");
string cliente = Console.ReadLine();

Console.Write("Qual o nome do item: ");
string item = Console.ReadLine();

Console.Write("Qual a quantidade: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

Console.Write("O valor total é de: ");
float valor = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"O cliente {cliente}, pediu o total de {quantidade} {item}");
Console.WriteLine($"O valor total é de {valor}");


Console.ReadKey();