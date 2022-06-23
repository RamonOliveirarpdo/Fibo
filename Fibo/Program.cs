// See https://aka.ms/new-console-template for more information
int n1 = 0, n2 = 1, n3, n4;

Console.WriteLine("Digite um numero: ");
n3 = int.Parse(Console.ReadLine());

for (int i = 0 ; i <= 100; i++)
{
    n4 = n2;
    n2 = (n1 + n2);
    n1 = n4;
    if (n3 == n2)
    {

        Console.WriteLine("Numero informado pertence a sequencia Fibonacci! ");
        return;
    }
}

if (n3 != n2)

{
    Console.WriteLine("Numero Informado Não pertence a sequencia Fibonacci! ");

}





