using System;
using System.Collections.Generic;
using AMST4_Heranca.Models;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        int option;
        do
        {
            Console.WriteLine("\n=== Menu Principal ===");
            Console.WriteLine("1. Cadastrar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Visualizar Saldo");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("\n=== Cadastro de Conta ===");
                        Console.WriteLine("1. Conta Poupança");
                        Console.WriteLine("2. Conta Corporativa");
                        Console.Write("Escolha o tipo de conta: ");
                        int accountType = int.Parse(Console.ReadLine()!);

                        if (accountType == 1)
                        {
                            person = new AccountPerson();
                            Console.Write("Digite o CPF: ");
                            ((AccountPerson)person).CPF = Console.ReadLine()!;
                        }
                        else if (accountType == 2)
                        {
                            person = new BusinessPerson();
                            Console.Write("Digite o CNPJ: ");
                            ((BusinessPerson)person).CNPJ = Console.ReadLine()!;
                        }
                        else
                        {
                            Console.WriteLine("Tipo de conta inválido. Cadastro cancelado.");
                            break;
                        }

                        Console.Write("Digite o nome: ");
                        person.Name = Console.ReadLine()!;
                        Console.Write("Digite o número da conta: ");
                        person.Account = Console.ReadLine()!;
                        Console.Write("Digite a agência: ");
                        person.Agency = Console.ReadLine()!;

                        Console.WriteLine("Cadastro realizado com sucesso!");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("\n=== Saque ===");

                        if (person != null)
                        {
                            Console.Write("Digite o valor do saque: ");
                            double value = double.Parse(Console.ReadLine()!);
                            person.Withdraw(value);
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("\n=== Depósito ===");


                        if (person != null)
                        {
                            Console.Write("Digite o valor do depósito: ");
                            double value = double.Parse(Console.ReadLine()!);
                            person.Deposit(value);
                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("\n=== Visualização de Saldo ===");

                        if (person != null)
                        {
                            Console.WriteLine($"Saldo atual: {person.Balance:C}");
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (option != 5);
    }
}