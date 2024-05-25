using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ProjetoExceções.Entites.Exceções;


namespace ProjetoExceções.Entites
{
    public class Conta
    {
        public int Numero {  get; set; }
        public string Nome { get; set; }
        public double Deposito { get; set; }
        public double SaqueLimite { get; set; }

        public Conta() { }
        public Conta(int numero, string nome, double deposito, double saqueLimite)
        {


            Numero = numero;
            Nome = nome;
            Deposito = deposito;
            SaqueLimite = saqueLimite;

        }

        public void Depositar()
        {
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Deposito = deposito;
            
        }

        public double sacar;
        public void Saque()
        {
            sacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (sacar < SaqueLimite)
            {
                Console.WriteLine("Valor atualizado: " + (Deposito - sacar).ToString("F2", CultureInfo.InvariantCulture));
            }
            if (sacar > SaqueLimite)
            {
                throw new TratamentoDeExceções("Erro ao sacar! O valor de saque é maior que o valor de Saque Limite");
            }
            
            if (sacar > Deposito)
            {
                throw new TratamentoDeExceções("Erro ao sacar! O valor de saque é maior que o valor depositado");
            }
        }
        
    }
}