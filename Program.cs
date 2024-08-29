
int numero = 5;
int contador = 0;

//Estrutura de repetição FOR
for(int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = " + numero * i);
}

//Estrutura de repetição WHILE
while(contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = " + numero * contador);
    contador++;
}

//Estrutura de repetição DO WHILE
int soma = 0, num = 0;
do
{
    Console.WriteLine("Digite um número (0 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

}while(num != 0);

Console.WriteLine($"Total da soma dos números digitados {soma}");