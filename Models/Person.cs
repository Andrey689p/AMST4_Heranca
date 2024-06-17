using System;

namespace AMST4_Heranca.Models;

    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public string Account { get; set; } = string.Empty;
        public string Agency { get; set; } = string.Empty;
        public double Balance { get; protected set; } = 0;

        public virtual void Withdraw(double value)
        {
            if (value <= Balance)
            {
                Balance -= value;
                Console.WriteLine($"Saque de R${value:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void Deposit(double value)
        {
            Balance += value;
            Console.WriteLine($"Depósito de R${value:F2} realizado com sucesso!");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Conta: {Account}, Agência: {Agency}, Saldo: {Balance:C}";
        }
    }