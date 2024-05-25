using System;
using System.Globalization;
using ProjetoExceções.Entites;
using ProjetoExceções.Entites.Exceções;

try
{
    Conta c = new Conta();

    Console.WriteLine("Entre com os dados da conta");
    Console.Write("Número: ");
    c.Numero = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    c.Nome = Console.ReadLine();
    Console.Write("Valor de Deposito: ");
    c.Depositar();
    Console.Write("Valor limite de saque: ");
    c.SaqueLimite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();
    Console.Write("Coloque um valor para realizar o saque: ");
    c.Saque();
    

}catch (TratamentoDeExceções e)
{
    Console.WriteLine(e.Message);
}