namespace AMST4_Heranca.Models
{
    public class BusinessPerson : Person
    {
        public string CNPJ { get; set; } = string.Empty;
        private void ApplyFee()
        {
            Balance -= Balance * 0.10;
        }

        public override void Withdraw(double value)
        {
            ApplyFee();
            base.Withdraw(value);
        }
    }
}