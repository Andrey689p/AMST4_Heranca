namespace AMST4_Heranca.Models
{
    public class AccountPerson : Person 
    {
        public string CPF { get; set; } = string.Empty;
          private void ApplyInterest()
        {
            Balance += Balance * 0.02;
        }

        public override void Withdraw(double value)
        {
            ApplyInterest();
            base.Withdraw(value);
        }
    }
}